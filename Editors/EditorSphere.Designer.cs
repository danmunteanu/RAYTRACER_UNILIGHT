namespace Unilight.Editors
{
    partial class EditorSphere
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
            lblRadius = new Label();
            numRadius = new NumericUpDown();
            tableLayoutPanel = new TableLayoutPanel();
            grpSphere = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numRadius).BeginInit();
            tableLayoutPanel.SuspendLayout();
            grpSphere.SuspendLayout();
            SuspendLayout();
            // 
            // lblRadius
            // 
            lblRadius.Anchor = AnchorStyles.Right;
            lblRadius.AutoSize = true;
            lblRadius.Location = new Point(27, 16);
            lblRadius.Margin = new Padding(4, 0, 4, 0);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(69, 25);
            lblRadius.TabIndex = 1;
            lblRadius.Text = "Radius:";
            // 
            // numRadius
            // 
            numRadius.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numRadius.DecimalPlaces = 2;
            numRadius.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numRadius.Location = new Point(104, 13);
            numRadius.Margin = new Padding(4, 5, 4, 5);
            numRadius.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRadius.Name = "numRadius";
            numRadius.Size = new Size(92, 31);
            numRadius.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(lblRadius, 0, 0);
            tableLayoutPanel.Controls.Add(numRadius, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(3, 27);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(335, 102);
            tableLayoutPanel.TabIndex = 3;
            // 
            // grpSphere
            // 
            grpSphere.Controls.Add(tableLayoutPanel);
            grpSphere.Dock = DockStyle.Fill;
            grpSphere.Location = new Point(0, 0);
            grpSphere.Name = "grpSphere";
            grpSphere.Size = new Size(341, 132);
            grpSphere.TabIndex = 4;
            grpSphere.TabStop = false;
            grpSphere.Text = "Sphere";
            // 
            // EditorSphere
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpSphere);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditorSphere";
            Size = new Size(341, 132);
            ((System.ComponentModel.ISupportInitialize)numRadius).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            grpSphere.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblRadius;
        private NumericUpDown numRadius;
        private TableLayoutPanel tableLayoutPanel;
        private GroupBox grpSphere;
    }
}
