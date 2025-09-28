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

            int r = (int)(obj.Material.Color.r * 255);
            int g = (int)(obj.Material.Color.g * 255);
            int b = (int)(obj.Material.Color.b * 255);
            panelColor.BackColor = System.Drawing.Color.FromArgb(r, g, b);

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

            // take color from panel and store back into Material.Color
            var c = panelColor.BackColor;
            obj.Material.Color.r = c.R / 255f;
            obj.Material.Color.g = c.G / 255f;
            obj.Material.Color.b = c.B / 255f;

            // save numeric values back into material
            obj.Material.Gloss = (float)numGloss.Value;
            obj.Material.Specular = (float)numSpecular.Value;
            obj.Material.Reflection = (float)numReflection.Value;
        }


        private void panelColor_Click(object sender, EventArgs e)
        {
            // Show dialog with current color pre-selected
            dlgColor.Color = panelColor.BackColor;

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                // Update the panel to the new color
                panelColor.BackColor = dlgColor.Color;
            }
        }
    }
}
