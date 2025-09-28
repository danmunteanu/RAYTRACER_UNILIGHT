namespace Unilight.Editors
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
            lblReflection = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            panelColor = new Panel();
            numSpecular = new NumericUpDown();
            numGloss = new NumericUpDown();
            numReflection = new NumericUpDown();
            dlgColor = new ColorDialog();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSpecular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGloss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReflection).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(53, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(54, 50);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Gloss:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(112, 50);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Specular:";
            // 
            // lblReflection
            // 
            lblReflection.Anchor = AnchorStyles.Right;
            lblReflection.AutoSize = true;
            lblReflection.Location = new Point(187, 50);
            lblReflection.Name = "lblReflection";
            lblReflection.Size = new Size(79, 20);
            lblReflection.TabIndex = 3;
            lblReflection.Text = "Reflection:";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(label1, 1, 0);
            tableLayoutPanel.Controls.Add(label2, 1, 1);
            tableLayoutPanel.Controls.Add(panelColor, 2, 0);
            tableLayoutPanel.Controls.Add(numSpecular, 2, 2);
            tableLayoutPanel.Controls.Add(numGloss, 1, 2);
            tableLayoutPanel.Controls.Add(label3, 2, 1);
            tableLayoutPanel.Controls.Add(lblReflection, 3, 1);
            tableLayoutPanel.Controls.Add(numReflection, 3, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(294, 179);
            tableLayoutPanel.TabIndex = 4;
            // 
            // panelColor
            // 
            panelColor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelColor.BorderStyle = BorderStyle.FixedSingle;
            panelColor.Cursor = Cursors.Hand;
            panelColor.Location = new Point(110, 6);
            panelColor.Margin = new Padding(6, 6, 6, 6);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(68, 32);
            panelColor.TabIndex = 7;
            panelColor.Click += panelColor_Click;
            // 
            // numSpecular
            // 
            numSpecular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numSpecular.DecimalPlaces = 2;
            numSpecular.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numSpecular.Location = new Point(107, 84);
            numSpecular.Margin = new Padding(3, 4, 3, 4);
            numSpecular.Name = "numSpecular";
            numSpecular.Size = new Size(74, 27);
            numSpecular.TabIndex = 5;
            // 
            // numGloss
            // 
            numGloss.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numGloss.DecimalPlaces = 2;
            numGloss.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numGloss.Location = new Point(27, 84);
            numGloss.Margin = new Padding(3, 4, 3, 4);
            numGloss.Name = "numGloss";
            numGloss.Size = new Size(74, 27);
            numGloss.TabIndex = 4;
            // 
            // numReflection
            // 
            numReflection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numReflection.DecimalPlaces = 2;
            numReflection.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numReflection.Location = new Point(187, 84);
            numReflection.Margin = new Padding(3, 4, 3, 4);
            numReflection.Name = "numReflection";
            numReflection.Size = new Size(79, 27);
            numReflection.TabIndex = 6;
            // 
            // EditorMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditorMaterial";
            Size = new Size(294, 179);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSpecular).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGloss).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReflection).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblReflection;
        private TableLayoutPanel tableLayoutPanel;
        private NumericUpDown numGloss;
        private NumericUpDown numSpecular;
        private NumericUpDown numReflection;
        private ColorDialog dlgColor;
        private Panel panelColor;
    }
}
