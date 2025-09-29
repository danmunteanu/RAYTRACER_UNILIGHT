using CommonGraphics;

namespace Unilight
{
    //  1st = Origin, 2nd = Direction
    using Ray = Tuple<Vector3D, Vector3D>;

    public class Raytracer : RenderBase
    {
        private static readonly int DEFAULT_TRACE_DEPTH = 5;

        private struct RayTraversalResult
        {
            public GObject? Closest { get; set; }
            public float Distance { get; set; }
            public Vector3D? IntersectionPoint { get; set; }
        }

        //  Camera instance
        public Camera Camera { get; set; } = new Camera();

        //  Reference to a Scene instance containing the objects to render
        public Scene? Scene { get; set; } = null;

        //  How deep shall we go?
        public int TraceDepth { get; set; } = DEFAULT_TRACE_DEPTH;

        public bool GlobalReflectionEnabled { get; set; } = true;
        public bool ComputeSpecularEnabled { get; set; } = false;
        public bool ComputeDiffuseEnabled { get; set; } = false;
        public bool ComputeAmbientEnabled { get; set; } = false;
        public bool ComputeFogEnabled { get; set; } = false;

        //  Each thread gets its own Intersector instance
        private ThreadLocal<Intersector> _intersector = new(() => new Intersector());

        //  Holds the transform that will convert a pixel on screen to 3D world coordinates
        //  Computed in ComputeImageToViewportTransform
        private Matrix4? _imageToWorld = null;

        //  Pixel traversal order
        public TraversalOrder TraversalOrder { get; set; }

        public Raytracer() 
        {
            //  pass a chunk renderer to the base class
            base.RenderChunk = RenderChunk;
        }

        private RgbColor Trace(Ray ray, int depth)
        {
            if (Scene == null || _intersector.Value == null) 
                return RgbColor.Black;

            Intersector intersector = _intersector.Value;
            intersector.Ray = ray;

            GObject? closest = null;
            float dist = float.MaxValue;
            Vector3D intersectionPoint = new();

            for (int k = 0; k < Scene.ObjectCount; ++k)
            {
                GObject? gObject = Scene.GetObjectAt(k);
                if (gObject == null || !gObject.Enabled) 
                    continue;

                gObject.Accept(intersector);

                if (intersector.Result == Intersector.IntersectionResult.Hit &&
                    dist > intersector.Distance)
                {
                    dist = intersector.Distance;
                    closest = gObject;
                    intersectionPoint = intersector.IntersectionPoint;
                    break;
                }
            }

            RgbColor lit = RgbColor.Black;

            if (closest != null && intersector.Result == Intersector.IntersectionResult.Hit)
            {
                Vector3D n = closest.GetNormalAt(intersectionPoint);
                n.Normalize();

                Material mat = closest.Material;
                float refl = mat.Reflection;

                Vector3D v = ray.Item1 - intersectionPoint; // point to eye vector
                v.Normalize();
                Vector3D r; // reflected ray
                Vector3D l; // light vector

                for (int k = 0; k < Scene.LightCount; ++k)
                {
                    PointLight? light = Scene.GetLightAt(k);
                    if (light == null || !light.isEnabled()) 
                        continue;

                    l = light.getPosition() - intersectionPoint;
                    l.Normalize();
                    r = 2 * n.Dot(l) * n - l;
                    r.Normalize();

                    if (ComputeSpecularEnabled)
                    {
                        float vDotR = v.Dot(r);
                        RgbColor spec = (vDotR > 0)
                            ? ComputeSpecularColor(vDotR, mat.Gloss, light.getColor(), mat.Specular)
                            : RgbColor.Black;
                        lit = lit + spec;
                    }

                    if (ComputeDiffuseEnabled)
                    {
                        float nDotL = n.Dot(l);
                        RgbColor diff = (nDotL > 0)
                            ? ComputeDiffuseColor(nDotL, light.getColor(), mat.Color)
                            : RgbColor.Black;
                        lit = lit + diff;
                    }

                    if (GlobalReflectionEnabled && refl > 0 && depth < TraceDepth)
                    {
                        Ray reflected = new Ray(intersectionPoint, r);
                        RgbColor acc = Trace(reflected, depth + 1);
                        lit += acc * refl * mat.Color;
                    }
                }
            }

            return lit;
        }

        private RgbColor ComputeSpecularColor(float vDotR, float mGls, RgbColor sourceSpec, float matSpec)
        {
            float factor = (float)Math.Pow(vDotR, mGls) * matSpec;
            return sourceSpec * factor;
        }

        private RgbColor ComputeDiffuseColor(float nDotL, RgbColor sourceDiff, RgbColor matDiff)
        {
            return sourceDiff * nDotL * matDiff;
        }

        public Ray GetRayFromPixel(int x, int y)
        {
            if (_imageToWorld == null)
            {
                if (Buffer == null)
                    throw new InvalidOperationException("Buffer is not initialized.");

                ComputeImageToViewportTransform(Buffer.Width, Buffer.Height, out _imageToWorld);
            }

            Vector3D mapped = _imageToWorld.MultiplyBy(new Vector3D(x, y, 0));
            Vector3D dir = mapped - Camera.Eye;
            dir.Normalize();

            return new Ray(Camera.Eye, dir);
        }


        public GObject? PickObjectAt(int x, int y, out Vector3D? hitPoint)
        {
            hitPoint = null;

            if (Scene == null)
                return null;

            Ray ray = GetRayFromPixel(x, y);

            Intersector? intersector = _intersector.Value;
            if (intersector == null)
                return null;

            intersector.Ray = ray;

            GObject? closest = null;
            float dist = float.MaxValue;
            Vector3D intersectionPoint = new();

            for (int k = 0; k < Scene.ObjectCount; ++k)
            {
                GObject? gObject = Scene.GetObjectAt(k);
                if (gObject == null || !gObject.Enabled)
                    continue;

                gObject.Accept(intersector);

                if (intersector.Result == Intersector.IntersectionResult.Hit &&
                    intersector.Distance < dist)
                {
                    dist = intersector.Distance;
                    closest = gObject;
                    intersectionPoint = intersector.IntersectionPoint;
                }
            }

            if (closest != null)
            {
                hitPoint = intersectionPoint;
                return closest;
            }

            return null;
        }

        private void ComputeImageToViewportTransform(int imageWidth, int imageHeight, out Matrix4 transform)
        {
            float width = Camera.ViewportWidth;
            float height = Camera.ViewportHeight;

            // If any dimension is zero, return identity
            if (imageWidth == 0 || imageHeight == 0 || width == 0 || height == 0)
            {
                Matrix4.LoadIdentity(out transform);
                return;
            }

            // Step 1: Translation to camera LookAt
            Matrix4 finalTransform;
            Matrix4.LoadTranslate(Camera.LookAt.X, Camera.LookAt.Y, Camera.LookAt.Z, out finalTransform);

            // Step 2: Scale viewport to image dimensions
            Matrix4 scale;
            Matrix4.LoadIdentity(out scale);
            scale.SetAt(0, 0, width / imageWidth);
            scale.SetAt(1, 1, height / imageHeight);
            finalTransform.MultiplyThisBy(scale);

            // Step 3: Mirror Y axis
            Matrix4 mirror;
            Matrix4.LoadIdentity(out mirror);
            mirror.SetAt(1, 1, -1);
            finalTransform.MultiplyThisBy(mirror);

            // Step 4: Center the image
            Matrix4 center;
            Matrix4.LoadTranslate(-imageWidth / 2f, -imageHeight / 2f, 0f, out center);
            finalTransform.MultiplyThisBy(center);

            // Output the final transform
            transform = finalTransform;
        }

        public override void Render()
        {
            if (Buffer == null)
                return;

            //  Compute image to world transform once
            ComputeImageToViewportTransform(Buffer.Width, Buffer.Height, out _imageToWorld);

            base.Render();
            
        }

        private void RenderChunk(Point start, Point end, byte[] pixels, int stride)
        {
            if (Buffer == null || _imageToWorld == null)
                return;

            // Compute width and height
            int width = end.X - start.X;
            int height = end.Y - start.Y;

            PixelIterator iter = new PixelIterator(start, end, TraversalOrder);

            while (!iter.Done())
            {
                Vector3D mapped = _imageToWorld.MultiplyBy(new Vector3D(iter.Cursor.X, iter.Cursor.Y, 0));
                Vector3D dir = mapped - Camera.Eye;

                dir.Normalize();
                Ray ray = new Ray(Camera.Eye, dir);

                RgbColor c = Trace(ray, 1);

                // Write into pixel array (thread-safe)
                int index = iter.Cursor.Y * stride + iter.Cursor.X * 4;
                pixels[index + 0] = (byte)(c.B * 255);
                pixels[index + 1] = (byte)(c.G * 255);
                pixels[index + 2] = (byte)(c.R * 255);
                pixels[index + 3] = 255; // full opacity

                // Increment pixel counter atomically
                int plotted = Interlocked.Increment(ref _plottedPixels);

                // Calculate progress
                int percent = (int)((plotted / (double)_pixelsToPlotCount) * 100);

                // Only report if crossed the next 5% threshold
                if (percent / 5 > _lastReportedPercent / 5)
                {
                    _lastReportedPercent = percent;
                    Callback?.Invoke(percent);
                }

                //  Advance iterator
                iter.Step();
            }
        }
    }
}
