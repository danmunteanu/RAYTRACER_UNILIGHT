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

        private Bitmap? _buffer = null;

        //  stores created editors
        private EditorCache _editorCache = new();

        private Scene _scene = new Scene();
        private Raytracer _raytracer = new Raytracer();

        private SettingsForm _settingsForm;

        public async Task Render()
        {
            await Task.Run(() =>
            {
                _raytracer.Render();

                pictureRender.BeginInvoke((System.Windows.Forms.MethodInvoker)(() =>
                {
                    pictureRender.Image = _buffer;
                    pictureRender.Refresh();
                }));
                btnRender.BeginInvoke((System.Windows.Forms.MethodInvoker)(() => btnRender.Enabled = true));

            });
        }

        public void UpdateRenderProgress(int percent)
        {
            if (progressRender.InvokeRequired)
            {
                progressRender.Invoke(new MethodInvoker(() => progressRender.Value = percent));
            }
            else
            {
                progressRender.Value = percent;
            }
        }

        private void BuildScene()
        {
            _scene = new Scene();

            Sphere s1 = new Sphere();
            s1.Origin = new Vector3D(-3.5f, 0, 0);
            s1.Material.Color = RgbColor.Blue;
            s1.Material.Gloss = 30;
            s1.Material.Specular = 1.0f;
            s1.Material.Reflection = 0.3f;
            s1.Radius = 2.5f;
            s1.Enabled = true;
            _scene.AddObject(s1);

            Sphere s2 = new Sphere();
            s2.Origin = new Vector3D(3, 0, 0);
            s2.Material.Color = RgbColor.Red;
            s2.Material.Gloss = 10;
            s2.Material.Specular = 0.8f;
            s2.Material.Reflection = 0.0f;
            s2.Radius = 1;
            s2.Name = "Red Sphere";
            s2.Enabled = true;
            _scene.AddObject(s2);

            Sphere s3 = new Sphere();
            s3.Origin = new Vector3D(0, 0, 0);
            s3.Material.Color = RgbColor.Green;
            s3.Material.Gloss = 10;
            s3.Material.Specular = 0;
            s3.Material.Reflection = 0;
            s3.Radius = 0.55f;
            s3.Enabled = true;
            _scene.AddObject(s3);

            Plane pln = new();
            pln.Material.Color = RgbColor.Yellow;
            _scene.AddObject(pln);

            PointLight p = new PointLight();
            p.setPosition(new Vector3D(0, 15, 35));
            p.setColor(RgbColor.White);
            p.setName("Point Light");
            p.setEnabled(true);

            _scene.AddLight(p);
        }

        public MainForm()
        {
            InitializeComponent();

            BuildScene();

            RegisterEditors();

            _buffer = new(800, 600);

            //  setup camera
            Camera cam = new()
            {
                Eye = new Vector3D(0, 15, 35),
                LookAt = new Vector3D(0, 0, 0),
                ViewportWidth = 12,
                ViewportHeight = 9,
            };

            //  setup raytracer
            _raytracer.Scene = _scene;
            _raytracer.Callback = UpdateRenderProgress;
            _raytracer.Camera = cam;
            _raytracer.Buffer = _buffer;
            _raytracer.GlobalReflectionEnabled = true;
            _raytracer.ComputeFogEnabled = false;
            _raytracer.ComputeAmbientEnabled = true;
            _raytracer.ComputeSpecularEnabled = true;
            _raytracer.ComputeDiffuseEnabled = true;
            _raytracer.TraceDepth = 5;

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
            for (int idx = 0; idx < _scene.ObjectCount; idx++)
            {
                var item = _scene.GetObjectAt(idx);
                if (item != null)
                    lstItems.Items.Add(item.Name);
            }
        }

        private void btnNewScene_Click(object sender, EventArgs e)
        {
            _scene.ClearLights();
            _scene.ClearObjects();
        }

        private void btnCloseScene_Click(object sender, EventArgs e)
        {
            _scene.ClearLights();
            _scene.ClearObjects();
        }

        public SettingsInfo LoadSettings()
        {
            SettingsInfo info = new SettingsInfo();
            info.globalReflection = _raytracer.GlobalReflectionEnabled;
            info.computeSpecular = _raytracer.ComputeSpecularEnabled;
            info.computeDiffuse = _raytracer.ComputeDiffuseEnabled;
            info.computeAmbient = _raytracer.ComputeAmbientEnabled;
            info.computeFog = _raytracer.ComputeFogEnabled;
            info.depth = _raytracer.TraceDepth;

            Camera cam = _raytracer.Camera;
            info.eye = cam.Eye;
            info.lookAt = cam.LookAt;
            info.width = cam.ViewportWidth;
            info.height = cam.ViewportHeight;
            return info;
        }

        public void UpdateSettings(SettingsInfo info)
        {
            _raytracer.TraceDepth = info.depth;
            _raytracer.ComputeAmbientEnabled = info.globalReflection;
            _raytracer.ComputeAmbientEnabled = info.computeSpecular;
            _raytracer.ComputeAmbientEnabled = info.computeDiffuse;
            _raytracer.ComputeAmbientEnabled = info.computeAmbient;
            _raytracer.ComputeAmbientEnabled = info.computeFog;

            Camera cam = _raytracer.Camera;
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

            var item = _scene.GetObjectAt(lstItems.SelectedIndex);
            if (item == null)
                return;

            //  load common GObject properties
            editorGObject.LoadState(item);
            editorGObject.Enabled = true;

            //  load specific editor
            var editor = _editorCache.FindOrCreateEditor(item.GetType().Name);
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

            var item = _scene.GetObjectAt(lstItems.SelectedIndex);
            if (item == null)
                return;

            editorGObject.SaveState(item);
            var editor = _editorCache.FindOrCreateEditor(item.GetType().Name);
            if (editor != null)
            {
                editor.SaveState(item);
            }

            lstItems.Items[lstItems.SelectedIndex] = item.Name;
        }

        private void OnShowSettings()
        {
            if (_settingsForm == null)
                _settingsForm = new()
                {
                    Raytracer = _raytracer
                };

            _settingsForm.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdate();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OnShowSettings();
        }

        private void pictureRender_MouseClick(object sender, MouseEventArgs e)
        {
            if (_raytracer == null || pictureRender.Image == null)
                return;

            // Translate mouse position to image coordinates
            Point imgPoint = Utils.TranslatePointToImage(pictureRender, e.Location);

            // If outside the actual drawn image area, ignore
            if (imgPoint == Point.Empty)
            {
                MessageBox.Show("Clicked outside the rendered image.");
                return;
            }

            // Use translated coordinates for ray picking
            var obj = _raytracer.PickObjectAt(imgPoint.X, imgPoint.Y, out var hitPoint);

            if (obj != null)
            {
                int idx = _scene.IndexOfObject(obj);
                if (idx != -1)
                    lstItems.SelectedIndex = idx;
            }
            else
            {
                MessageBox.Show("No object hit.");
            }
        }

    }
}
