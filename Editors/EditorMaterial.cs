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
            panelColor.BackColor = System.Drawing.Color.White;
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

            int r = (int)(obj.Material.Color.R * 255);
            int g = (int)(obj.Material.Color.G * 255);
            int b = (int)(obj.Material.Color.B * 255);
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
            obj.Material.Color.R = c.R / 255f;
            obj.Material.Color.R = c.G / 255f;
            obj.Material.Color.R = c.B / 255f;

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
