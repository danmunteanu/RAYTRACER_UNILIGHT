using CommonGraphics;

namespace UnilightRaytracer
{
    //  1st = Origin, 2nd = Direction
    using Ray = Tuple<Vector, Vector>;

    using IntPair = Tuple<int, int>;

    //  Eye, LookAt, ViewportWidth, ViewportHeight
    using TCamera = Tuple<Vector, Vector, float, float>;

    public class Raytracer
    {
        private static int DEFAULT_TRACE_DEPTH = 5;

        //  pixel traversal order
        public TraversalOrder TraversalOrder { get; set; }

        private struct RayTraversalResult
        {
            public GObject? Closest { get; set; }
            public float Distance { get; set; }
            public Vector? IntersectionPoint { get; set; }
        }

        public delegate void UpdateCallback(int percent);

        public UpdateCallback? Callback { get; set; } = null;

        public Camera Camera { get; set; } = new Camera();

        public Scene? Scene { get; set; } = null;

        //  Reference to the Bitmap we're drawing to
        public Bitmap? Buffer { get; set; } = null;

        private Intersector mIntersector = new Intersector();

        public bool GlobalReflection { get; set; } = true;
        public bool ComputeSpecular { get; set; } = false;
        public bool ComputeDiffuse { get; set; } = false;
        public bool ComputeAmbient { get; set; } = false;
        public bool ComputeFog { get; set; } = false;

        public int TraceDepth { get; set; } = DEFAULT_TRACE_DEPTH;

        private bool mStopRender = false;

        public Raytracer() { }

        private Color computeSpecular(float vDotR, float mGls, Color sourceSpec, float matSpec)
        {
            return sourceSpec.Multiply((float)Math.Pow(vDotR, mGls) * matSpec);
        }

        private Color computeDiffuse(float nDotL, Color sourceDiff, Color matDiff)
        {
            return sourceDiff.Multiply(nDotL).Multiply(matDiff);
        }

        private Color trace(Ray ray, int depth)
        {
            if (Scene == null) return Color.black;

            mIntersector.Ray = ray;

            GObject? closest = null;
            float dist = float.MaxValue;
            Vector intersectionPoint = new();

            for (int k = 0; k < Scene.CountObjects(); ++k)
            {
                GObject gObject = Scene.GetObjectAt(k);
                if (!gObject.Enabled) continue;

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

            Color lit = Color.black;

            if (closest != null && mIntersector.Result == Intersector.IntersectionResult.Hit)
            {
                Vector n = closest.GetNormalAt(intersectionPoint);
                n.Normalize();

                Material mat = closest.Material;
                float refl = mat.Reflection;

                Vector v = ray.Item1 - intersectionPoint; // point to eye vector
                v.Normalize();
                Vector r; // reflected ray
                Vector l; // light vector

                for (int k = 0; k < Scene.CountLights(); ++k)
                {
                    PointLight light = Scene.GetLightAt(k);
                    if (!light.isEnabled()) continue;

                    l = light.getPosition() - intersectionPoint;
                    l.Normalize();
                    r = 2 * n.Dot(l) * n - l;
                    r.Normalize();

                    if (ComputeSpecular)
                    {
                        float vDotR = v.Dot(r);
                        Color spec = (vDotR > 0)
                            ? computeSpecular(vDotR, mat.Gloss, light.getColor(), mat.Specular)
                            : Color.black;
                        lit = lit.Add(spec);
                    }

                    if (ComputeDiffuse)
                    {
                        float nDotL = n.Dot(l);
                        Color diff = (nDotL > 0)
                            ? computeDiffuse(nDotL, light.getColor(), mat.Color)
                            : Color.black;
                        lit = lit.Add(diff);
                    }

                    if (GlobalReflection && refl > 0 && depth < TraceDepth)
                    {
                        Ray reflected = new Ray(intersectionPoint, r);
                        Color acc = trace(reflected, depth + 1);
                        lit = lit.Add(acc.Multiply(refl).Multiply(mat.Color));
                    }
                }
            }

            return lit;
        }

        private Matrix4 imageToViewportTransform(int imgWidth, int imgHeight, Camera cam)
        {
            float width = cam.ViewportWidth;
            float height = cam.ViewportHeight;
            if (imgWidth == 0 || imgHeight == 0 || width == 0 || height == 0)
                return Matrix4.identity();

            Matrix4 finalTransform = Matrix4.translate(cam.LookAt.X, cam.LookAt.Y, cam.LookAt.Z);

            Vector invNormal = cam.Eye - cam.LookAt;
            invNormal.Normalize();

            Matrix4 scale = Matrix4.identity();
            scale.SetAt(0, 0, width / imgWidth);
            scale.SetAt(1, 1, height / imgHeight);
            finalTransform.MultiplyThisBy(scale);

            Matrix4 mirror = Matrix4.identity();
            mirror.SetAt(1, 1, -1);
            finalTransform.MultiplyThisBy(mirror);

            Matrix4 center = Matrix4.translate(-imgWidth / 2, -imgHeight / 2, 0);
            finalTransform.MultiplyThisBy(center);

            return finalTransform;
        }

        public void Render()
        {
            if (Buffer == null)
                return;

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
            //Parallel.ForEach(chunks, chunk =>
            //{
            //    RenderChunk(chunk.start, chunk.end, pixels, stride);
            //});

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

            //  TBD: Compute this only once, not for every thread
            Matrix4 i2v = imageToViewportTransform(Buffer.Width, Buffer.Height, Camera);

            while (!iter.Done())
            {
                Vector mapped = i2v.Multiply(new Vector(iter.Cursor.X, iter.Cursor.Y, 0));
                Vector dir = mapped - Camera.Eye;
                dir.Normalize();
                Ray ray = new Ray(Camera.Eye, dir);

                Color c = trace(ray, 1);

                // Write into pixel array (thread-safe)
                int index = iter.Cursor.Y * stride + iter.Cursor.X * 4;
                pixels[index + 0] = (byte)(c.b * 255);
                pixels[index + 1] = (byte)(c.g * 255);
                pixels[index + 2] = (byte)(c.r * 255);
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
