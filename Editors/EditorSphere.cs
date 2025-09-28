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
using CommonGraphics;

namespace Unilight.Editors
{
    public partial class EditorSphere : EditorBase
    {
        public EditorSphere()
        {
            InitializeComponent();
        }

        public override bool ValidateState()
        {
            return true;
        }

        public override void LoadState(object item)
        {
            if (!(item is Sphere sp) )
                return;

            numRadius.Value = (decimal)sp.Radius;
        }

        public override void SaveState(object item)
        {
            if (!(item is Sphere sp))
                return;

            sp.Radius = (float) numRadius.Value;
        }
    }
}
