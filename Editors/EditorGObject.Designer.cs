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
            lblX = new Label();
            label2 = new Label();
            label3 = new Label();
            colorDialog = new ColorDialog();
            panelMaterial = new Panel();
            lblName = new Label();
            txtName = new TextBox();
            tableLayoutCoords = new TableLayoutPanel();
            tableLayoutName = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZ).BeginInit();
            tableLayoutCoords.SuspendLayout();
            tableLayoutName.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(262, 10);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(68, 19);
            chkEnabled.TabIndex = 0;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            chkEnabled.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numX
            // 
            numX.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numX.DecimalPlaces = 2;
            numX.Location = new Point(58, 32);
            numX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numX.Name = "numX";
            numX.Size = new Size(54, 23);
            numX.TabIndex = 1;
            // 
            // numY
            // 
            numY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numY.DecimalPlaces = 2;
            numY.Location = new Point(118, 32);
            numY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numY.Name = "numY";
            numY.Size = new Size(54, 23);
            numY.TabIndex = 2;
            // 
            // numZ
            // 
            numZ.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numZ.DecimalPlaces = 2;
            numZ.Location = new Point(178, 32);
            numZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numZ.Name = "numZ";
            numZ.Size = new Size(54, 23);
            numZ.TabIndex = 3;
            // 
            // lblX
            // 
            lblX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblX.AutoSize = true;
            lblX.Location = new Point(58, 10);
            lblX.Name = "lblX";
            lblX.Size = new Size(14, 15);
            lblX.TabIndex = 4;
            lblX.Text = "X";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(118, 10);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(178, 10);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 6;
            label3.Text = "Z";
            // 
            // panelMaterial
            // 
            panelMaterial.Dock = DockStyle.Fill;
            panelMaterial.Location = new Point(3, 116);
            panelMaterial.Name = "panelMaterial";
            panelMaterial.Size = new Size(338, 160);
            panelMaterial.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(58, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 23);
            txtName.TabIndex = 9;
            // 
            // tableLayoutCoords
            // 
            tableLayoutCoords.ColumnCount = 5;
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCoords.Controls.Add(numX, 1, 1);
            tableLayoutCoords.Controls.Add(numY, 2, 1);
            tableLayoutCoords.Controls.Add(numZ, 3, 1);
            tableLayoutCoords.Controls.Add(lblX, 1, 0);
            tableLayoutCoords.Controls.Add(label3, 3, 0);
            tableLayoutCoords.Controls.Add(label2, 2, 0);
            tableLayoutCoords.Dock = DockStyle.Fill;
            tableLayoutCoords.Location = new Point(3, 48);
            tableLayoutCoords.Name = "tableLayoutCoords";
            tableLayoutCoords.RowCount = 2;
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutCoords.Size = new Size(338, 62);
            tableLayoutCoords.TabIndex = 10;
            // 
            // tableLayoutName
            // 
            tableLayoutName.ColumnCount = 3;
            tableLayoutName.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutName.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutName.Controls.Add(chkEnabled, 2, 0);
            tableLayoutName.Controls.Add(lblName, 0, 0);
            tableLayoutName.Controls.Add(txtName, 1, 0);
            tableLayoutName.Dock = DockStyle.Fill;
            tableLayoutName.Location = new Point(3, 3);
            tableLayoutName.Name = "tableLayoutName";
            tableLayoutName.RowCount = 1;
            tableLayoutName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutName.Size = new Size(338, 39);
            tableLayoutName.TabIndex = 11;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutCoords, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutName, 0, 0);
            tableLayoutMain.Controls.Add(panelMaterial, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(344, 279);
            tableLayoutMain.TabIndex = 13;
            // 
            // EditorGObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "EditorGObject";
            Size = new Size(344, 279);
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZ).EndInit();
            tableLayoutCoords.ResumeLayout(false);
            tableLayoutCoords.PerformLayout();
            tableLayoutName.ResumeLayout(false);
            tableLayoutName.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkEnabled;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private NumericUpDown numZ;
        private Label lblX;
        private Label label2;
        private Label label3;
        private ColorDialog colorDialog;
        private Panel panelMaterial;
        private Label lblName;
        private TextBox txtName;
        private TableLayoutPanel tableLayoutCoords;
        private TableLayoutPanel tableLayoutName;
        private TableLayoutPanel tableLayoutMain;
    }
}
