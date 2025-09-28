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
            label4 = new Label();
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
            label1.Location = new Point(70, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(70, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Gloss:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(146, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Specular:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(237, 62);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 3;
            label4.Text = "Reflection:";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(label1, 1, 0);
            tableLayoutPanel.Controls.Add(label2, 1, 1);
            tableLayoutPanel.Controls.Add(panelColor, 2, 0);
            tableLayoutPanel.Controls.Add(numSpecular, 2, 2);
            tableLayoutPanel.Controls.Add(numGloss, 1, 2);
            tableLayoutPanel.Controls.Add(label3, 2, 1);
            tableLayoutPanel.Controls.Add(label4, 3, 1);
            tableLayoutPanel.Controls.Add(numReflection, 3, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(368, 224);
            tableLayoutPanel.TabIndex = 4;
            // 
            // panelColor
            // 
            panelColor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelColor.BorderStyle = BorderStyle.FixedSingle;
            panelColor.Cursor = Cursors.Hand;
            panelColor.Location = new Point(140, 8);
            panelColor.Margin = new Padding(7, 8, 7, 8);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(86, 39);
            panelColor.TabIndex = 7;
            panelColor.Click += panelColor_Click;
            // 
            // numSpecular
            // 
            numSpecular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numSpecular.DecimalPlaces = 2;
            numSpecular.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numSpecular.Location = new Point(137, 107);
            numSpecular.Margin = new Padding(4, 5, 4, 5);
            numSpecular.Name = "numSpecular";
            numSpecular.Size = new Size(92, 31);
            numSpecular.TabIndex = 5;
            // 
            // numGloss
            // 
            numGloss.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numGloss.DecimalPlaces = 2;
            numGloss.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numGloss.Location = new Point(37, 107);
            numGloss.Margin = new Padding(4, 5, 4, 5);
            numGloss.Name = "numGloss";
            numGloss.Size = new Size(92, 31);
            numGloss.TabIndex = 4;
            // 
            // numReflection
            // 
            numReflection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numReflection.DecimalPlaces = 2;
            numReflection.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numReflection.Location = new Point(237, 107);
            numReflection.Margin = new Padding(4, 5, 4, 5);
            numReflection.Name = "numReflection";
            numReflection.Size = new Size(93, 31);
            numReflection.TabIndex = 6;
            // 
            // EditorMaterial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditorMaterial";
            Size = new Size(368, 224);
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
        private Label label4;
        private TableLayoutPanel tableLayoutPanel;
        private NumericUpDown numGloss;
        private NumericUpDown numSpecular;
        private NumericUpDown numReflection;
        private ColorDialog dlgColor;
        private Panel panelColor;
    }
}
