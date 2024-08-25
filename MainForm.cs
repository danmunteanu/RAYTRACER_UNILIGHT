using LibUnilight;
using System.ComponentModel.Design.Serialization;
using System.Runtime.Intrinsics.X86;

namespace UnilightRaytracer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Scene scene = new Scene();
            //  Storage storage = new SerializationStorage();
            Controller control = new Controller();
            ObservableImage image = new ObservableImage(800, 600, 0/*java.awt.image.BufferedImage.TYPE_INT_RGB*/);
//            RenderFrame mainFrame = null;
            Raytracer rt = new Raytracer();
            RaytracerThread rtThread = new RaytracerThread(rt);

            //  setup camera
            Camera cam = new Camera();
            cam.setEye(new Vector(0, 15, 35));
            cam.setLookAt(new Vector(0, 0, 0));
            cam.setViewportWidth(12);
            cam.setViewportHeight(9);

            //  setup main frame
  /*          javax.swing.JFrame.setDefaultLookAndFeelDecorated(true);
            mainFrame = new RenderFrame(image);
            utils.Common.centerFrame(mainFrame);
            mainFrame.setController(control);
            mainFrame.setVisible(true);*/

            //  setup raytracer
            rt.setScene(scene);
            rt.setCamera(cam);
            rt.setImage(image);
            rt.setMaxTraceDepth(5);
            //rt.setCallback(mainFrame.createOrGetProgressCallback());

            //  setup raytracer thread
            /*rtThread.setPriority(5);
            rtThread.start();  // start rt thread*/

            //  setup controller
            control.setRaytracer(rt);
            control.setRaytracerThread(rtThread);
            control.setScene(scene);

            //  add mainFrame as an observer for the image
            /*image.getSubject().addObserver(mainFrame);*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
