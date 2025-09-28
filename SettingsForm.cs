namespace Unilight
{
    public partial class SettingsForm : Form
    {
        public Raytracer? Raytracer
        {
            get { return editorRaytracer.Raytracer; }
            set { editorRaytracer.Raytracer = value; }
        }

        public SettingsForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowInTaskbar = false;

            this.CancelButton = btnCancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editorRaytracer.SaveSettings();
            this.Close();
        }
    }
}
