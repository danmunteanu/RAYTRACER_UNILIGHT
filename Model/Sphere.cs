namespace UnilightRaytracer
{

    public class Sphere : GObject
    {
        public float Radius { get; set; } = 1;

        public Sphere()
        {
            Name = "Sphere " + _instanceCount;
        }

        public Sphere(Vector origin, float radius)
        {
            Origin = origin;
            this.Radius = radius;
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }

        public override Vector GetNormalAt(Vector p)
        {
            return p.Subtract(Origin).Multiply(Radius);
        }

        /*public override Tuple<Vector, Vector> ComputeBoundary()
        {
            return new Tuple<Vector, Vector>(
                new Vector(Origin.X - Radius, Origin.Y - Radius, Origin.Z - Radius),
                new Vector(Origin.X + Radius, Origin.Y + Radius, Origin.Z + Radius)
            );
        }*/
    }

}