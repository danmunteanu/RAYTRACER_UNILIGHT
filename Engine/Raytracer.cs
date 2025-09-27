/*
 * The actual raytracing algorithm
 */
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

        private struct RayTraversalResult
        {
            public GObject? Closest { get; set; }
            public float Distance { get; set; }
            public Vector? IntersectionPoint { get; set; }
        }

        public delegate void UpdateCallback(int percent);

        public UpdateCallback? Callback { get; set; } = null;

        public Scene? Scene { get; set; } = null;
        private ObservableImage? mObservableImage = null;
        private Camera mCamera = new Camera();
        private Intersector mIntersector = new Intersector();

        public int TraceDepth { get; set; } = DEFAULT_TRACE_DEPTH;

        public bool ApplyGlobalReflection { get; set; } = true;
        public bool ComputeSpecular { get; set; } = false;
        public bool ComputeDiffuse { get; set; } = false;
        public bool ComputeAmbient { get; set; } = false;
        public bool ComputeFog { get; set; } = false;

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
            Vector intersectionPoint = new ();

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

                    if (ApplyGlobalReflection && refl > 0 && depth < TraceDepth)
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
            if (mObservableImage == null) return;

            int imgWidth = mObservableImage.Width;
            int imgHeight = mObservableImage.Height;
            long total = imgWidth * imgHeight;
            if (total <= 0) return;

            float factor = 100.0f / total;
            int lastPercent = 0;
            long count = 0;

            Matrix4 i2v = imageToViewportTransform(imgWidth, imgHeight, mCamera);
            mObservableImage.Clear();

            for (int p = 0; !mStopRender && p < imgWidth; ++p)
            {
                for (int q = 0; !mStopRender && q < imgHeight; ++q)
                {
                    int percent = (int)(count * factor);
                    if (percent != lastPercent && Callback != null) Callback(percent);
                    lastPercent = percent;

                    Vector mapped = i2v.Multiply(new Vector(p, q, 0));
                    Vector dir = mapped - mCamera.Eye;
                    dir.Normalize();
                    Ray ray = new Ray(mCamera.Eye, dir);

                    Color c = trace(ray, 1);
                    mObservableImage.SetRGB(p, q, c);

                    ++count;
                }
            }

            Callback?.Invoke(100);
            mStopRender = false;
        }

        public void setImage(ObservableImage img) => mObservableImage = img;
        public Camera getCamera() => mCamera;
        public void setCamera(Camera camera) => mCamera = camera;
    }
}
