namespace Unilight
{
    public class PointLight
    {
        private Vector3D position = new Vector3D();
        private RgbColor color = new RgbColor(1, 1, 1);    //  same color used for diffuse and specular
        private String name = "Point light";
        private bool enabled = true;

        public PointLight()
        {
        }

        public void setPosition(Vector3D p)
        {
            position = p;
        }

        public Vector3D getPosition()
        {
            return position;
        }

        public void setColor(RgbColor c)
        {
            color = c;
        }

        public RgbColor getColor()
        {
            return color;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public bool isEnabled()
        {
            return enabled;
        }

        public void setEnabled(bool enabled)
        {
            this.enabled = enabled;
        }
    }

}