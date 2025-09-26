namespace RAYTRACER_UNILIGHT.Editors
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
            ((System.ComponentModel.ISupportInitialize)numRadius).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblRadius
            // 
            lblRadius.Anchor = AnchorStyles.Right;
            lblRadius.AutoSize = true;
            lblRadius.Location = new Point(7, 10);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(45, 15);
            lblRadius.TabIndex = 1;
            lblRadius.Text = "Radius:";
            // 
            // numRadius
            // 
            numRadius.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numRadius.DecimalPlaces = 2;
            numRadius.Location = new Point(58, 6);
            numRadius.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRadius.Name = "numRadius";
            numRadius.Size = new Size(54, 23);
            numRadius.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(lblRadius, 0, 0);
            tableLayoutPanel.Controls.Add(numRadius, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(239, 79);
            tableLayoutPanel.TabIndex = 3;
            // 
            // EditorSphere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "EditorSphere";
            Size = new Size(239, 79);
            ((System.ComponentModel.ISupportInitialize)numRadius).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblRadius;
        private NumericUpDown numRadius;
        private TableLayoutPanel tableLayoutPanel;
    }
}
