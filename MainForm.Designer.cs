namespace UnilightRaytracer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressRender = new ProgressBar();
            button1 = new Button();
            btnNewScene = new Button();
            btnCloseScene = new Button();
            pictureRender = new PictureBox();
            tableLayoutTop = new TableLayoutPanel();
            tableLayoutRender = new TableLayoutPanel();
            btnSettings = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutCenter = new TableLayoutPanel();
            tableLayoutItems = new TableLayoutPanel();
            lstItems = new ListBox();
            panelEditor = new Panel();
            editorGObject = new RAYTRACER_UNILIGHT.Editors.EditorGObject();
            ((System.ComponentModel.ISupportInitialize)pictureRender).BeginInit();
            tableLayoutTop.SuspendLayout();
            tableLayoutRender.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutCenter.SuspendLayout();
            tableLayoutItems.SuspendLayout();
            SuspendLayout();
            // 
            // progressRender
            // 
            progressRender.Dock = DockStyle.Fill;
            progressRender.Location = new Point(3, 3);
            progressRender.Name = "progressRender";
            progressRender.Size = new Size(726, 28);
            progressRender.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(735, 3);
            button1.Name = "button1";
            button1.Size = new Size(114, 28);
            button1.TabIndex = 2;
            button1.Text = "RENDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonRender_Click;
            // 
            // btnNewScene
            // 
            btnNewScene.Dock = DockStyle.Fill;
            btnNewScene.Location = new Point(3, 3);
            btnNewScene.Name = "btnNewScene";
            btnNewScene.Size = new Size(74, 28);
            btnNewScene.TabIndex = 3;
            btnNewScene.Text = "NEW";
            btnNewScene.UseVisualStyleBackColor = true;
            btnNewScene.Click += btnNewScene_Click;
            // 
            // btnCloseScene
            // 
            btnCloseScene.Dock = DockStyle.Fill;
            btnCloseScene.Location = new Point(83, 3);
            btnCloseScene.Name = "btnCloseScene";
            btnCloseScene.Size = new Size(74, 28);
            btnCloseScene.TabIndex = 4;
            btnCloseScene.Text = "CLOSE";
            btnCloseScene.UseVisualStyleBackColor = true;
            btnCloseScene.Click += btnCloseScene_Click;
            // 
            // pictureRender
            // 
            pictureRender.BackColor = System.Drawing.Color.Navy;
            pictureRender.BackgroundImageLayout = ImageLayout.None;
            pictureRender.Dock = DockStyle.Fill;
            pictureRender.Location = new Point(286, 2);
            pictureRender.Margin = new Padding(2);
            pictureRender.Name = "pictureRender";
            pictureRender.Size = new Size(684, 503);
            pictureRender.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRender.TabIndex = 5;
            pictureRender.TabStop = false;
            // 
            // tableLayoutTop
            // 
            tableLayoutTop.ColumnCount = 3;
            tableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTop.Controls.Add(btnNewScene, 0, 0);
            tableLayoutTop.Controls.Add(btnCloseScene, 1, 0);
            tableLayoutTop.Dock = DockStyle.Fill;
            tableLayoutTop.Location = new Point(3, 3);
            tableLayoutTop.Name = "tableLayoutTop";
            tableLayoutTop.RowCount = 1;
            tableLayoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTop.Size = new Size(972, 34);
            tableLayoutTop.TabIndex = 6;
            // 
            // tableLayoutRender
            // 
            tableLayoutRender.ColumnCount = 3;
            tableLayoutRender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRender.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutRender.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutRender.Controls.Add(progressRender, 0, 0);
            tableLayoutRender.Controls.Add(button1, 1, 0);
            tableLayoutRender.Controls.Add(btnSettings, 2, 0);
            tableLayoutRender.Dock = DockStyle.Fill;
            tableLayoutRender.Location = new Point(3, 556);
            tableLayoutRender.Name = "tableLayoutRender";
            tableLayoutRender.RowCount = 1;
            tableLayoutRender.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRender.Size = new Size(972, 34);
            tableLayoutRender.TabIndex = 7;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.Location = new Point(855, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(114, 28);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "SETTINGS";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutCenter, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutTop, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutRender, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.Size = new Size(978, 593);
            tableLayoutMain.TabIndex = 8;
            // 
            // tableLayoutCenter
            // 
            tableLayoutCenter.ColumnCount = 2;
            tableLayoutCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 284F));
            tableLayoutCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCenter.Controls.Add(tableLayoutItems, 0, 0);
            tableLayoutCenter.Controls.Add(pictureRender, 1, 0);
            tableLayoutCenter.Dock = DockStyle.Fill;
            tableLayoutCenter.Location = new Point(3, 43);
            tableLayoutCenter.Name = "tableLayoutCenter";
            tableLayoutCenter.RowCount = 1;
            tableLayoutCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCenter.Size = new Size(972, 507);
            tableLayoutCenter.TabIndex = 9;
            // 
            // tableLayoutItems
            // 
            tableLayoutItems.ColumnCount = 1;
            tableLayoutItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutItems.Controls.Add(lstItems, 0, 0);
            tableLayoutItems.Controls.Add(panelEditor, 0, 2);
            tableLayoutItems.Controls.Add(editorGObject, 0, 1);
            tableLayoutItems.Dock = DockStyle.Fill;
            tableLayoutItems.Location = new Point(3, 3);
            tableLayoutItems.Name = "tableLayoutItems";
            tableLayoutItems.RowCount = 3;
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 241F));
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutItems.Size = new Size(278, 501);
            tableLayoutItems.TabIndex = 10;
            // 
            // lstItems
            // 
            lstItems.Dock = DockStyle.Fill;
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(3, 3);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(272, 189);
            lstItems.TabIndex = 6;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // panelEditor
            // 
            panelEditor.Dock = DockStyle.Fill;
            panelEditor.Location = new Point(3, 439);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(272, 59);
            panelEditor.TabIndex = 7;
            // 
            // editorGObject
            // 
            editorGObject.Dock = DockStyle.Fill;
            editorGObject.Location = new Point(3, 198);
            editorGObject.Name = "editorGObject";
            editorGObject.Size = new Size(272, 235);
            editorGObject.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 593);
            Controls.Add(tableLayoutMain);
            Name = "MainForm";
            Text = "Raytracer Unilight";
            ((System.ComponentModel.ISupportInitialize)pictureRender).EndInit();
            tableLayoutTop.ResumeLayout(false);
            tableLayoutRender.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutCenter.ResumeLayout(false);
            tableLayoutItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressRender;
        private Button button1;
        private Button btnNewScene;
        private Button btnCloseScene;
        private PictureBox pictureRender;
        private TableLayoutPanel tableLayoutTop;
        private TableLayoutPanel tableLayoutRender;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutCenter;
        private ListBox lstItems;
        private Button btnSettings;
        private TableLayoutPanel tableLayoutItems;
        private Panel panelEditor;
        private RAYTRACER_UNILIGHT.Editors.EditorGObject editorGObject;
    }
}
