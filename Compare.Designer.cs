namespace NhanDien
{
    partial class Compare
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
            panel1 = new Panel();
            picturecamera = new PictureBox();
            picturesample = new PictureBox();
            btnchup = new Button();
            btnsosanh = new Button();
            ((System.ComponentModel.ISupportInitialize)camera).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturecamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturesample).BeginInit();
            SuspendLayout();
            // 
            // camera
            // 
            camera.Location = new Point(42, 36);
            camera.Name = "camera";
            camera.Size = new Size(1131, 1115);
            camera.TabIndex = 0;
            camera.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(picturesample);
            panel1.Controls.Add(picturecamera);
            panel1.Location = new Point(1277, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 1115);
            panel1.TabIndex = 1;
            // 
            // picturecamera
            // 
            picturecamera.Location = new Point(45, 31);
            picturecamera.Name = "picturecamera";
            picturecamera.Size = new Size(922, 520);
            picturecamera.TabIndex = 0;
            picturecamera.TabStop = false;
            // 
            // picturesample
            // 
            picturesample.Location = new Point(45, 604);
            picturesample.Name = "picturesample";
            picturesample.Size = new Size(922, 469);
            picturesample.TabIndex = 1;
            picturesample.TabStop = false;
            // 
            // btnchup
            // 
            btnchup.Location = new Point(189, 1199);
            btnchup.Name = "btnchup";
            btnchup.Size = new Size(150, 46);
            btnchup.TabIndex = 2;
            btnchup.Text = "Chụp ảnh";
            btnchup.UseVisualStyleBackColor = true;
            // 
            // btnsosanh
            // 
            btnsosanh.Location = new Point(628, 1199);
            btnsosanh.Name = "btnsosanh";
            btnsosanh.Size = new Size(150, 46);
            btnsosanh.TabIndex = 3;
            btnsosanh.Text = "So sánh";
            btnsosanh.UseVisualStyleBackColor = true;
            // 
            // Compare
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2350, 1304);
            Controls.Add(btnsosanh);
            Controls.Add(btnchup);
            Controls.Add(panel1);
            Controls.Add(camera);
            Name = "Compare";
            Text = "Compare";
            Load += Compare_Load;
            ((System.ComponentModel.ISupportInitialize)camera).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturecamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturesample).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox camera;
        private Panel panel1;
        private PictureBox picturesample;
        private PictureBox picturecamera;
        private Button btnchup;
        private Button btnsosanh;
    }
}