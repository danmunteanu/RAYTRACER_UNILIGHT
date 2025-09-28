using CommonGraphics;

namespace Unilight
{
    //  1st = Origin, 2nd = Direction
    using Ray = Tuple<Vector3D, Vector3D>;

    public class Raytracer
    {
        private static int DEFAULT_TRACE_DEPTH = 5;

        //  pixel traversal order
        public TraversalOrder TraversalOrder { get; set; }

        private struct RayTraversalResult
        {
            public GObject? Closest { get; set; }
            public float Distance { get; set; }
            public Vector3D? IntersectionPoint { get; set; }
        }

        public delegate void UpdateCallback(int percent);

        public UpdateCallback? Callback { get; set; } = null;

        public Camera Camera { get; set; } = new Camera();

        public Scene? Scene { get; set; } = null;

        //  Reference to the Bitmap we're drawing to
        public Bitmap? Buffer { get; set; } = null;

        private Intersector mIntersector = new Intersector();

        private Matrix4? _imageToWorld = null;

        public bool GlobalReflection { get; set; } = true;
        public bool ComputeSpecular { get; set; } = false;
        public bool ComputeDiffuse { get; set; } = false;
        public bool ComputeAmbient { get; set; } = false;
        public bool ComputeFog { get; set; } = false;

        public int TraceDepth { get; set; } = DEFAULT_TRACE_DEPTH;

        public Raytracer() 
        { 
        }

        private RgbColor computeSpecular(float vDotR, float mGls, RgbColor sourceSpec, float matSpec)
        {
            float factor = (float)Math.Pow(vDotR, mGls) * matSpec;
            return sourceSpec * factor;
        }

        private RgbColor computeDiffuse(float nDotL, RgbColor sourceDiff, RgbColor matDiff)
        {
            return sourceDiff * nDotL * matDiff;
        }

        private RgbColor trace(Ray ray, int depth)
        {
            if (Scene == null) 
                return RgbColor.Black;

            mIntersector.Ray = ray;

            GObject? closest = null;
            float dist = float.MaxValue;
            Vector3D intersectionPoint = new();

            for (int k = 0; k < Scene.ObjectCount; ++k)
            {
                GObject? gObject = Scene.GetObjectAt(k);
                if (gObject == null || !gObject.Enabled) 
                    continue;

                gObject.Accept(mIntersector);

                if (mIntersector.Result == Intersector.IntersectionResult.Hit &&
                    dist > mIntersector.Distance)
                {
                    dist = mIntersector.Distance;
                    closest = gObject;
                    intersectionPoint = mIntersector.IntersectionPoint;
                    break;
                }
            }

            RgbColor lit = RgbColor.Black;

            if (closest != null && mIntersector.Result == Intersector.IntersectionResult.Hit)
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

                    if (ComputeSpecular)
                    {
                        float vDotR = v.Dot(r);
                        RgbColor spec = (vDotR > 0)
                            ? computeSpecular(vDotR, mat.Gloss, light.getColor(), mat.Specular)
                            : RgbColor.Black;
                        lit = lit + spec;
                    }

                    if (ComputeDiffuse)
                    {
                        float nDotL = n.Dot(l);
                        RgbColor diff = (nDotL > 0)
                            ? computeDiffuse(nDotL, light.getColor(), mat.Color)
                            : RgbColor.Black;
                        lit = lit + diff;
                    }

                    if (GlobalReflection && refl > 0 && depth < TraceDepth)
                    {
                        Ray reflected = new Ray(intersectionPoint, r);
                        RgbColor acc = trace(reflected, depth + 1);
                        lit += acc * refl * mat.Color;
                    }
                }
            }

            return lit;
        }

        private void ComputeImageToViewportTransform(int imageWidth, int imageHeight, out Matrix4 result)
        {
            float width = Camera.ViewportWidth;
            float height = Camera.ViewportHeight;

            // If any dimension is zero, return identity
            if (imageWidth == 0 || imageHeight == 0 || width == 0 || height == 0)
            {
                Matrix4.LoadIdentity(out result);
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
            result = finalTransform;
        }


        public void Render()
        {
            if (Buffer == null)
                return;

            //  Compute image to world transform
            ComputeImageToViewportTransform(Buffer.Width, Buffer.Height, out _imageToWorld);

            List<(Point start, Point end)>? chunks = null;
            Chunks.CreateRenderChunks(Buffer.Width, Buffer.Height, out chunks);

            if (chunks == null)
                return;

            // Lock the bitmap once
            var rect = new Rectangle(0, 0, Buffer.Width, Buffer.Height);
            var bmpData = Buffer.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;
            int stride = bmpData.Stride;
            byte[] pixels = new byte[stride * Buffer.Height];

            //_plottedPixels = 0;
            //PixelsToPlotCount = Buffer.Width * Buffer.Height;

            // Render all chunks in parallel
            Parallel.ForEach(chunks, chunk =>
            {
                RenderChunk(chunk.start, chunk.end, pixels, stride);
            });

            RenderChunk(new Point(0, 0), new Point(Buffer.Width, Buffer.Height), pixels, stride);

            // Copy back into bitmap
            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, ptr, pixels.Length);
            Buffer.UnlockBits(bmpData);

            // 100% progress
            //CallbackProgress?.Invoke(100);
        }

        private void RenderChunk(Point start, Point end, byte[] pixels, int stride)
        {
            if (Buffer == null)
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

                RgbColor c = trace(ray, 1);

                // Write into pixel array (thread-safe)
                int index = iter.Cursor.Y * stride + iter.Cursor.X * 4;
                pixels[index + 0] = (byte)(c.B * 255);
                pixels[index + 1] = (byte)(c.G * 255);
                pixels[index + 2] = (byte)(c.R * 255);
                pixels[index + 3] = 255; // full opacity

                // Thread-safe progress update
                //int plotted = Interlocked.Increment(ref _plottedPixels);
                //int percent = (int)((plotted / (double)PixelsToPlotCount) * 100);

                //  Advance iterator
                iter.Step();
            }
        }
    }
}
