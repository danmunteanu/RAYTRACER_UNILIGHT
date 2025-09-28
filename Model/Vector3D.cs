/*
 * Vector.cs
 * 
 * Represents a 3D vector with float components (X, Y, Z) and provides 
 * common vector operations for graphics, raytracing, and physics calculations.
 * 
 * Features:
 *   - Immutable operations: Dot, Cross, Length, Normalized
 *   - Mutable operations: Scale, Normalize
 *   - Operator overloads for +, -, *, / to simplify arithmetic
 *   - Predefined constants: Zero (0,0,0) and One (1,1,1)
 *   - Equality comparison with optional epsilon tolerance
 *   - ToString override for easy debugging output
 * 
 * Usage:
 *   Vector v1 = new Vector(1, 2, 3);
 *   Vector v2 = new Vector(0, 1, 0);
 *   Vector cross = v1.Cross(v2);         // immutable cross product
 *   v1.Normalize();                       // mutates v1 to unit length
 *   float len = v2.Length();              // computes vector length
 *   Vector sum = v1 + v2;                 // uses operator overload
 *
 * Author: Dan Munteanu
 * Date: 28-Sep-2025
 */

namespace Unilight
{
    public struct Vector3D
    {
        public float X;
        public float Y;
        public float Z;

        public static readonly Vector3D Zero = new(0, 0, 0);
        public static readonly Vector3D One = new(1, 1, 1);

        public Vector3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Immutable operations
        public readonly float Dot(Vector3D v) => X * v.X + Y * v.Y + Z * v.Z;

        public readonly Vector3D Cross(Vector3D v) => new(
            Y * v.Z - Z * v.Y,
            Z * v.X - X * v.Z,
            X * v.Y - Y * v.X
        );

        public readonly float Length() => (float)Math.Sqrt(X * X + Y * Y + Z * Z);

        public readonly Vector3D Normalized()
        {
            float len = Length();
            return len > 1e-6f ? this / len : Zero;
        }

        // Mutable operations
        public void Scale(float k) { X *= k; Y *= k; Z *= k; }

        public void Normalize()
        {
            float len = Length();
            if (len > 1e-6f) Scale(1f / len);
        }

        // Equality
        public bool Equals(Vector3D v, float eps = 1e-6f) =>
            Math.Abs(X - v.X) < eps && Math.Abs(Y - v.Y) < eps && Math.Abs(Z - v.Z) < eps;

        public override bool Equals(object obj) => obj is Vector3D v && Equals(v);
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        public override string ToString() => $"({X}, {Y}, {Z})";

        // Operator overloads (immutable style)
        public static Vector3D operator +(Vector3D a, Vector3D b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3D operator -(Vector3D a, Vector3D b) => new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector3D operator *(Vector3D a, float k) => new(a.X * k, a.Y * k, a.Z * k);
        public static Vector3D operator *(float k, Vector3D a) => a * k;
        public static Vector3D operator /(Vector3D a, float k) => new(a.X / k, a.Y / k, a.Z / k);
    }
}
