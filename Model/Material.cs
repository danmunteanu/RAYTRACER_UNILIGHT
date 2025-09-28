namespace UnilightRaytracer
{

    public class Material //    implements java.io.Serializable
    {
        public Material()
        {
        }

        public RgbColor Color { get; set; } = new(0, 0, 0);

        //  the "Phong" exponent;
        //  small => large hotspot, gradual fallof;
        //  big => small hotspot, sharp falloff
        public float Gloss { get; set; }

        public float Specular { get; set; }

        public float Reflection { get; set; }        
    }

}