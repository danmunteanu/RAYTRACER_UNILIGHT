/*
 * Matrix4.cs
 * 
 * Represents a 4x4 matrix with float components for 3D transformations.
 * Designed for graphics, raytracing, and general linear algebra operations.
 * 
 * Features:
 *   - Operator overloads for matrix addition (+), subtraction (-), and multiplication (*)
 *   - Scalar multiplication and matrix-vector multiplication
 *   - Mutable operations via MultiplyThisBy for in-place updates
 *   - "Load" methods (LoadIdentity, LoadZero, LoadTranslate, LoadScale, LoadRotate) 
 *     that initialize matrices via out parameters
 *   - Indexer for convenient element access: matrix[i, j]
 * 
 * Usage:
 *   Matrix4.LoadIdentity(out var m);                      // loads identity matrix
 *   Matrix4.LoadTranslate(1, 2, 3, out var t);           // translation matrix
 *   var combined = m * t;                                 // combine transforms
 *   var vTransformed = combined.Multiply(vector);        // transform a Vector3D
 *
 * Author: Dan Munteanu
 * Date: 28-Sep-2025
 */

namespace Unilight
{
    public class Matrix4
    {
        public enum Axis { XAxis, YAxis, ZAxis };

        private float[,] values = new float[4, 4];

        public Matrix4()
        {
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    values[i, j] = 0;
        }

        // Indexer for convenience
        public float this[int i, int j]
        {
            get => values[i, j];
            set => values[i, j] = value;
        }

        // Operator overloads
        public static Matrix4 operator +(Matrix4 a, Matrix4 b)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }

        public static Matrix4 operator -(Matrix4 a, Matrix4 b)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    result[i, j] = a[i, j] - b[i, j];
            return result;
        }

        public static Matrix4 operator *(Matrix4 a, float scalar)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    result[i, j] = a[i, j] * scalar;
            return result;
        }

        public static Matrix4 operator *(Matrix4 a, Matrix4 b)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    float sum = 0;
                    for (int k = 0; k < 4; ++k)
                        sum += a[i, k] * b[k, j];
                    result[i, j] = sum;
                }
            }
            return result;
        }

        // Multiply a vector
        public Vector3D MultiplyBy(Vector3D v)
        {
            return new Vector3D
            {
                X = values[0, 0] * v.X + values[0, 1] * v.Y + values[0, 2] * v.Z + values[0, 3],
                Y = values[1, 0] * v.X + values[1, 1] * v.Y + values[1, 2] * v.Z + values[1, 3],
                Z = values[2, 0] * v.X + values[2, 1] * v.Y + values[2, 2] * v.Z + values[2, 3]
            };
        }

        // Mutable operations
        public void MultiplyThisBy(Matrix4 m)
        {
            var result = this * m;
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    values[i, j] = result[i, j];
        }

        public void MultiplyThisBy(float scalar)
        {
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    values[i, j] *= scalar;
        }

        // ---Convenience "Load" methods (void with out parameter)
        public static void LoadIdentity(out Matrix4 result)
        {
            result = new Matrix4();
            result[0, 0] = 1; result[1, 1] = 1; result[2, 2] = 1; result[3, 3] = 1;
        }

        public static void LoadZero(out Matrix4 result)
        {
            result = new Matrix4(); // all elements already 0
        }

        public static void LoadTranslate(float tx, float ty, float tz, out Matrix4 result)
        {
            LoadIdentity(out result);
            result[0, 3] = tx;
            result[1, 3] = ty;
            result[2, 3] = tz;
        }

        public static void LoadScale(float sx, float sy, float sz, out Matrix4 result)
        {
            LoadIdentity(out result);
            result[0, 0] = sx;
            result[1, 1] = sy;
            result[2, 2] = sz;
        }

        public static void LoadRotate(float angle, Axis axis, out Matrix4 result)
        {
            LoadIdentity(out result);
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            switch (axis)
            {
                case Axis.XAxis:
                    result[1, 1] = cos; result[1, 2] = sin;
                    result[2, 1] = -sin; result[2, 2] = cos;
                    break;

                case Axis.YAxis:
                    result[0, 0] = cos; result[0, 2] = -sin;
                    result[2, 0] = sin; result[2, 2] = cos;
                    break;

                case Axis.ZAxis:
                    result[0, 0] = cos; result[0, 1] = sin;
                    result[1, 0] = -sin; result[1, 1] = cos;
                    break;
            }
        }

        // Indexer for direct access
        public float GetAt(int i, int j) => values[i, j];
        public void SetAt(int i, int j, float value) => values[i, j] = value;
    }
}
