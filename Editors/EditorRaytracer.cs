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

            numTracerDepth.Value = (decimal)_raytracer.TraceDepth;

            chkGlobalReflection.Checked = _raytracer.GlobalReflectionEnabled;
            chkDiffuse.Checked = _raytracer.ComputeDiffuseEnabled;
            chkSpecular.Checked = _raytracer.ComputeSpecularEnabled;
            chkAmbient.Checked = _raytracer.ComputeAmbientEnabled;
            chkFog.Checked = _raytracer.ComputeFogEnabled;

            switch (_raytracer.TraversalOrder)
            {
                case CommonGraphics.TraversalOrder.LeftToRight:
                    cmbTraversalOrder.SelectedIndex = 0;
                    break;

                case CommonGraphics.TraversalOrder.TopToBottom:
                    cmbTraversalOrder.SelectedIndex = 1;
                    break;

                default:
                    cmbTraversalOrder.SelectedIndex = 0;    //  left to right
                    break;
            }

            numLookX.Value = (decimal) _raytracer.Camera.LookAt.X;
            numLookY.Value = (decimal) _raytracer.Camera.LookAt.Y;
            numLookZ.Value = (decimal) _raytracer.Camera.LookAt.Z;

            numEyeX.Value = (decimal)_raytracer.Camera.Eye.X;
            numEyeY.Value = (decimal)_raytracer.Camera.Eye.Y;
            numEyeZ.Value = (decimal)_raytracer.Camera.Eye.Z;

            numViewportWidth.Value = (decimal)_raytracer.Camera.ViewportWidth;
            numViewportHeight.Value = (decimal)_raytracer.Camera.ViewportHeight;

        }

        public void SaveSettings()
        {
            if (_raytracer == null)
                return;

            // Flags and trace depth
            _raytracer.GlobalReflectionEnabled = chkGlobalReflection.Checked;
            _raytracer.ComputeDiffuseEnabled = chkDiffuse.Checked;
            _raytracer.ComputeSpecularEnabled = chkSpecular.Checked;
            _raytracer.ComputeAmbientEnabled = chkAmbient.Checked;
            _raytracer.ComputeFogEnabled = chkFog.Checked;

            _raytracer.TraceDepth = (int)numTracerDepth.Value;

            // Traversal order (match the indices used in OnRaytracerSet)
            switch (cmbTraversalOrder.SelectedIndex)
            {
                case 1:
                    _raytracer.TraversalOrder = CommonGraphics.TraversalOrder.TopToBottom;
                    break;

                default:
                    _raytracer.TraversalOrder = CommonGraphics.TraversalOrder.LeftToRight;
                    break;
            }

            // Camera LookAt and Eye (use new Vector3D so we don't rely on mutable sub-properties)
            float lookX = (float)numLookX.Value;
            float lookY = (float)numLookY.Value;
            float lookZ = (float)numLookZ.Value;
            float eyeX = (float)numEyeX.Value;
            float eyeY = (float)numEyeY.Value;
            float eyeZ = (float)numEyeZ.Value;

            _raytracer.Camera.LookAt = new Vector3D(lookX, lookY, lookZ);
            _raytracer.Camera.Eye = new Vector3D(eyeX, eyeY, eyeZ);

            // Viewport (ensure positive non-zero values)
            float vpW = (float)numViewportWidth.Value;
            float vpH = (float)numViewportHeight.Value;
            if (vpW <= 0f) vpW = 1f;
            if (vpH <= 0f) vpH = 1f;

            _raytracer.Camera.ViewportWidth = vpW;
            _raytracer.Camera.ViewportHeight = vpH;
        }


    }
}
