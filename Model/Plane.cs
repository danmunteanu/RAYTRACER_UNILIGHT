namespace UnilightRaytracer
{

    public class Plane : GObject
    {
        public Vector Normal { get; set; } = new (0, 1, 0);
        public float Distance { get; set; } = 0;

        public Plane()
        {
            Name = "Plane " + _instanceCount;
        }

        public Plane(Vector n, float d)
        {
            Normal = n;
            Distance = d;

            Name = "Plane " + _instanceCount;
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }

        public override Vector GetNormalAt(Vector p)
        {
            return Normal;
        }
    }

}