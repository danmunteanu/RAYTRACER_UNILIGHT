namespace Unilight.Editors
{
    public partial class EditorRaytracer : UserControl
    {
        private Raytracer? _raytracer = null;

        public Raytracer? Raytracer {
            get 
            {
                return _raytracer;
            }
            set 
            {
                _raytracer = value;
                OnRaytracerSet();
            }
        }

        public EditorRaytracer()
        {
            InitializeComponent();
        }

        private void OnRaytracerSet()
        {
            if (_raytracer == null)
                return;

            chkGlobalReflection.Checked = _raytracer.GlobalReflectionEnabled;
            chkDiffuse.Checked = _raytracer.ComputeDiffuseEnabled;
            chkSpecular.Checked = _raytracer.ComputeSpecularEnabled;
            chkAmbient.Checked = _raytracer.ComputeAmbientEnabled;
            chkFog.Checked = _raytracer.ComputeFogEnabled;

            numTracerDepth.Value = (decimal) _raytracer.TraceDepth;
        }
    }
}
