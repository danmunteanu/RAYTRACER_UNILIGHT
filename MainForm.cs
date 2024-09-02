using LibUnilight;
using System.Reflection;

namespace UnilightRaytracer
{
    public partial class MainForm : Form
    {
        public class SettingsInfo
        {
            public bool globalReflection = false;
            public bool computeSpecular = true;
            public bool computeDiffuse = true;
            public bool computeAmbient = true;
            public bool computeFog = true;
            public int depth = 1;
            public Vector eye = null;
            public Vector lookAt = null;
            public float width = 0;
            public float height = 0;
        }

        private Scene mScene = new Scene();
        private Raytracer mRaytracer = new Raytracer();

        public async Task Render()
        {
            await Task.Run(() =>
            {
                mImage.Clear(Color.black);
                mRaytracer.Render();                
                pictureRender.Image = mImage.GetBitmap();
                
            });
        }

        public void UpdateRenderProgress(int percent)
        {
            //  progressRender.Value = percent;

            System.Windows.Forms.MethodInvoker m = null; 
            m = new System.Windows.Forms.MethodInvoker(
                () => progressRender.Value = percent
            );
            progressRender.Invoke(m);
        }

        private ObservableImage mImage = new ObservableImage(800, 600);

        private void BuildScene()
        {
            mScene = new Scene();

            Sphere s1 = new Sphere();
            s1.Origin = new Vector(-3.5f, 0, 0);
            s1.Material.Color = Color.blue;
            s1.Material.Gloss = 15;
            s1.Material.Specular = 0.9f;
            s1.Material.Reflection = 0.2f;
            s1.Radius = 2.5f;
            s1.Enabled = true;
            mScene.addObject(s1);

            Sphere s2 = new Sphere();
            s2.Origin = new Vector(3, 0, 0);
            s2.Material.Color = Color.red;
            s2.Material.Gloss = 7;
            s2.Material.Specular = 0.8f;
            s2.Material.Reflection = 0.3f;
            s2.Radius = 1;
            s2.Enabled = true;
            mScene.addObject(s2);

            Sphere s3 = new Sphere();
            s3.Origin = new Vector(0, 0, 0);
            s3.Material.Color = Color.green;
            s3.Material.Gloss = 1;
            s3.Material.Specular = 0;
            s3.Material.Reflection = 0;
            s3.Radius = 0.55f;
            s3.Enabled = true;
            mScene.addObject(s3);

            PointLight p = new PointLight();
            p.setPosition(new Vector(0, 15, 35));
            p.setColor(Color.white);
            p.setName("Point Light");
            p.setEnabled(true);

            mScene.addLight(p);
        }

        public MainForm()
        {
            InitializeComponent();

            BuildScene();

            //  Trigger Double Buffering
            /*typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            panelRender, new object[] { true });*/
            //  Storage storage = new SerializationStorage();
            
            //  setup camera
            Camera cam = new Camera();
            cam.Eye = new Vector(0, 15, 35);
            cam.LookAt = new Vector(0, 0, 0);
            cam.ViewportWidth = 12;
            cam.ViewportHeight = 9;

            //  setup raytracer
            mRaytracer.Scene = mScene;
            mRaytracer.Callback = UpdateRenderProgress;
            mRaytracer.setCamera(cam);
            mRaytracer.setImage(mImage);            
            mRaytracer.ComputeAmbient = true;
            mRaytracer.ComputeSpecular = true;
            mRaytracer.ComputeDiffuse = true;
            mRaytracer.setMaxTraceDepth(5);

            //  add mainFrame as an observer for the image
            /*image.getSubject().addObserver(mainFrame);*/
            
            this.CenterToScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewScene_Click(object sender, EventArgs e)
        {
            mScene.clearLights();
            mScene.clearObjects();
            mScene.setAmbientColor(Color.black);
        }

        private void btnCloseScene_Click(object sender, EventArgs e)
        {
            mScene.clearLights();
            mScene.clearObjects();
            mScene.setAmbientColor(Color.black);
            mScene.setAmbientColor(Color.black);
        }

        public SettingsInfo LoadSettings()
        {
            SettingsInfo info = new SettingsInfo();
            info.globalReflection = mRaytracer.ApplyGlobalReflection;
            info.computeSpecular = mRaytracer.ComputeSpecular;
            info.computeDiffuse = mRaytracer.ComputeDiffuse;
            info.computeAmbient = mRaytracer.ComputeAmbient;
            info.computeFog = mRaytracer.ComputeFog;
            info.depth = mRaytracer.getMaxTraceDepth();

            Camera cam = mRaytracer.getCamera();
            info.eye = cam.Eye;
            info.lookAt = cam.LookAt;
            info.width = cam.ViewportWidth;
            info.height = cam.ViewportHeight;
            return info;
        }

        public void UpdateSettings(SettingsInfo info)
        {            
            mRaytracer.setMaxTraceDepth(info.depth);
            mRaytracer.ComputeAmbient = info.globalReflection;
            mRaytracer.ComputeAmbient = info.computeSpecular;
            mRaytracer.ComputeAmbient = info.computeDiffuse;
            mRaytracer.ComputeAmbient = info.computeAmbient;
            mRaytracer.ComputeAmbient = info.computeFog;

            Camera cam = mRaytracer.getCamera();
            cam.Eye = info.eye;
            cam.LookAt = info.lookAt;
            cam.ViewportWidth = info.width;
            cam.ViewportHeight = info.height;
        }

        public void handleStopRender()
        {
            if (!mRaytracer.isStopRender())
            {
                mRaytracer.setStopRender(true);
            }
        }

        private void buttonRender_Click(object sender, EventArgs e)
        {
            Render();
        }
    }
}
