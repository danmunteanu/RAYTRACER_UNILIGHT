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
            tableLayoutPanelRender = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureRender).BeginInit();
            tableLayoutTop.SuspendLayout();
            tableLayoutPanelRender.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // progressRender
            // 
            progressRender.Dock = DockStyle.Fill;
            progressRender.Location = new Point(3, 3);
            progressRender.Name = "progressRender";
            progressRender.Size = new Size(665, 28);
            progressRender.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(674, 3);
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
            pictureRender.Dock = DockStyle.Fill;
            pictureRender.Location = new Point(2, 42);
            pictureRender.Margin = new Padding(2);
            pictureRender.Name = "pictureRender";
            pictureRender.Size = new Size(793, 380);
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
            tableLayoutTop.Size = new Size(791, 34);
            tableLayoutTop.TabIndex = 6;
            // 
            // tableLayoutPanelRender
            // 
            tableLayoutPanelRender.ColumnCount = 2;
            tableLayoutPanelRender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRender.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanelRender.Controls.Add(progressRender, 0, 0);
            tableLayoutPanelRender.Controls.Add(button1, 1, 0);
            tableLayoutPanelRender.Dock = DockStyle.Fill;
            tableLayoutPanelRender.Location = new Point(3, 427);
            tableLayoutPanelRender.Name = "tableLayoutPanelRender";
            tableLayoutPanelRender.RowCount = 1;
            tableLayoutPanelRender.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRender.Size = new Size(791, 34);
            tableLayoutPanelRender.TabIndex = 7;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutTop, 0, 0);
            tableLayoutMain.Controls.Add(pictureRender, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanelRender, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.Size = new Size(797, 464);
            tableLayoutMain.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 464);
            Controls.Add(tableLayoutMain);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureRender).EndInit();
            tableLayoutTop.ResumeLayout(false);
            tableLayoutPanelRender.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressRender;
        private Button button1;
        private Button btnNewScene;
        private Button btnCloseScene;
        private PictureBox pictureRender;
        private TableLayoutPanel tableLayoutTop;
        private TableLayoutPanel tableLayoutPanelRender;
        private TableLayoutPanel tableLayoutMain;
    }
}
