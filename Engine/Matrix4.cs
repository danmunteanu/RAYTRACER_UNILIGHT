namespace Unilight
{
    public class Matrix4
    {
        public enum Axis { XAxis, YAxis, ZAxis };

        private float[,] values = new float[4, 4];

        public Matrix4()
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    values[i, j] = 0;
                }
            }
        }

        public Matrix4 Add(Matrix4 m)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    result.SetAt(i, j, values[i, j] + m.values[i, j]);
                }
            }
            return result;
        }

        public void IncreaseBy(Matrix4 m)
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    values[i, j] += m.values[i, j];
                }
            }
        }

        public Matrix4 Subtract(Matrix4 m)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    result.SetAt(i, j, values[i, j] - m.values[i, j]);
                }
            }
            return result;
        }

        public void DecreaseBy(Matrix4 m)
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    values[i, j] -= m.values[i, j];
                }
            }
        }

        public void MultiplyThisBy(float scalar)
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    values[i, j] *= scalar;
                }
            }
        }

        public Matrix4 Multiply(Matrix4 m)
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    float v = 0;
                    for (int k = 0; k < 4; ++k)
                    {
                        v += values[i, k] * m.values[k, j];
                    }
                    result.values[i, j] = v;
                }
            }
            return result;
        }

        public void MultiplyThisBy(Matrix4 m)
        {
            Matrix4 result = this.Multiply(m);
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    values[i, j] = result.values[i, j];
                }
            }
        }

        public Vector Multiply(Vector v)
        {
            Vector result = new Vector();

            //  compute x
            float sum = 0;
            for (int j = 0; j < 3; ++j)
            {
                sum += values[0, j] * v.X;
            }
            sum += values[0, 3];
            result.X = sum;

            //  compute y
            sum = 0;
            for (int j = 0; j < 3; ++j)
            {
                sum += values[1, j] * v.Y;
            }
            sum += values[1, 3];
            result.Y = sum;

            //  compute z
            sum = 0;
            for (int j = 0; j < 3; ++j)
            {
                sum += values[2, j] * v.Z;
            }
            sum += values[2, 3];
            result.Z = sum;

            return result;
        }

        public void SetAt(int i, int j, float value)
        {
            values[i, j] = value;
        }

        public float GetAt(int i, int j)
        {
            return values[i, j];
        }

        //  x = 0, y = 1, z = 1
        public static Matrix4 rotate(float angle, Matrix4.Axis axis)
        {
            Matrix4 result = new Matrix4();
            float cosAngle = (float)Math.Cos(angle);
            float sinAngle = (float)Math.Sin(angle); ;
            switch (axis)
            {
                case Matrix4.Axis.XAxis:
                    result.SetAt(0, 0, 1);
                    result.SetAt(1, 1, cosAngle);
                    result.SetAt(1, 2, sinAngle);
                    result.SetAt(2, 1, -sinAngle);
                    result.SetAt(2, 2, cosAngle);
                    break;

                case Matrix4.Axis.YAxis:
                    result.SetAt(0, 0, cosAngle);
                    result.SetAt(0, 2, -sinAngle);
                    result.SetAt(1, 1, 1);
                    result.SetAt(2, 0, sinAngle);
                    result.SetAt(2, 2, cosAngle);
                    break;

                case Matrix4.Axis.ZAxis:
                    result.SetAt(0, 0, cosAngle);
                    result.SetAt(0, 1, sinAngle);
                    result.SetAt(1, 0, -sinAngle);
                    result.SetAt(1, 1, cosAngle);
                    result.SetAt(2, 2, 1);
                    break;
            }
            result.SetAt(3, 3, 1);
            return result;
        }

        public static Matrix4 translate(float tx, float ty, float tz)
        {
            Matrix4 result = new Matrix4();
            result.SetAt(0, 3, tx);
            result.SetAt(1, 3, ty);
            result.SetAt(2, 3, tz);
            result.SetAt(0, 0, 1);
            result.SetAt(1, 1, 1);
            result.SetAt(2, 2, 1);
            result.SetAt(3, 3, 1);
            return result;
        }

        public static Matrix4 scale(float sx, float sy, float sz)
        {
            Matrix4 result = new Matrix4();
            result.SetAt(0, 0, sx);
            result.SetAt(1, 1, sy);
            result.SetAt(2, 2, sz);
            result.SetAt(3, 3, 1);
            return result;
        }

        public static Matrix4 zero()
        {
            return new Matrix4();
        }

        public static Matrix4 identity()
        {
            Matrix4 result = new Matrix4();
            result.SetAt(0, 0, 1);
            result.SetAt(1, 1, 1);
            result.SetAt(2, 2, 1);
            result.SetAt(3, 3, 1);
            return result;
        }
    }

}