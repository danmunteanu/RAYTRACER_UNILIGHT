namespace UnilightRaytracer
{
    // Item1 = Origin, Item2 = Direction
    using Ray = Tuple<Vector, Vector>;

    public class Intersector : Visitor
    {
        public enum IntersectionResult { Hit, Miss }

        private Ray? mRay = null;
        public Ray? Ray
        {
            get => mRay;
            set
            {
                mRay = value;
                intersectionMiss();
            }
        }

        // result of intersection
        public IntersectionResult Result { get; set; } = IntersectionResult.Miss;

        // distance of intersection
        public float Distance { get; set; } = float.MaxValue;

        // point of intersection (non-nullable now)
        public Vector IntersectionPoint { get; set; } = Vector.Zero;

        private void intersectionMiss()
        {
            Result = IntersectionResult.Miss;
            Distance = float.MaxValue;
            IntersectionPoint = Vector.Zero;
        }

        public void Visit(Plane p)
        {
            if (mRay == null)
            {
                intersectionMiss();
                return;
            }

            float dot = mRay.Item2.Dot(p.Normal);
            if (dot != 0)
            {
                Result = IntersectionResult.Hit;
                Distance = (p.Distance - mRay.Item1.Dot(p.Normal)) / dot;
                IntersectionPoint = mRay.Item1 + mRay.Item2 * Distance;
            }
            else
            {
                intersectionMiss();
            }
        }

        public void Visit(Sphere s)
        {
            if (mRay == null)
            {
                intersectionMiss();
                return;
            }

            Vector e = s.Origin - mRay.Item1;
            float a = e.Dot(mRay.Item2);
            float e2 = e.Length();
            e2 *= e2;
            float r = s.Radius;
            float delta = r * r - e2 + a * a;

            if (delta >= 0)
            {
                Result = IntersectionResult.Hit;
                Distance = a - (float)Math.Sqrt(delta);
                IntersectionPoint = mRay.Item1 + mRay.Item2 * Distance;
            }
            else
            {
                intersectionMiss();
            }
        }

        public void Visit(Triangle tri)
        {
            if (mRay == null)
            {
                intersectionMiss();
                return;
            }

            Vector origin = tri.Origin;
            Vector v1 = tri.getV1() + origin;
            Vector v2 = tri.getV2() + origin;
            Vector v3 = tri.getV3() + origin;

            // Implementation of Möller's algorithm
            Vector E1 = v2 - v1;
            Vector E2 = v3 - v1;
            Vector D = mRay.Item2;
            Vector P = D.Cross(E2);
            Vector T = mRay.Item1 - v1;
            Vector Q = T.Cross(E1);

            float pDotE1Inv = 1.0f / P.Dot(E1);

            float t = pDotE1Inv * Q.Dot(E2);
            float u = pDotE1Inv * P.Dot(T);
            float v = pDotE1Inv * Q.Dot(D);

            if (u >= 0 && v >= 0 && u + v <= 1)
            {
                // hit
                Result = IntersectionResult.Hit;
                Distance = t;
                IntersectionPoint = v1 * (1 - u - v) + v2 * u + v3 * v;
            }
            else
            {
                intersectionMiss();
            }
        }

        public void Visit(Box c)
        {
            // setup the triangles that make up the box
        }
    }
}
