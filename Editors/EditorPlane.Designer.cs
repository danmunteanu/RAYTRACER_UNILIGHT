namespace Unilight.Editors
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
            numX = new NumericUpDown();
            numY = new NumericUpDown();
            numZ = new NumericUpDown();
            lblX = new Label();
            label3 = new Label();
            label2 = new Label();
            numDistance = new NumericUpDown();
            lblDistance = new Label();
            groupBoxPlane = new GroupBox();
            tableLayoutCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            groupBoxPlane.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutCoords
            // 
            tableLayoutCoords.ColumnCount = 6;
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCoords.Controls.Add(numX, 1, 1);
            tableLayoutCoords.Controls.Add(numY, 2, 1);
            tableLayoutCoords.Controls.Add(numZ, 3, 1);
            tableLayoutCoords.Controls.Add(lblX, 1, 0);
            tableLayoutCoords.Controls.Add(label3, 3, 0);
            tableLayoutCoords.Controls.Add(label2, 2, 0);
            tableLayoutCoords.Controls.Add(numDistance, 4, 1);
            tableLayoutCoords.Controls.Add(lblDistance, 4, 0);
            tableLayoutCoords.Dock = DockStyle.Fill;
            tableLayoutCoords.Location = new Point(2, 22);
            tableLayoutCoords.Margin = new Padding(3, 4, 3, 4);
            tableLayoutCoords.Name = "tableLayoutCoords";
            tableLayoutCoords.RowCount = 3;
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutCoords.Size = new Size(370, 106);
            tableLayoutCoords.TabIndex = 11;
            // 
            // numX
            // 
            numX.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numX.DecimalPlaces = 2;
            numX.Location = new Point(44, 32);
            numX.Margin = new Padding(3, 4, 3, 4);
            numX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numX.Name = "numX";
            numX.Size = new Size(66, 27);
            numX.TabIndex = 1;
            // 
            // numY
            // 
            numY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numY.DecimalPlaces = 2;
            numY.Location = new Point(116, 32);
            numY.Margin = new Padding(3, 4, 3, 4);
            numY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numY.Name = "numY";
            numY.Size = new Size(66, 27);
            numY.TabIndex = 2;
            // 
            // numZ
            // 
            numZ.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numZ.DecimalPlaces = 2;
            numZ.Location = new Point(188, 32);
            numZ.Margin = new Padding(3, 4, 3, 4);
            numZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numZ.Name = "numZ";
            numZ.Size = new Size(66, 27);
            numZ.TabIndex = 3;
            // 
            // lblX
            // 
            lblX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblX.AutoSize = true;
            lblX.Location = new Point(44, 8);
            lblX.Name = "lblX";
            lblX.Size = new Size(18, 20);
            lblX.TabIndex = 4;
            lblX.Text = "X";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(188, 8);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 6;
            label3.Text = "Z";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(116, 8);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // numDistance
            // 
            numDistance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numDistance.DecimalPlaces = 2;
            numDistance.Location = new Point(260, 32);
            numDistance.Margin = new Padding(3, 4, 3, 4);
            numDistance.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(66, 27);
            numDistance.TabIndex = 12;
            // 
            // lblDistance
            // 
            lblDistance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(260, 8);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(66, 20);
            lblDistance.TabIndex = 13;
            lblDistance.Text = "Distance";
            // 
            // groupBoxPlane
            // 
            groupBoxPlane.Controls.Add(tableLayoutCoords);
            groupBoxPlane.Dock = DockStyle.Fill;
            groupBoxPlane.Location = new Point(0, 0);
            groupBoxPlane.Margin = new Padding(2);
            groupBoxPlane.Name = "groupBoxPlane";
            groupBoxPlane.Padding = new Padding(2);
            groupBoxPlane.Size = new Size(374, 130);
            groupBoxPlane.TabIndex = 12;
            groupBoxPlane.TabStop = false;
            groupBoxPlane.Text = "Plane";
            // 
            // EditorPlane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPlane);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditorPlane";
            Size = new Size(374, 130);
            tableLayoutCoords.ResumeLayout(false);
            tableLayoutCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            groupBoxPlane.ResumeLayout(false);
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
        private GroupBox groupBoxPlane;
    }
}
