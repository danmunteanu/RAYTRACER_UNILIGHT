namespace Unilight
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
            btnRender = new Button();
            btnNewScene = new Button();
            btnCloseScene = new Button();
            pictureRender = new PictureBox();
            tableLayoutTop = new TableLayoutPanel();
            tableLayoutRender = new TableLayoutPanel();
            btnSettings = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutCenter = new TableLayoutPanel();
            tableLayoutItems = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReset = new Button();
            btnUpdate = new Button();
            lstItems = new ListBox();
            panelEditor = new Panel();
            editorGObject = new Unilight.Editors.EditorGObject();
            lblObjects = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureRender).BeginInit();
            tableLayoutTop.SuspendLayout();
            tableLayoutRender.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutCenter.SuspendLayout();
            tableLayoutItems.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressRender
            // 
            progressRender.Dock = DockStyle.Fill;
            progressRender.Location = new Point(4, 5);
            progressRender.Margin = new Padding(4, 5, 4, 5);
            progressRender.Name = "progressRender";
            progressRender.Size = new Size(1039, 47);
            progressRender.TabIndex = 1;
            // 
            // btnRender
            // 
            btnRender.Dock = DockStyle.Fill;
            btnRender.Location = new Point(1051, 5);
            btnRender.Margin = new Padding(4, 5, 4, 5);
            btnRender.Name = "btnRender";
            btnRender.Size = new Size(163, 47);
            btnRender.TabIndex = 2;
            btnRender.Text = "RENDER";
            btnRender.UseVisualStyleBackColor = true;
            btnRender.Click += buttonRender_Click;
            // 
            // btnNewScene
            // 
            btnNewScene.Dock = DockStyle.Fill;
            btnNewScene.Enabled = false;
            btnNewScene.Location = new Point(4, 5);
            btnNewScene.Margin = new Padding(4, 5, 4, 5);
            btnNewScene.Name = "btnNewScene";
            btnNewScene.Size = new Size(106, 47);
            btnNewScene.TabIndex = 3;
            btnNewScene.Text = "NEW";
            btnNewScene.UseVisualStyleBackColor = true;
            btnNewScene.Click += btnNewScene_Click;
            // 
            // btnCloseScene
            // 
            btnCloseScene.Dock = DockStyle.Fill;
            btnCloseScene.Enabled = false;
            btnCloseScene.Location = new Point(118, 5);
            btnCloseScene.Margin = new Padding(4, 5, 4, 5);
            btnCloseScene.Name = "btnCloseScene";
            btnCloseScene.Size = new Size(106, 47);
            btnCloseScene.TabIndex = 4;
            btnCloseScene.Text = "CLOSE";
            btnCloseScene.UseVisualStyleBackColor = true;
            btnCloseScene.Click += btnCloseScene_Click;
            // 
            // pictureRender
            // 
            pictureRender.BackColor = SystemColors.ActiveCaptionText;
            pictureRender.BackgroundImageLayout = ImageLayout.None;
            pictureRender.Dock = DockStyle.Fill;
            pictureRender.Location = new Point(409, 3);
            pictureRender.Name = "pictureRender";
            pictureRender.Size = new Size(977, 838);
            pictureRender.SizeMode = PictureBoxSizeMode.Zoom;
            pictureRender.TabIndex = 5;
            pictureRender.TabStop = false;
            // 
            // tableLayoutTop
            // 
            tableLayoutTop.ColumnCount = 3;
            tableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTop.Controls.Add(btnNewScene, 0, 0);
            tableLayoutTop.Controls.Add(btnCloseScene, 1, 0);
            tableLayoutTop.Dock = DockStyle.Fill;
            tableLayoutTop.Location = new Point(4, 5);
            tableLayoutTop.Margin = new Padding(4, 5, 4, 5);
            tableLayoutTop.Name = "tableLayoutTop";
            tableLayoutTop.RowCount = 1;
            tableLayoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTop.Size = new Size(1389, 57);
            tableLayoutTop.TabIndex = 6;
            // 
            // tableLayoutRender
            // 
            tableLayoutRender.ColumnCount = 3;
            tableLayoutRender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRender.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutRender.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutRender.Controls.Add(progressRender, 0, 0);
            tableLayoutRender.Controls.Add(btnRender, 1, 0);
            tableLayoutRender.Controls.Add(btnSettings, 2, 0);
            tableLayoutRender.Dock = DockStyle.Fill;
            tableLayoutRender.Location = new Point(4, 926);
            tableLayoutRender.Margin = new Padding(4, 5, 4, 5);
            tableLayoutRender.Name = "tableLayoutRender";
            tableLayoutRender.RowCount = 1;
            tableLayoutRender.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRender.Size = new Size(1389, 57);
            tableLayoutRender.TabIndex = 7;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.Location = new Point(1222, 5);
            btnSettings.Margin = new Padding(4, 5, 4, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(163, 47);
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
            tableLayoutMain.Margin = new Padding(4, 5, 4, 5);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutMain.Size = new Size(1397, 988);
            tableLayoutMain.TabIndex = 8;
            // 
            // tableLayoutCenter
            // 
            tableLayoutCenter.ColumnCount = 2;
            tableLayoutCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 406F));
            tableLayoutCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCenter.Controls.Add(tableLayoutItems, 0, 0);
            tableLayoutCenter.Controls.Add(pictureRender, 1, 0);
            tableLayoutCenter.Dock = DockStyle.Fill;
            tableLayoutCenter.Location = new Point(4, 72);
            tableLayoutCenter.Margin = new Padding(4, 5, 4, 5);
            tableLayoutCenter.Name = "tableLayoutCenter";
            tableLayoutCenter.RowCount = 1;
            tableLayoutCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCenter.Size = new Size(1389, 844);
            tableLayoutCenter.TabIndex = 9;
            // 
            // tableLayoutItems
            // 
            tableLayoutItems.ColumnCount = 1;
            tableLayoutItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutItems.Controls.Add(tableLayoutPanel1, 0, 4);
            tableLayoutItems.Controls.Add(lstItems, 0, 1);
            tableLayoutItems.Controls.Add(panelEditor, 0, 3);
            tableLayoutItems.Controls.Add(editorGObject, 0, 2);
            tableLayoutItems.Controls.Add(lblObjects, 0, 0);
            tableLayoutItems.Dock = DockStyle.Fill;
            tableLayoutItems.Location = new Point(4, 5);
            tableLayoutItems.Margin = new Padding(4, 5, 4, 5);
            tableLayoutItems.Name = "tableLayoutItems";
            tableLayoutItems.RowCount = 5;
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 334F));
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
            tableLayoutItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutItems.Size = new Size(398, 834);
            tableLayoutItems.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnReset, 1, 0);
            tableLayoutPanel1.Controls.Add(btnUpdate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 781);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(390, 48);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.Enabled = false;
            btnReset.Location = new Point(195, 0);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(195, 48);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 48);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lstItems
            // 
            lstItems.Dock = DockStyle.Fill;
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 25;
            lstItems.Location = new Point(4, 47);
            lstItems.Margin = new Padding(4, 5, 4, 5);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(390, 216);
            lstItems.TabIndex = 6;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // panelEditor
            // 
            panelEditor.Dock = DockStyle.Fill;
            panelEditor.Location = new Point(4, 607);
            panelEditor.Margin = new Padding(4, 5, 4, 5);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(390, 164);
            panelEditor.TabIndex = 7;
            // 
            // editorGObject
            // 
            editorGObject.Dock = DockStyle.Fill;
            editorGObject.Location = new Point(6, 276);
            editorGObject.Margin = new Padding(6, 8, 6, 8);
            editorGObject.Name = "editorGObject";
            editorGObject.Size = new Size(386, 318);
            editorGObject.TabIndex = 8;
            // 
            // lblObjects
            // 
            lblObjects.Anchor = AnchorStyles.Left;
            lblObjects.AutoSize = true;
            lblObjects.Location = new Point(4, 8);
            lblObjects.Margin = new Padding(4, 0, 4, 0);
            lblObjects.Name = "lblObjects";
            lblObjects.Size = new Size(124, 25);
            lblObjects.TabIndex = 10;
            lblObjects.Text = "Scene objects:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 988);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Unilight Raytracer";
            ((System.ComponentModel.ISupportInitialize)pictureRender).EndInit();
            tableLayoutTop.ResumeLayout(false);
            tableLayoutRender.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutCenter.ResumeLayout(false);
            tableLayoutItems.ResumeLayout(false);
            tableLayoutItems.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressRender;
        private Button btnRender;
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
        private global::Unilight.Editors.EditorGObject editorGObject;
        private Button btnUpdate;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnReset;
        private Label lblObjects;
    }
}
