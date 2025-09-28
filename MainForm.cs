using Unilight.Editors;
using CommonGraphics;

namespace Unilight
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
            public Vector3D eye;
            public Vector3D lookAt;
            public float width = 0;
            public float height = 0;
        }

        private Bitmap? mBuffer = null;

        //  stores created editors
        private EditorCache mCache = new();

        private Scene mScene = new Scene();
        private Raytracer mRaytracer = new Raytracer();

        public async Task Render()
        {
            await Task.Run(() =>
            {                
                mRaytracer.Render();

                pictureRender.BeginInvoke((System.Windows.Forms.MethodInvoker)(() =>
                {
                    pictureRender.Image = mBuffer;
                    pictureRender.Refresh();
                }));
                btnRender.BeginInvoke((System.Windows.Forms.MethodInvoker)(() => btnRender.Enabled = true));

            });
        }

        public void UpdateRenderProgress(int percent)
        {
            System.Windows.Forms.MethodInvoker? m = new(() => progressRender.Value = percent);
            progressRender.Invoke(m);
        }

        

        private void BuildScene()
        {
            mScene = new Scene();

            Sphere s1 = new Sphere();
            s1.Origin = new Vector3D(-3.5f, 0, 0);
            s1.Material.Color = RgbColor.Blue;
            s1.Material.Gloss = 30;
            s1.Material.Specular = 1.0f;
            s1.Material.Reflection = 1.0f;
            s1.Radius = 2.5f;
            s1.Enabled = true;
            mScene.AddObject(s1);

            Sphere s2 = new Sphere();
            s2.Origin = new Vector3D(3, 0, 0);
            s2.Material.Color = RgbColor.Red;
            s2.Material.Gloss = 10;
            s2.Material.Specular = 0.8f;
            s2.Material.Reflection = 0.0f;
            s2.Radius = 1;
            s2.Name = "Red Sphere";
            s2.Enabled = true;
            mScene.AddObject(s2);

            Sphere s3 = new Sphere();
            s3.Origin = new Vector3D(0, 0, 0);
            s3.Material.Color = RgbColor.Green;
            s3.Material.Gloss = 10;
            s3.Material.Specular = 0;
            s3.Material.Reflection = 0;
            s3.Radius = 0.55f;
            s3.Enabled = true;
            mScene.AddObject(s3);

            Plane pln = new();
            pln.Material.Color = RgbColor.Yellow;
            mScene.AddObject(pln);

            PointLight p = new PointLight();
            p.setPosition(new Vector3D(0, 15, 35));
            p.setColor(RgbColor.White);
            p.setName("Point Light");
            p.setEnabled(true);

            mScene.AddLight(p);
        }

        public MainForm()
        {
            InitializeComponent();

            BuildScene();

            RegisterEditors();

            mBuffer = new(800, 600);

            //  setup camera
            Camera cam = new()
            {
                Eye = new Vector3D(0, 15, 35),
                LookAt = new Vector3D(0, 0, 0),
                ViewportWidth = 12,
                ViewportHeight = 9,
            };

            //  setup raytracer
            mRaytracer.Scene = mScene;
            mRaytracer.Callback = UpdateRenderProgress;
            mRaytracer.Camera = cam;
            mRaytracer.Buffer = mBuffer;
            mRaytracer.GlobalReflectionEnabled = true;
            mRaytracer.ComputeFogEnabled = false;
            mRaytracer.ComputeAmbientEnabled = true;
            mRaytracer.ComputeSpecularEnabled = true;
            mRaytracer.ComputeDiffuseEnabled = true;
            mRaytracer.TraceDepth = 5;

            LoadItemsList();

            editorGObject.ResetState();
            editorGObject.Enabled = false;

            this.CenterToScreen();
        }

        private void RegisterEditors()
        {
            EditorFactory.Register(typeof(Sphere).Name, () => new EditorSphere());
            EditorFactory.Register(typeof(Plane).Name, () => new EditorPlane());
        }

        private void LoadItemsList()
        {
            for (int idx = 0; idx < mScene.ObjectCount; idx++)
            {
                var item = mScene.GetObjectAt(idx);
                if (item != null)
                    lstItems.Items.Add(item.Name);
            }
        }

        private void btnNewScene_Click(object sender, EventArgs e)
        {
            mScene.ClearLights();
            mScene.ClearObjects();
        }

        private void btnCloseScene_Click(object sender, EventArgs e)
        {
            mScene.ClearLights();
            mScene.ClearObjects();
        }

        public SettingsInfo LoadSettings()
        {
            SettingsInfo info = new SettingsInfo();
            info.globalReflection = mRaytracer.GlobalReflectionEnabled;
            info.computeSpecular = mRaytracer.ComputeSpecularEnabled;
            info.computeDiffuse = mRaytracer.ComputeDiffuseEnabled;
            info.computeAmbient = mRaytracer.ComputeAmbientEnabled;
            info.computeFog = mRaytracer.ComputeFogEnabled;
            info.depth = mRaytracer.TraceDepth;

            Camera cam = mRaytracer.Camera;
            info.eye = cam.Eye;
            info.lookAt = cam.LookAt;
            info.width = cam.ViewportWidth;
            info.height = cam.ViewportHeight;
            return info;
        }

        public void UpdateSettings(SettingsInfo info)
        {
            mRaytracer.TraceDepth = info.depth;
            mRaytracer.ComputeAmbientEnabled = info.globalReflection;
            mRaytracer.ComputeAmbientEnabled = info.computeSpecular;
            mRaytracer.ComputeAmbientEnabled = info.computeDiffuse;
            mRaytracer.ComputeAmbientEnabled = info.computeAmbient;
            mRaytracer.ComputeAmbientEnabled = info.computeFog;

            Camera cam = mRaytracer.Camera;
            cam.Eye = info.eye;
            cam.LookAt = info.lookAt;
            cam.ViewportWidth = info.width;
            cam.ViewportHeight = info.height;
        }

        private void buttonRender_Click(object sender, EventArgs e)
        {
            btnRender.Enabled = false;
            OnUpdate();
            Render();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex == -1)
            {
                editorGObject.Enabled = false;
                return;
            }

            var item = mScene.GetObjectAt(lstItems.SelectedIndex);
            if (item == null)
                return;

            //  load common GObject properties
            editorGObject.LoadState(item);
            editorGObject.Enabled = true;

            //  load specific editor
            var editor = mCache.FindOrCreateEditor(item.GetType().Name);
            if (editor != null)
            {
                editor.LoadState(item);
                AddUserControlToPanel(panelEditor, editor);
            }

            btnUpdate.Enabled = true;
        }

        public static bool AddUserControlToPanel(Panel panel, UserControl control)
        {
            if (panel.Controls.Contains(control))
                return false;

            if (control == null)
                return false;

            control.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.BringToFront();

            return true;
        }

        private void OnUpdate()
        {
            if (lstItems.SelectedIndex == -1)
                return;

            var item = mScene.GetObjectAt(lstItems.SelectedIndex);
            if (item == null)
                return;

            editorGObject.SaveState(item);
            var editor = mCache.FindOrCreateEditor(item.GetType().Name);
            if (editor != null)
            {
                editor.SaveState(item);
            }

            lstItems.Items[lstItems.SelectedIndex] = item.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdate();
        }
    }
}
