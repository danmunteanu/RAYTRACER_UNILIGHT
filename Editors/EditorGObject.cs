using UnilightRaytracer;
using CommonGraphics;

namespace Unilight.Editors
{
    public partial class EditorGObject : EditorBase
    {
        public EditorGObject()
        {
            InitializeComponent();

            this.EnabledChanged += (s, e) =>
            {
                editorMaterial.Enabled = this.Enabled;
            };
        }

        public override void ResetState()
        {
            numX.Value = 0;
            numY.Value = 0;
            numZ.Value = 0;
        }

        public override bool ValidateState()
        {
            return true;
        }

        public override void LoadState(object item)
        {
            if (!(item is GObject obj))
                return;

            txtName.Text = obj.Name;

            numX.Value = (decimal)obj.Origin.X;
            numY.Value = (decimal)obj.Origin.Y;
            numZ.Value = (decimal)obj.Origin.Z;

            editorMaterial.LoadState(item);
            editorMaterial.Enabled = true;

            chkEnabled.Checked = obj.Enabled;
        }

        public override void SaveState(object item)
        {
            if (!(item is GObject obj))
                return;

            obj.Name = txtName.Text;

            Vector temp = obj.Origin;
            temp.X = (float)numX.Value;
            temp.Y = (float)numY.Value;
            temp.Z = (float)numZ.Value;
            obj.Origin = temp;

            editorMaterial.SaveState(item);

            obj.Enabled = chkEnabled.Checked;
        }
    }
}
