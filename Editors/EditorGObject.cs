using LibUnilight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnilightRaytracer;

namespace RAYTRACER_UNILIGHT.Editors
{
    public partial class EditorGObject : EditorBase
    {
        public EditorGObject()
        {
            InitializeComponent();
        }

        public void Clear()
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

            chkEnabled.Checked = obj.Enabled;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
