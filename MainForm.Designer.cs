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
            SuspendLayout();
            // 
            // panelRender
            // 
            panelRender.Location = new Point(12, 12);
            panelRender.Name = "panelRender";
            panelRender.Size = new Size(675, 383);
            panelRender.TabIndex = 0;
            // 
            // progressRender
            // 
            progressRender.Location = new Point(12, 401);
            progressRender.Name = "progressRender";
            progressRender.Size = new Size(564, 23);
            progressRender.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(582, 401);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 2;
            button1.Text = "RENDER";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 443);
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
    }
}
