namespace RAYTRACER_UNILIGHT.Editors
{
    partial class EditorMaterial
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            numGloss = new NumericUpDown();
            numSpecular = new NumericUpDown();
            numReflection = new NumericUpDown();
            dlgColor = new ColorDialog();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGloss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpecular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReflection).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Gloss:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Specular:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 137);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Reflection:";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(label1, 0, 1);
            tableLayoutPanel.Controls.Add(label4, 0, 4);
            tableLayoutPanel.Controls.Add(label2, 0, 2);
            tableLayoutPanel.Controls.Add(label3, 0, 3);
            tableLayoutPanel.Controls.Add(numGloss, 1, 2);
            tableLayoutPanel.Controls.Add(numSpecular, 1, 3);
            tableLayoutPanel.Controls.Add(numReflection, 1, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(214, 185);
            tableLayoutPanel.TabIndex = 4;
            // 
            // numGloss
            // 
            numGloss.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numGloss.DecimalPlaces = 2;
            numGloss.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numGloss.Location = new Point(73, 63);
            numGloss.Name = "numGloss";
            numGloss.Size = new Size(64, 23);
            numGloss.TabIndex = 4;
            // 
            // numSpecular
            // 
            numSpecular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numSpecular.DecimalPlaces = 2;
            numSpecular.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numSpecular.Location = new Point(73, 98);
            numSpecular.Name = "numSpecular";
            numSpecular.Size = new Size(64, 23);
            numSpecular.TabIndex = 5;
            // 
            // numReflection
            // 
            numReflection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numReflection.DecimalPlaces = 2;
            numReflection.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numReflection.Location = new Point(73, 133);
            numReflection.Name = "numReflection";
            numReflection.Size = new Size(64, 23);
            numReflection.TabIndex = 6;
            // 
            // EditorMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "EditorMaterial";
            Size = new Size(214, 185);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGloss).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpecular).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReflection).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel;
        private NumericUpDown numGloss;
        private NumericUpDown numSpecular;
        private NumericUpDown numReflection;
        private ColorDialog dlgColor;
    }
}
