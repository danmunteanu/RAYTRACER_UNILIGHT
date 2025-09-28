namespace Unilight.Editors
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
            editorMaterial = new EditorMaterial();
            lblName = new Label();
            txtName = new TextBox();
            tableLayoutCoords = new TableLayoutPanel();
            tableLayoutName = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZ).BeginInit();
            panelMaterial.SuspendLayout();
            tableLayoutCoords.SuspendLayout();
            tableLayoutName.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(356, 9);
            chkEnabled.Margin = new Padding(4, 5, 4, 5);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(101, 29);
            chkEnabled.TabIndex = 0;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // numX
            // 
            numX.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numX.DecimalPlaces = 2;
            numX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numX.Location = new Point(107, 46);
            numX.Margin = new Padding(4, 5, 4, 5);
            numX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numX.Name = "numX";
            numX.Size = new Size(78, 31);
            numX.TabIndex = 1;
            // 
            // numY
            // 
            numY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numY.DecimalPlaces = 2;
            numY.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numY.Location = new Point(193, 46);
            numY.Margin = new Padding(4, 5, 4, 5);
            numY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numY.Name = "numY";
            numY.Size = new Size(78, 31);
            numY.TabIndex = 2;
            // 
            // numZ
            // 
            numZ.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numZ.DecimalPlaces = 2;
            numZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numZ.Location = new Point(279, 46);
            numZ.Margin = new Padding(4, 5, 4, 5);
            numZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numZ.Name = "numZ";
            numZ.Size = new Size(78, 31);
            numZ.TabIndex = 3;
            // 
            // lblX
            // 
            lblX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblX.AutoSize = true;
            lblX.Location = new Point(107, 8);
            lblX.Margin = new Padding(4, 0, 4, 0);
            lblX.Name = "lblX";
            lblX.Size = new Size(23, 25);
            lblX.TabIndex = 4;
            lblX.Text = "X";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(193, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(279, 8);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 6;
            label3.Text = "Z";
            // 
            // panelMaterial
            // 
            panelMaterial.Controls.Add(editorMaterial);
            panelMaterial.Dock = DockStyle.Fill;
            panelMaterial.Location = new Point(4, 163);
            panelMaterial.Margin = new Padding(4, 5, 4, 5);
            panelMaterial.Name = "panelMaterial";
            panelMaterial.Size = new Size(465, 297);
            panelMaterial.TabIndex = 7;
            // 
            // editorMaterial
            // 
            editorMaterial.Dock = DockStyle.Fill;
            editorMaterial.Enabled = false;
            editorMaterial.Location = new Point(0, 0);
            editorMaterial.Margin = new Padding(6, 8, 6, 8);
            editorMaterial.Name = "editorMaterial";
            editorMaterial.Size = new Size(465, 297);
            editorMaterial.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 11);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(83, 8);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 31);
            txtName.TabIndex = 9;
            // 
            // tableLayoutCoords
            // 
            tableLayoutCoords.ColumnCount = 5;
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCoords.Controls.Add(numX, 1, 1);
            tableLayoutCoords.Controls.Add(numY, 2, 1);
            tableLayoutCoords.Controls.Add(numZ, 3, 1);
            tableLayoutCoords.Controls.Add(lblX, 1, 0);
            tableLayoutCoords.Controls.Add(label3, 3, 0);
            tableLayoutCoords.Controls.Add(label2, 2, 0);
            tableLayoutCoords.Dock = DockStyle.Fill;
            tableLayoutCoords.Location = new Point(4, 63);
            tableLayoutCoords.Margin = new Padding(4, 5, 4, 5);
            tableLayoutCoords.Name = "tableLayoutCoords";
            tableLayoutCoords.RowCount = 2;
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutCoords.Size = new Size(465, 90);
            tableLayoutCoords.TabIndex = 10;
            // 
            // tableLayoutName
            // 
            tableLayoutName.ColumnCount = 3;
            tableLayoutName.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutName.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutName.Controls.Add(chkEnabled, 2, 0);
            tableLayoutName.Controls.Add(lblName, 0, 0);
            tableLayoutName.Controls.Add(txtName, 1, 0);
            tableLayoutName.Dock = DockStyle.Fill;
            tableLayoutName.Location = new Point(4, 5);
            tableLayoutName.Margin = new Padding(4, 5, 4, 5);
            tableLayoutName.Name = "tableLayoutName";
            tableLayoutName.RowCount = 1;
            tableLayoutName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutName.Size = new Size(465, 48);
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
            tableLayoutMain.Margin = new Padding(4, 5, 4, 5);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(473, 465);
            tableLayoutMain.TabIndex = 13;
            // 
            // EditorGObject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditorGObject";
            Size = new Size(473, 465);
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZ).EndInit();
            panelMaterial.ResumeLayout(false);
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
        private EditorMaterial editorMaterial;
    }
}
