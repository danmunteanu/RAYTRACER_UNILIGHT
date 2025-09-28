/*
 * RgbColor.cs
 * 
 * Represents an RGB color with float components in the range [0, 1].
 * 
 * Features:
 *   - Predefined static colors: Black, Red, Green, Blue, White, Yellow, Cyan, Magenta
 *   - Safe mutable properties (R, G, B) with automatic clamping
 *   - Arithmetic operators: +, -, * (with both scalars and other colors)
 *   - Linear interpolation (Lerp) with clamped interpolation factor
 *   - ToString() override for debugging output
 * 
 * Usage:
 *   var c1 = new RgbColor(0.5f, 0.2f, 0.7f);   // create a custom color
 *   c1.R = 2.0f;                               // clamped to 1.0
 *   var mix = RgbColor.Lerp(RgbColor.Red, RgbColor.Blue, 0.5f); // purple
 *
 * Author: Dan Munteanu
 * Date: 28-Sep-2025
 */

namespace Unilight
{
    public class RgbColor
    {
        private float r, g, b;

        public float R
        {
            get => r;
            set => r = Clamp(value);
        }

        public float G
        {
            get => g;
            set => g = Clamp(value);
        }

        public float B
        {
            get => b;
            set => b = Clamp(value);
        }

        // Predefined colors
        public static readonly RgbColor Black = new(0, 0, 0);
        public static readonly RgbColor Red = new(1, 0, 0);
        public static readonly RgbColor Green = new(0, 1, 0);
        public static readonly RgbColor Blue = new(0, 0, 1);
        public static readonly RgbColor White = new(1, 1, 1);
        public static readonly RgbColor Yellow = new(1, 1, 0);
        public static readonly RgbColor Cyan = new(0, 1, 1);
        public static readonly RgbColor Magenta = new(1, 0, 1);

        public RgbColor(float r, float g, float b)
        {
            R = r;
            G = g;
            B = b;
        }

        private static float Clamp(float value, float min = 0f, float max = 1f) =>
            value < min ? min : (value > max ? max : value);

        // Operators
        public static RgbColor operator +(RgbColor a, RgbColor b) =>
            new(Clamp(a.R + b.R), Clamp(a.G + b.G), Clamp(a.B + b.B));

        public static RgbColor operator -(RgbColor a, RgbColor b) =>
            new(Clamp(a.R - b.R), Clamp(a.G - b.G), Clamp(a.B - b.B));

        public static RgbColor operator *(RgbColor a, RgbColor b) =>
            new(Clamp(a.R * b.R), Clamp(a.G * b.G), Clamp(a.B * b.B));

        public static RgbColor operator *(RgbColor a, float k) =>
            new(Clamp(a.R * k), Clamp(a.G * k), Clamp(a.B * k));

        // Linear interpolation with clamped t
        public static RgbColor Lerp(RgbColor a, RgbColor b, float t)
        {
            if (t < 0f) t = 0f;
            if (t > 1f) t = 1f;

            return new RgbColor(
                a.R + (b.R - a.R) * t,
                a.G + (b.G - a.G) * t,
                a.B + (b.B - a.B) * t
            );
        }

        public override string ToString() => $"RgbColor({R:0.##}, {G:0.##}, {B:0.##})";
    }
}
