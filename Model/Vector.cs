namespace UnilightRaytracer
{

public struct Vector
{
    public float X;
    public float Y;
    public float Z;

    public static readonly Vector Zero = new Vector(0, 0, 0);
    public static readonly Vector One = new Vector(1, 1, 1);

    public Vector(float x, float y, float z = 0)
    {
        X = x; Y = y; Z = z;
    }

    public readonly Vector Add(Vector v) => new Vector(X + v.X, Y + v.Y, Z + v.Z);
    public readonly Vector Subtract(Vector v) => new Vector(X - v.X, Y - v.Y, Z - v.Z);
    public readonly Vector Multiply(float k) => new Vector(X * k, Y * k, Z * k);
    public readonly float Dot(Vector v) => X * v.X + Y * v.Y + Z * v.Z;
    public readonly Vector Cross(Vector v) => new Vector(Y * v.Z - Z * v.Y, Z * v.X - X * v.Z, X * v.Y - Y * v.X);

    public void Scale(float k) { X *= k; Y *= k; Z *= k; }

    public readonly float Length() => (float)Math.Sqrt(X * X + Y * Y + Z * Z);

    public void Normalize()
    {
        float len = Length();
        if (len > 1e-6f) Scale(1.0f / len);
    }

    public bool Equals(Vector v, float eps = 1e-6f) =>
        Math.Abs(X - v.X) < eps && Math.Abs(Y - v.Y) < eps && Math.Abs(Z - v.Z) < eps;

    public override bool Equals(object obj) => obj is Vector v && Equals(v);
    public override int GetHashCode() => HashCode.Combine(X, Y, Z);

    public override string ToString() => $"({X}, {Y}, {Z})";

    public static Vector operator +(Vector a, Vector b) => a.Add(b);
    public static Vector operator -(Vector a, Vector b) => a.Subtract(b);
    public static Vector operator *(Vector a, float k) => a.Multiply(k);
    public static Vector operator *(float k, Vector a) => a.Multiply(k);
    public static Vector operator /(Vector a, float k) => new Vector(a.X / k, a.Y / k, a.Z / k);
}

}
