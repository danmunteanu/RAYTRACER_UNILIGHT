namespace Unilight
{
    public class Camera
    {
        

        public Vector3D Eye { get; set; } = new Vector3D(0, 0, 1);
        public Vector3D LookAt { get; set; } = new Vector3D();

        //  defaults to a 4:3 aspect ratio
        public float ViewportWidth { get; set; } = 4;
        public float ViewportHeight { get; set; } = 3;

        public Camera()
        {
        }
    }

}