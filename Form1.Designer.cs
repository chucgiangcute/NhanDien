namespace NhanDien
{
    partial class Form1
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
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            button5 = new Button();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            button6 = new Button();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            button7 = new Button();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(664, 318);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 193);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 14F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(283, 117);
            button2.Name = "button2";
            button2.Size = new Size(200, 65);
            button2.TabIndex = 2;
            button2.Text = "Version";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(250, 45);
            button1.Name = "button1";
            button1.Size = new Size(293, 70);
            button1.TabIndex = 1;
            button1.Text = "Face Comp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picture_chandung_copy;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(12, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 93);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.picture_sosanh;
            pictureBox2.Location = new Point(58, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(178, 23);
            button3.Name = "button3";
            button3.Size = new Size(327, 46);
            button3.TabIndex = 8;
            button3.Text = "Compare 2 face";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(12, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(548, 93);
            panel3.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 12F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(202, 21);
            button4.Name = "button4";
            button4.Size = new Size(304, 46);
            button4.TabIndex = 9;
            button4.Text = "Webcam realtime";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.picture_webcam;
            pictureBox3.Location = new Point(58, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(12, 391);
            panel4.Name = "panel4";
            panel4.Size = new Size(548, 93);
            panel4.TabIndex = 9;
            // 
            // button5
            // 
            button5.BackColor = Color.MidnightBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 12F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(213, 21);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 10;
            button5.Text = "Persons";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.person;
            pictureBox4.Location = new Point(58, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Controls.Add(button6);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(12, 484);
            panel5.Name = "panel5";
            panel5.Size = new Size(548, 93);
            panel5.TabIndex = 10;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 12F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(185, 25);
            button6.Name = "button6";
            button6.Size = new Size(308, 46);
            button6.TabIndex = 11;
            button6.Text = "Search in folder";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.picture_folder;
            pictureBox5.Location = new Point(58, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 87);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MidnightBlue;
            panel6.Controls.Add(button7);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(12, 577);
            panel6.Name = "panel6";
            panel6.Size = new Size(548, 90);
            panel6.TabIndex = 11;
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Tahoma", 12F);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(211, 20);
            button7.Name = "button7";
            button7.Size = new Size(150, 46);
            button7.TabIndex = 12;
            button7.Text = "Settings";
            button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.picture_settings;
            pictureBox6.Location = new Point(58, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 81);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 709);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Phần mềm nhận diện khuôn mặt";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button3;
        private Panel panel3;
        private Button button4;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Button button5;
        private Panel panel5;
        private Button button6;
        private PictureBox pictureBox5;
        private Panel panel6;
        private Button button7;
        private PictureBox pictureBox6;
    }
}
