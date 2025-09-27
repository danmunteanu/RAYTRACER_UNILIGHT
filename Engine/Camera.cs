namespace UnilightRaytracer
{
    public class Camera
    {
        

        public Vector Eye { get; set; } = new Vector(0, 0, 1);
        public Vector LookAt { get; set; } = new Vector();

        //  defaults to a 4:3 aspect ratio
        public float ViewportWidth { get; set; } = 4;
        public float ViewportHeight { get; set; } = 3;

        public Camera()
        {
        }
    }

}