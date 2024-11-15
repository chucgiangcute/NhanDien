using System.Net.WebSockets;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using static System.Windows.Forms.DataFormats;

namespace NhanDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonwebcam_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Folder form2 = new Folder();
            form2.Show(); // Mở Form2
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private static Form1 instance;

        // Phương thức Singleton (GetInstance)
        public static Form1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }

        // Định nghĩa phương thức PrintError trong Form1
        public void PrintError(Exception ex)
        {
            // In thông báo lỗi vào Console hoặc Output window (Debug)
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }
    }
}
