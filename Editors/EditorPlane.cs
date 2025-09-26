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
    public partial class EditorPlane : EditorBase
    {
        public EditorPlane()
        {
            InitializeComponent();
        }

        public override bool ValidateState()
        {
            return true;
        }

        public override void LoadState(object item)
        {
            if (!(item is Plane pl))
                return;

            numX.Value = (decimal)pl.Normal.X;
            numY.Value = (decimal)pl.Normal.Y;
            numZ.Value = (decimal)pl.Normal.Z;

            numDistance.Value = (decimal)pl.Distance;
        }
    }
}
