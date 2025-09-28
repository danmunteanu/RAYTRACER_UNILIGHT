namespace Unilight
{

    public class Box : GObject
    {
        public float Width { get; set; } = 1;
        public float Height { get; set; } = 1;
        public float Depth { get; set; } = 1;

        public override void Accept (Visitor v)
        {
            v.Visit (this);
        }
    
        public override Vector GetNormalAt(Vector p)
        {
            // Compute local coordinates relative to box center
            Vector local = p - Origin;
            float halfW = Width / 2f;
            float halfH = Height / 2f;
            float halfD = Depth / 2f;

            // Determine which face p is closest to
            float dx = Math.Abs(local.X - halfW);
            float dxNeg = Math.Abs(local.X + halfW);
            float dy = Math.Abs(local.Y - halfH);
            float dyNeg = Math.Abs(local.Y + halfH);
            float dz = Math.Abs(local.Z - halfD);
            float dzNeg = Math.Abs(local.Z + halfD);

            float min = Math.Min(Math.Min(Math.Min(dx, dxNeg), Math.Min(dy, dyNeg)), Math.Min(dz, dzNeg));

            if (min == dx) return new Vector(1, 0, 0);
            if (min == dxNeg) return new Vector(-1, 0, 0);
            if (min == dy) return new Vector(0, 1, 0);
            if (min == dyNeg) return new Vector(0, -1, 0);
            if (min == dz) return new Vector(0, 0, 1);
            return new Vector(0, 0, -1);
        }
    }

}