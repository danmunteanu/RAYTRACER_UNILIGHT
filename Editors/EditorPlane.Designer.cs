namespace RaytracerUnilight.Editors
{
    partial class EditorPlane
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
            tableLayoutCoords = new TableLayoutPanel();
            numDistance = new NumericUpDown();
            numX = new NumericUpDown();
            numY = new NumericUpDown();
            numZ = new NumericUpDown();
            lblX = new Label();
            label3 = new Label();
            label2 = new Label();
            lblDistance = new Label();
            tableLayoutCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZ).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutCoords
            // 
            tableLayoutCoords.ColumnCount = 5;
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCoords.Controls.Add(numDistance, 1, 3);
            tableLayoutCoords.Controls.Add(numX, 1, 1);
            tableLayoutCoords.Controls.Add(numY, 2, 1);
            tableLayoutCoords.Controls.Add(numZ, 3, 1);
            tableLayoutCoords.Controls.Add(lblX, 1, 0);
            tableLayoutCoords.Controls.Add(label3, 3, 0);
            tableLayoutCoords.Controls.Add(label2, 2, 0);
            tableLayoutCoords.Controls.Add(lblDistance, 1, 2);
            tableLayoutCoords.Dock = DockStyle.Fill;
            tableLayoutCoords.Location = new Point(0, 0);
            tableLayoutCoords.Name = "tableLayoutCoords";
            tableLayoutCoords.RowCount = 5;
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutCoords.Size = new Size(371, 134);
            tableLayoutCoords.TabIndex = 11;
            // 
            // numDistance
            // 
            numDistance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numDistance.DecimalPlaces = 2;
            numDistance.Location = new Point(58, 78);
            numDistance.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(54, 23);
            numDistance.TabIndex = 12;
            // 
            // numX
            // 
            numX.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numX.DecimalPlaces = 2;
            numX.Location = new Point(58, 28);
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
            numY.Location = new Point(118, 28);
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
            numZ.Location = new Point(178, 28);
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
            // lblDistance
            // 
            lblDistance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(58, 60);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(52, 15);
            lblDistance.TabIndex = 13;
            lblDistance.Text = "Distance";
            // 
            // EditorPlane
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutCoords);
            Name = "EditorPlane";
            Size = new Size(371, 134);
            tableLayoutCoords.ResumeLayout(false);
            tableLayoutCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutCoords;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private NumericUpDown numZ;
        private Label lblX;
        private Label label3;
        private Label label2;
        private NumericUpDown numDistance;
        private Label lblDistance;
    }
}
