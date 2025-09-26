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
    public partial class EditorMaterial : EditorBase
    {
        public EditorMaterial()
        {
            InitializeComponent();
        }

        public override void ResetState()
        {
            //  TBD: Color
            numGloss.Value = 0;
            numSpecular.Value = 0;
            numReflection.Value = 0;
        }

        public override bool ValidateState()
        {
            return true;   
        }

        public override void LoadState(object item)
        {
            if (!(item is GObject obj))
                return;

            if (obj.Material == null)
                return;

            numGloss.Value = (decimal)obj.Material.Gloss;
            numSpecular.Value = (decimal)obj.Material.Specular;
            numReflection.Value = (decimal)obj.Material.Reflection;
        }

        public override void SaveState(object item)
        {
            if (!(item is GObject obj))
                return;

            if (obj.Material == null)
                return;

            obj.Material.Gloss = (float)numGloss.Value;
            obj.Material.Specular = (float)numSpecular.Value;
            obj.Material.Reflection = (float)numReflection.Value;
        }
    }
}
