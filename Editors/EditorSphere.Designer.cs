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
            lblRadius.Location = new Point(71, 48);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(45, 15);
            lblRadius.TabIndex = 1;
            lblRadius.Text = "Radius:";
            // 
            // numRadius
            // 
            numRadius.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numRadius.Location = new Point(122, 44);
            numRadius.Name = "numRadius";
            numRadius.Size = new Size(74, 23);
            numRadius.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(lblRadius, 1, 1);
            tableLayoutPanel.Controls.Add(numRadius, 2, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(239, 111);
            tableLayoutPanel.TabIndex = 3;
            // 
            // EditorSphere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "EditorSphere";
            Size = new Size(239, 111);
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
