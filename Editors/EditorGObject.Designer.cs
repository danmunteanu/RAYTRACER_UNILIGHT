namespace RAYTRACER_UNILIGHT.Editors
{
    partial class EditorGObject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkEnabled = new CheckBox();
            numX = new NumericUpDown();
            numY = new NumericUpDown();
            numZ = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            colorDialog = new ColorDialog();
            panelMaterial = new Panel();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZ).BeginInit();
            SuspendLayout();
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(46, 229);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(68, 19);
            chkEnabled.TabIndex = 0;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            chkEnabled.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numX
            // 
            numX.Location = new Point(38, 34);
            numX.Name = "numX";
            numX.Size = new Size(56, 23);
            numX.TabIndex = 1;
            // 
            // numY
            // 
            numY.Location = new Point(100, 34);
            numY.Name = "numY";
            numY.Size = new Size(67, 23);
            numY.TabIndex = 2;
            // 
            // numZ
            // 
            numZ.Location = new Point(173, 34);
            numZ.Name = "numZ";
            numZ.Size = new Size(57, 23);
            numZ.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 13);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 13);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 13);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 6;
            label3.Text = "Z";
            // 
            // panelMaterial
            // 
            panelMaterial.Location = new Point(42, 87);
            panelMaterial.Name = "panelMaterial";
            panelMaterial.Size = new Size(205, 122);
            panelMaterial.TabIndex = 7;
            // 
            // EditorGObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMaterial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numZ);
            Controls.Add(numY);
            Controls.Add(numX);
            Controls.Add(chkEnabled);
            Name = "EditorGObject";
            Size = new Size(379, 291);
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkEnabled;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private NumericUpDown numZ;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColorDialog colorDialog;
        private Panel panelMaterial;
    }
}
