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
            lblResolutions = new Label();
            cmbResolutions = new ComboBox();
            tableLayoutCoords = new TableLayoutPanel();
            numLookX = new NumericUpDown();
            numLookY = new NumericUpDown();
            numLookZ = new NumericUpDown();
            grpCamera = new GroupBox();
            tableLayoutCamera = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            numViewportHeight = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            numEyeX = new NumericUpDown();
            numEyeY = new NumericUpDown();
            numEyeZ = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            numViewportWidth = new NumericUpDown();
            lblViewportHeight = new Label();
            label1 = new Label();
            lblLookAt = new Label();
            lblViewportWidth = new Label();
            tableLayoutTraversal = new TableLayoutPanel();
            tableLayoutTrace = new TableLayoutPanel();
            tableLayoutLeft = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutRight = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numTracerDepth).BeginInit();
            tableLayoutCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLookX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLookY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLookZ).BeginInit();
            grpCamera.SuspendLayout();
            tableLayoutCamera.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numViewportHeight).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEyeX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEyeY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEyeZ).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numViewportWidth).BeginInit();
            tableLayoutTraversal.SuspendLayout();
            tableLayoutTrace.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            SuspendLayout();
            // 
            // chkGlobalReflection
            // 
            chkGlobalReflection.Anchor = AnchorStyles.Left;
            chkGlobalReflection.AutoSize = true;
            chkGlobalReflection.Location = new Point(3, 179);
            chkGlobalReflection.Name = "chkGlobalReflection";
            chkGlobalReflection.Padding = new Padding(25, 0, 0, 0);
            chkGlobalReflection.Size = new Size(194, 24);
            chkGlobalReflection.TabIndex = 0;
            chkGlobalReflection.Text = "Compute Reflections";
            chkGlobalReflection.UseVisualStyleBackColor = true;
            // 
            // chkDiffuse
            // 
            chkDiffuse.Anchor = AnchorStyles.Left;
            chkDiffuse.AutoSize = true;
            chkDiffuse.Location = new Point(3, 269);
            chkDiffuse.Name = "chkDiffuse";
            chkDiffuse.Padding = new Padding(25, 0, 0, 0);
            chkDiffuse.Size = new Size(168, 24);
            chkDiffuse.TabIndex = 1;
            chkDiffuse.Text = "Compute Diffuse";
            chkDiffuse.UseVisualStyleBackColor = true;
            // 
            // chkAmbient
            // 
            chkAmbient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkAmbient.AutoSize = true;
            chkAmbient.Enabled = false;
            chkAmbient.Location = new Point(3, 314);
            chkAmbient.Name = "chkAmbient";
            chkAmbient.Padding = new Padding(25, 0, 0, 0);
            chkAmbient.Size = new Size(382, 24);
            chkAmbient.TabIndex = 2;
            chkAmbient.Text = "Compute Ambient";
            chkAmbient.UseVisualStyleBackColor = true;
            // 
            // chkFog
            // 
            chkFog.Anchor = AnchorStyles.Left;
            chkFog.AutoSize = true;
            chkFog.Enabled = false;
            chkFog.Location = new Point(3, 359);
            chkFog.Name = "chkFog";
            chkFog.Padding = new Padding(25, 0, 0, 0);
            chkFog.Size = new Size(146, 24);
            chkFog.TabIndex = 3;
            chkFog.Text = "Compute Fog";
            chkFog.UseVisualStyleBackColor = true;
            // 
            // chkSpecular
            // 
            chkSpecular.Anchor = AnchorStyles.Left;
            chkSpecular.AutoSize = true;
            chkSpecular.Location = new Point(3, 224);
            chkSpecular.Name = "chkSpecular";
            chkSpecular.Padding = new Padding(25, 0, 0, 0);
            chkSpecular.Size = new Size(178, 24);
            chkSpecular.TabIndex = 4;
            chkSpecular.Text = "Compute Specular";
            chkSpecular.UseVisualStyleBackColor = true;
            // 
            // numTracerDepth
            // 
            numTracerDepth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numTracerDepth.Location = new Point(123, 6);
            numTracerDepth.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numTracerDepth.Name = "numTracerDepth";
            numTracerDepth.Size = new Size(114, 27);
            numTracerDepth.TabIndex = 5;
            // 
            // lblTraceDepth
            // 
            lblTraceDepth.Anchor = AnchorStyles.Right;
            lblTraceDepth.AutoSize = true;
            lblTraceDepth.Location = new Point(25, 9);
            lblTraceDepth.Name = "lblTraceDepth";
            lblTraceDepth.Size = new Size(92, 20);
            lblTraceDepth.TabIndex = 6;
            lblTraceDepth.Text = "Trace Depth:";
            // 
            // cmbTraversalOrder
            // 
            cmbTraversalOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTraversalOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTraversalOrder.FormattingEnabled = true;
            cmbTraversalOrder.Items.AddRange(new object[] { "Left To Right", "Top To Bottom" });
            cmbTraversalOrder.Location = new Point(145, 8);
            cmbTraversalOrder.Name = "cmbTraversalOrder";
            cmbTraversalOrder.Size = new Size(128, 28);
            cmbTraversalOrder.TabIndex = 7;
            // 
            // lblTraversalOrder
            // 
            lblTraversalOrder.Anchor = AnchorStyles.Right;
            lblTraversalOrder.AutoSize = true;
            lblTraversalOrder.Location = new Point(27, 12);
            lblTraversalOrder.Name = "lblTraversalOrder";
            lblTraversalOrder.Size = new Size(112, 20);
            lblTraversalOrder.TabIndex = 8;
            lblTraversalOrder.Text = "Traversal Order:";
            // 
            // lblResolutions
            // 
            lblResolutions.Anchor = AnchorStyles.Right;
            lblResolutions.AutoSize = true;
            lblResolutions.Location = new Point(54, 57);
            lblResolutions.Name = "lblResolutions";
            lblResolutions.Size = new Size(85, 20);
            lblResolutions.TabIndex = 10;
            lblResolutions.Text = "Image Size:";
            // 
            // cmbResolutions
            // 
            cmbResolutions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbResolutions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResolutions.FormattingEnabled = true;
            cmbResolutions.Items.AddRange(new object[] { "1024x768", "800x600", "640x480" });
            cmbResolutions.Location = new Point(145, 53);
            cmbResolutions.Name = "cmbResolutions";
            cmbResolutions.Size = new Size(128, 28);
            cmbResolutions.TabIndex = 9;
            // 
            // tableLayoutCoords
            // 
            tableLayoutCoords.ColumnCount = 5;
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutCoords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCoords.Controls.Add(numLookX, 1, 0);
            tableLayoutCoords.Controls.Add(numLookY, 2, 0);
            tableLayoutCoords.Controls.Add(numLookZ, 3, 0);
            tableLayoutCoords.Dock = DockStyle.Fill;
            tableLayoutCoords.Location = new Point(163, 8);
            tableLayoutCoords.Margin = new Padding(3, 4, 3, 4);
            tableLayoutCoords.Name = "tableLayoutCoords";
            tableLayoutCoords.RowCount = 1;
            tableLayoutCoords.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutCoords.Size = new Size(210, 32);
            tableLayoutCoords.TabIndex = 12;
            // 
            // numLookX
            // 
            numLookX.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numLookX.DecimalPlaces = 2;
            numLookX.Location = new Point(0, 4);
            numLookX.Margin = new Padding(3, 4, 3, 4);
            numLookX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLookX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numLookX.Name = "numLookX";
            numLookX.Size = new Size(66, 27);
            numLookX.TabIndex = 1;
            // 
            // numLookY
            // 
            numLookY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numLookY.DecimalPlaces = 2;
            numLookY.Location = new Point(72, 4);
            numLookY.Margin = new Padding(3, 4, 3, 4);
            numLookY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLookY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numLookY.Name = "numLookY";
            numLookY.Size = new Size(66, 27);
            numLookY.TabIndex = 2;
            // 
            // numLookZ
            // 
            numLookZ.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numLookZ.DecimalPlaces = 2;
            numLookZ.Location = new Point(144, 4);
            numLookZ.Margin = new Padding(3, 4, 3, 4);
            numLookZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLookZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numLookZ.Name = "numLookZ";
            numLookZ.Size = new Size(66, 27);
            numLookZ.TabIndex = 3;
            // 
            // grpCamera
            // 
            grpCamera.Controls.Add(tableLayoutCamera);
            grpCamera.Dock = DockStyle.Fill;
            grpCamera.Location = new Point(3, 177);
            grpCamera.Name = "grpCamera";
            grpCamera.Size = new Size(382, 214);
            grpCamera.TabIndex = 13;
            grpCamera.TabStop = false;
            grpCamera.Text = "Camera";
            // 
            // tableLayoutCamera
            // 
            tableLayoutCamera.ColumnCount = 2;
            tableLayoutCamera.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutCamera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCamera.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutCamera.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutCamera.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutCamera.Controls.Add(tableLayoutCoords, 1, 1);
            tableLayoutCamera.Controls.Add(lblViewportHeight, 0, 5);
            tableLayoutCamera.Controls.Add(label1, 0, 2);
            tableLayoutCamera.Controls.Add(lblLookAt, 0, 1);
            tableLayoutCamera.Controls.Add(lblViewportWidth, 0, 4);
            tableLayoutCamera.Dock = DockStyle.Fill;
            tableLayoutCamera.Location = new Point(3, 23);
            tableLayoutCamera.Name = "tableLayoutCamera";
            tableLayoutCamera.Padding = new Padding(0, 20, 0, 0);
            tableLayoutCamera.RowCount = 8;
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutCamera.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCamera.Size = new Size(376, 188);
            tableLayoutCamera.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(numViewportHeight, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(163, 147);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(210, 34);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // numViewportHeight
            // 
            numViewportHeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numViewportHeight.Location = new Point(3, 3);
            numViewportHeight.Name = "numViewportHeight";
            numViewportHeight.Size = new Size(114, 27);
            numViewportHeight.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(numEyeX, 1, 0);
            tableLayoutPanel1.Controls.Add(numEyeY, 2, 0);
            tableLayoutPanel1.Controls.Add(numEyeZ, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(163, 48);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(210, 32);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // numEyeX
            // 
            numEyeX.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numEyeX.DecimalPlaces = 2;
            numEyeX.Location = new Point(0, 4);
            numEyeX.Margin = new Padding(3, 4, 3, 4);
            numEyeX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEyeX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numEyeX.Name = "numEyeX";
            numEyeX.Size = new Size(66, 27);
            numEyeX.TabIndex = 1;
            // 
            // numEyeY
            // 
            numEyeY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numEyeY.DecimalPlaces = 2;
            numEyeY.Location = new Point(72, 4);
            numEyeY.Margin = new Padding(3, 4, 3, 4);
            numEyeY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEyeY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numEyeY.Name = "numEyeY";
            numEyeY.Size = new Size(66, 27);
            numEyeY.TabIndex = 2;
            // 
            // numEyeZ
            // 
            numEyeZ.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numEyeZ.DecimalPlaces = 2;
            numEyeZ.Location = new Point(144, 4);
            numEyeZ.Margin = new Padding(3, 4, 3, 4);
            numEyeZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEyeZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numEyeZ.Name = "numEyeZ";
            numEyeZ.Size = new Size(66, 27);
            numEyeZ.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(numViewportWidth, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(163, 107);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(210, 34);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // numViewportWidth
            // 
            numViewportWidth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numViewportWidth.Location = new Point(3, 3);
            numViewportWidth.Name = "numViewportWidth";
            numViewportWidth.Size = new Size(114, 27);
            numViewportWidth.TabIndex = 14;
            // 
            // lblViewportHeight
            // 
            lblViewportHeight.Anchor = AnchorStyles.Right;
            lblViewportHeight.AutoSize = true;
            lblViewportHeight.Location = new Point(36, 154);
            lblViewportHeight.Name = "lblViewportHeight";
            lblViewportHeight.Size = new Size(121, 20);
            lblViewportHeight.TabIndex = 17;
            lblViewportHeight.Text = "Viewport Height:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(122, 54);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Eye:";
            // 
            // lblLookAt
            // 
            lblLookAt.Anchor = AnchorStyles.Right;
            lblLookAt.AutoSize = true;
            lblLookAt.Location = new Point(94, 14);
            lblLookAt.Name = "lblLookAt";
            lblLookAt.Size = new Size(63, 20);
            lblLookAt.TabIndex = 4;
            lblLookAt.Text = "Look At:";
            // 
            // lblViewportWidth
            // 
            lblViewportWidth.Anchor = AnchorStyles.Right;
            lblViewportWidth.AutoSize = true;
            lblViewportWidth.Location = new Point(41, 114);
            lblViewportWidth.Name = "lblViewportWidth";
            lblViewportWidth.Size = new Size(116, 20);
            lblViewportWidth.TabIndex = 16;
            lblViewportWidth.Text = "Viewport Width:";
            // 
            // tableLayoutTraversal
            // 
            tableLayoutTraversal.ColumnCount = 3;
            tableLayoutTraversal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutTraversal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutTraversal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTraversal.Controls.Add(lblTraversalOrder, 0, 0);
            tableLayoutTraversal.Controls.Add(cmbTraversalOrder, 1, 0);
            tableLayoutTraversal.Controls.Add(cmbResolutions, 1, 1);
            tableLayoutTraversal.Controls.Add(lblResolutions, 0, 1);
            tableLayoutTraversal.Dock = DockStyle.Fill;
            tableLayoutTraversal.Location = new Point(3, 3);
            tableLayoutTraversal.Name = "tableLayoutTraversal";
            tableLayoutTraversal.RowCount = 3;
            tableLayoutTraversal.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutTraversal.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutTraversal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTraversal.Size = new Size(382, 110);
            tableLayoutTraversal.TabIndex = 14;
            // 
            // tableLayoutTrace
            // 
            tableLayoutTrace.ColumnCount = 3;
            tableLayoutTrace.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutTrace.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutTrace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTrace.Controls.Add(lblTraceDepth, 0, 0);
            tableLayoutTrace.Controls.Add(numTracerDepth, 1, 0);
            tableLayoutTrace.Dock = DockStyle.Fill;
            tableLayoutTrace.Location = new Point(3, 3);
            tableLayoutTrace.Name = "tableLayoutTrace";
            tableLayoutTrace.RowCount = 1;
            tableLayoutTrace.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTrace.Size = new Size(382, 39);
            tableLayoutTrace.TabIndex = 15;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(tableLayoutTrace, 0, 0);
            tableLayoutLeft.Controls.Add(chkGlobalReflection, 0, 2);
            tableLayoutLeft.Controls.Add(chkSpecular, 0, 3);
            tableLayoutLeft.Controls.Add(chkFog, 0, 6);
            tableLayoutLeft.Controls.Add(chkAmbient, 0, 5);
            tableLayoutLeft.Controls.Add(chkDiffuse, 0, 4);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(3, 33);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 7;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.Size = new Size(388, 394);
            tableLayoutLeft.TabIndex = 16;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.Controls.Add(tableLayoutRight, 1, 0);
            tableLayoutMain.Controls.Add(tableLayoutLeft, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.Padding = new Padding(0, 30, 0, 30);
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(788, 460);
            tableLayoutMain.TabIndex = 17;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(grpCamera, 0, 2);
            tableLayoutRight.Controls.Add(tableLayoutTraversal, 0, 0);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(397, 33);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 3;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutRight.Size = new Size(388, 394);
            tableLayoutRight.TabIndex = 18;
            // 
            // EditorRaytracer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "EditorRaytracer";
            Size = new Size(788, 460);
            ((System.ComponentModel.ISupportInitialize)numTracerDepth).EndInit();
            tableLayoutCoords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numLookX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLookY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLookZ).EndInit();
            grpCamera.ResumeLayout(false);
            tableLayoutCamera.ResumeLayout(false);
            tableLayoutCamera.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numViewportHeight).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numEyeX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEyeY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEyeZ).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numViewportWidth).EndInit();
            tableLayoutTraversal.ResumeLayout(false);
            tableLayoutTraversal.PerformLayout();
            tableLayoutTrace.ResumeLayout(false);
            tableLayoutTrace.PerformLayout();
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutLeft.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutRight.ResumeLayout(false);
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
        private ComboBox cmbResolutions;
        private Label lblResolutions;
        private TableLayoutPanel tableLayoutCoords;
        private NumericUpDown numLookX;
        private NumericUpDown numLookY;
        private NumericUpDown numLookZ;
        private GroupBox grpCamera;
        private Label lblLookAt;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numEyeX;
        private NumericUpDown numEyeY;
        private NumericUpDown numEyeZ;
        private Label label1;
        private NumericUpDown numViewportWidth;
        private NumericUpDown numViewportHeight;
        private Label lblViewportWidth;
        private Label lblViewportHeight;
        private TableLayoutPanel tableLayoutCamera;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutTraversal;
        private TableLayoutPanel tableLayoutTrace;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutRight;
    }
}
