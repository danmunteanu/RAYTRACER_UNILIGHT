using LibUnilight;
using System.ComponentModel.Design.Serialization;
using System.Runtime.Intrinsics.X86;

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

        public async Task Render()
        {
            await Task.Run(() =>
            {
                mRaytracer.render();
            });
        }

        private Scene mScene = new Scene();
        private Raytracer mRaytracer = new Raytracer();

        public void UpdateProgress(int percent)
        {
            //  progressRender.Value = percent;
        }

        public MainForm()
        {
            InitializeComponent();

            Scene scene = new Scene();
            //  Storage storage = new SerializationStorage();
            Controller control = new Controller();
            ObservableImage image = new ObservableImage(800, 600, 0/*java.awt.image.BufferedImage.TYPE_INT_RGB*/);
            
            mRaytracer.setImage( image );
            
            //  setup camera
            Camera cam = new Camera();
            cam.setEye(new Vector(0, 15, 35));
            cam.setLookAt(new Vector(0, 0, 0));
            cam.setViewportWidth(12);
            cam.setViewportHeight(9);

            //  setup main frame
            /*          javax.swing.JFrame.setDefaultLookAndFeelDecorated(true);
            //            RenderFrame mainFrame = null;
                      mainFrame = new RenderFrame(image);
                      utils.Common.centerFrame(mainFrame);
                      mainFrame.setController(control);
                      mainFrame.setVisible(true);*/

            //  setup raytracer
            mRaytracer.setScene(scene);
            mRaytracer.setCamera(cam);
            mRaytracer.setImage(image);
            mRaytracer.setMaxTraceDepth(5);
            mRaytracer.Callback = UpdateProgress;
            //rt.setCallback(mainFrame.createOrGetProgressCallback());

            //  setup raytracer thread
            /*rtThread.setPriority(5);
            rtThread.start();  // start rt thread*/

            //  add mainFrame as an observer for the image
            /*image.getSubject().addObserver(mainFrame);*/
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

        /*    
        public void handleAmbientChanged(java.awt.Color col)
        {
            scene.setAmbientColor(new model.Color(col.getRed() / 255, col.getGreen() / 255, col.getBlue() / 255));
        }

        public void handleOpenScene(String dataFile) throws Exception
            {
                SerializationStorage sto = SerializationStorage.getInstance();
                sto.setDataFile(dataFile);
                scene = sto.load ();
                rt.setScene(scene);
            }*/

        /*    public void handleFogColorChanged(java.awt.Color col)
            {
                rt.setFogCol(new model.Color (col.getRed() / 255, col.getGreen() / 255, col.getBlue() / 255));
            }*/

        /*public void handleSaveScene( String dataFile) throws Exception
        {
            SerializationStorage sto = SerializationStorage.getInstance( );
            sto.setDataFile( dataFile );
            sto.save( scene );
        }*/

        public SettingsInfo LoadSettings()
        {
            SettingsInfo info = new SettingsInfo();
            info.globalReflection = mRaytracer.GlobalReflection;
            info.computeSpecular = mRaytracer.ComputeSpecular;
            info.computeDiffuse = mRaytracer.ComputeDiffuse;
            info.computeAmbient = mRaytracer.ComputeAmbient;
            info.computeFog = mRaytracer.ComputeFog;
            info.depth = mRaytracer.getMaxTraceDepth();

            Camera cam = mRaytracer.getCamera();
            info.eye = cam.getEye();
            info.lookAt = cam.getLookAt();
            info.width = cam.getViewportWidth();
            info.height = cam.getViewportHeight();
            return info;
        }

        public void UpdateSettings(SettingsInfo info)
        {
            //if (!mRenderThread.MustRender)
            //{
            //    mRaytracer.setMaxTraceDepth(info.depth);
            //    mRaytracer.ComputeAmbient = info.globalReflection;
            //    mRaytracer.ComputeAmbient = info.computeSpecular;
            //    mRaytracer.ComputeAmbient = info.computeDiffuse;
            //    mRaytracer.ComputeAmbient = info.computeAmbient;
            //    mRaytracer.ComputeAmbient = info.computeFog;

            //    Camera cam = mRaytracer.getCamera();
            //    cam.setEye(info.eye);
            //    cam.setLookAt(info.lookAt);
            //    cam.setViewportWidth(info.width);
            //    cam.setViewportHeight(info.height);
            //}
        }

        public void handleRender()
        {
            //if (!mRenderThread.MustRender)
            //{
            //    mRenderThread.MustRender = true;
            //}
        }

        public void handleStopRender()
        {
            if (!mRaytracer.isStopRender())
            {
                mRaytracer.setStopRender(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Render();
        }
    }
}
