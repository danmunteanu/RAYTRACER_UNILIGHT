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
            ((System.ComponentModel.ISupportInitialize)pictureRender).BeginInit();
            SuspendLayout();
            // 
            // progressRender
            // 
            progressRender.Location = new Point(13, 662);
            progressRender.Margin = new Padding(4, 5, 4, 5);
            progressRender.Name = "progressRender";
            progressRender.Size = new Size(771, 38);
            progressRender.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(793, 662);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(177, 38);
            button1.TabIndex = 2;
            button1.Text = "RENDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNewScene
            // 
            btnNewScene.Location = new Point(13, 14);
            btnNewScene.Margin = new Padding(4, 5, 4, 5);
            btnNewScene.Name = "btnNewScene";
            btnNewScene.Size = new Size(117, 45);
            btnNewScene.TabIndex = 3;
            btnNewScene.Text = "NEW";
            btnNewScene.UseVisualStyleBackColor = true;
            btnNewScene.Click += btnNewScene_Click;
            // 
            // btnCloseScene
            // 
            btnCloseScene.Location = new Point(138, 14);
            btnCloseScene.Margin = new Padding(4, 5, 4, 5);
            btnCloseScene.Name = "btnCloseScene";
            btnCloseScene.Size = new Size(117, 45);
            btnCloseScene.TabIndex = 4;
            btnCloseScene.Text = "CLOSE";
            btnCloseScene.UseVisualStyleBackColor = true;
            btnCloseScene.Click += btnCloseScene_Click;
            // 
            // pictureRender
            // 
            pictureRender.Location = new Point(13, 67);
            pictureRender.Name = "pictureRender";
            pictureRender.Size = new Size(957, 587);
            pictureRender.TabIndex = 5;
            pictureRender.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 718);
            Controls.Add(pictureRender);
            Controls.Add(btnCloseScene);
            Controls.Add(btnNewScene);
            Controls.Add(button1);
            Controls.Add(progressRender);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureRender).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressRender;
        private Button button1;
        private Button btnNewScene;
        private Button btnCloseScene;
        private PictureBox pictureRender;
    }
}
