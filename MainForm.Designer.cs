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
            panelRender = new Panel();
            progressRender = new ProgressBar();
            button1 = new Button();
            btnNewScene = new Button();
            btnCloseScene = new Button();
            SuspendLayout();
            // 
            // panelRender
            // 
            panelRender.Location = new Point(127, 12);
            panelRender.Name = "panelRender";
            panelRender.Size = new Size(641, 383);
            panelRender.TabIndex = 0;
            // 
            // progressRender
            // 
            progressRender.Location = new Point(127, 401);
            progressRender.Name = "progressRender";
            progressRender.Size = new Size(540, 23);
            progressRender.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(673, 401);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 2;
            button1.Text = "RENDER";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnNewScene
            // 
            btnNewScene.Location = new Point(12, 12);
            btnNewScene.Name = "btnNewScene";
            btnNewScene.Size = new Size(109, 27);
            btnNewScene.TabIndex = 3;
            btnNewScene.Text = "NEW";
            btnNewScene.UseVisualStyleBackColor = true;
            btnNewScene.Click += btnNewScene_Click;
            // 
            // btnCloseScene
            // 
            btnCloseScene.Location = new Point(12, 45);
            btnCloseScene.Name = "btnCloseScene";
            btnCloseScene.Size = new Size(109, 27);
            btnCloseScene.TabIndex = 4;
            btnCloseScene.Text = "CLOSE";
            btnCloseScene.UseVisualStyleBackColor = true;
            btnCloseScene.Click += btnCloseScene_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 483);
            Controls.Add(btnCloseScene);
            Controls.Add(btnNewScene);
            Controls.Add(button1);
            Controls.Add(progressRender);
            Controls.Add(panelRender);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRender;
        private ProgressBar progressRender;
        private Button button1;
        private Button btnNewScene;
        private Button btnCloseScene;
    }
}
