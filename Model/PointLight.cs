namespace UnilightRaytracer
{
    public class PointLight
    {
        private Vector position = new Vector();
        private Color color = new Color(1, 1, 1);    //  same color used for diffuse and specular
        private String name = "Point light";
        private bool enabled = true;

        public PointLight()
        {
        }

        public void setPosition(Vector p)
        {
            position = p;
        }

        public Vector getPosition()
        {
            return position;
        }

        public void setColor(Color c)
        {
            color = c;
        }

        public Color getColor()
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