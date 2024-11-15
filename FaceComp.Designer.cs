namespace NhanDien
{
    partial class FaceComp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            camera = new PictureBox();
            picturecamera = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)camera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturecamera).BeginInit();
            SuspendLayout();
            // 
            // camera
            // 
            camera.Location = new Point(12, 12);
            camera.Name = "camera";
            camera.Size = new Size(1299, 627);
            camera.TabIndex = 0;
            camera.TabStop = false;
            // 
            // picturecamera
            // 
            picturecamera.Location = new Point(1601, 12);
            picturecamera.Name = "picturecamera";
            picturecamera.Size = new Size(618, 627);
            picturecamera.TabIndex = 1;
            picturecamera.TabStop = false;
            // 
            // FaceComp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2286, 667);
            Controls.Add(picturecamera);
            Controls.Add(camera);
            Name = "FaceComp";
            Text = "FaceComp";
            Load += FaceComp_Load;
            ((System.ComponentModel.ISupportInitialize)camera).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturecamera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox camera;
        private PictureBox picturecamera;
    }
}