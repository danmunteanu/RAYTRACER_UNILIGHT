namespace Unilight.Editors
{
    partial class EditorRaytracer
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
            chkGlobalReflection = new CheckBox();
            chkDiffuse = new CheckBox();
            chkAmbient = new CheckBox();
            chkFog = new CheckBox();
            chkSpecular = new CheckBox();
            numTracerDepth = new NumericUpDown();
            lblTraceDepth = new Label();
            cmbTraversalOrder = new ComboBox();
            lblTraversalOrder = new Label();
            tableLayoutSettings = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numTracerDepth).BeginInit();
            tableLayoutSettings.SuspendLayout();
            SuspendLayout();
            // 
            // chkGlobalReflection
            // 
            chkGlobalReflection.Anchor = AnchorStyles.Right;
            chkGlobalReflection.AutoSize = true;
            chkGlobalReflection.Location = new Point(26, 129);
            chkGlobalReflection.Name = "chkGlobalReflection";
            chkGlobalReflection.Size = new Size(169, 24);
            chkGlobalReflection.TabIndex = 0;
            chkGlobalReflection.Text = "Compute Reflections";
            chkGlobalReflection.UseVisualStyleBackColor = true;
            // 
            // chkDiffuse
            // 
            chkDiffuse.Anchor = AnchorStyles.Right;
            chkDiffuse.AutoSize = true;
            chkDiffuse.Location = new Point(52, 164);
            chkDiffuse.Name = "chkDiffuse";
            chkDiffuse.Size = new Size(143, 24);
            chkDiffuse.TabIndex = 1;
            chkDiffuse.Text = "Compute Diffuse";
            chkDiffuse.UseVisualStyleBackColor = true;
            // 
            // chkAmbient
            // 
            chkAmbient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkAmbient.AutoSize = true;
            chkAmbient.Enabled = false;
            chkAmbient.Location = new Point(201, 164);
            chkAmbient.Name = "chkAmbient";
            chkAmbient.Size = new Size(193, 24);
            chkAmbient.TabIndex = 2;
            chkAmbient.Text = "Compute Ambient";
            chkAmbient.UseVisualStyleBackColor = true;
            // 
            // chkFog
            // 
            chkFog.Anchor = AnchorStyles.Right;
            chkFog.AutoSize = true;
            chkFog.Enabled = false;
            chkFog.Location = new Point(74, 199);
            chkFog.Name = "chkFog";
            chkFog.Size = new Size(121, 24);
            chkFog.TabIndex = 3;
            chkFog.Text = "Compute Fog";
            chkFog.UseVisualStyleBackColor = true;
            // 
            // chkSpecular
            // 
            chkSpecular.Anchor = AnchorStyles.Left;
            chkSpecular.AutoSize = true;
            chkSpecular.Location = new Point(201, 129);
            chkSpecular.Name = "chkSpecular";
            chkSpecular.Size = new Size(153, 24);
            chkSpecular.TabIndex = 4;
            chkSpecular.Text = "Compute Specular";
            chkSpecular.UseVisualStyleBackColor = true;
            // 
            // numTracerDepth
            // 
            numTracerDepth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numTracerDepth.Location = new Point(201, 58);
            numTracerDepth.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numTracerDepth.Name = "numTracerDepth";
            numTracerDepth.Size = new Size(193, 27);
            numTracerDepth.TabIndex = 5;
            // 
            // lblTraceDepth
            // 
            lblTraceDepth.Anchor = AnchorStyles.Right;
            lblTraceDepth.AutoSize = true;
            lblTraceDepth.Location = new Point(103, 61);
            lblTraceDepth.Name = "lblTraceDepth";
            lblTraceDepth.Size = new Size(92, 20);
            lblTraceDepth.TabIndex = 6;
            lblTraceDepth.Text = "Trace Depth:";
            // 
            // cmbTraversalOrder
            // 
            cmbTraversalOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTraversalOrder.FormattingEnabled = true;
            cmbTraversalOrder.Items.AddRange(new object[] { "Left To Right", "Top To Bottom" });
            cmbTraversalOrder.Location = new Point(201, 92);
            cmbTraversalOrder.Name = "cmbTraversalOrder";
            cmbTraversalOrder.Size = new Size(151, 28);
            cmbTraversalOrder.TabIndex = 7;
            // 
            // lblTraversalOrder
            // 
            lblTraversalOrder.Anchor = AnchorStyles.Right;
            lblTraversalOrder.AutoSize = true;
            lblTraversalOrder.Location = new Point(83, 96);
            lblTraversalOrder.Name = "lblTraversalOrder";
            lblTraversalOrder.Size = new Size(112, 20);
            lblTraversalOrder.TabIndex = 8;
            lblTraversalOrder.Text = "Traversal Order:";
            // 
            // tableLayoutSettings
            // 
            tableLayoutSettings.ColumnCount = 2;
            tableLayoutSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutSettings.Controls.Add(lblTraceDepth, 0, 1);
            tableLayoutSettings.Controls.Add(numTracerDepth, 1, 1);
            tableLayoutSettings.Controls.Add(cmbTraversalOrder, 1, 2);
            tableLayoutSettings.Controls.Add(lblTraversalOrder, 0, 2);
            tableLayoutSettings.Controls.Add(chkGlobalReflection, 0, 3);
            tableLayoutSettings.Controls.Add(chkDiffuse, 0, 4);
            tableLayoutSettings.Controls.Add(chkSpecular, 1, 3);
            tableLayoutSettings.Controls.Add(chkAmbient, 1, 4);
            tableLayoutSettings.Controls.Add(chkFog, 0, 5);
            tableLayoutSettings.Dock = DockStyle.Fill;
            tableLayoutSettings.Location = new Point(0, 0);
            tableLayoutSettings.Name = "tableLayoutSettings";
            tableLayoutSettings.RowCount = 7;
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutSettings.Size = new Size(397, 283);
            tableLayoutSettings.TabIndex = 9;
            // 
            // EditorRaytracer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutSettings);
            Name = "EditorRaytracer";
            Size = new Size(397, 283);
            ((System.ComponentModel.ISupportInitialize)numTracerDepth).EndInit();
            tableLayoutSettings.ResumeLayout(false);
            tableLayoutSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkGlobalReflection;
        private CheckBox chkDiffuse;
        private CheckBox chkAmbient;
        private CheckBox chkFog;
        private CheckBox chkSpecular;
        private NumericUpDown numTracerDepth;
        private Label lblTraceDepth;
        private ComboBox cmbTraversalOrder;
        private Label lblTraversalOrder;
        private TableLayoutPanel tableLayoutSettings;
    }
}
