using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NhanDien
{
    public partial class FaceComp : Form
    {
        private VideoCapture _capture;  // Đối tượng để lấy video từ camera
        private CascadeClassifier _faceCascade; // Đối tượng để nhận diện khuôn mặt

        public FaceComp()
        {
            
            InitializeComponent();

            // Đường dẫn đến file haarcascade_frontalface_default.xml
            string faceCascadePath = @"C:\Users\Admin\Desktop\Ảnh chân dung"; // Thay đường dẫn cho đúng
           // string faceCascadePath = "C:\\Users\\Admin\\Desktop\\Ảnh chân dung; // Đảm bảo đường dẫn đúng

            // Khởi tạo CascadeClassifier
            _faceCascade = new CascadeClassifier(faceCascadePath);

            // Khởi tạo camera
            _capture = new VideoCapture(0); // Sử dụng camera mặc định
            _capture.ImageGrabbed += Capture_ImageGrabbed; // Gắn sự kiện
            _capture.Start(); // Bắt đầu lấy hình ảnh từ camera
        }

        // Sự kiện khi hình ảnh mới được lấy từ camera
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            _capture.Retrieve(frame); // Lấy khung hình từ camera

            if (frame.IsEmpty) return;

            // Chuyển đổi khung hình thành ảnh xám (grayscale) để tăng hiệu quả nhận diện
            var grayFrame = frame.ToImage<Gray, byte>();

            // Nhận diện khuôn mặt
            var faces = _faceCascade.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty);

            // Kiểm tra nếu có khuôn mặt được nhận diện
            if (faces.Length > 0)
            {
                // Vẽ các hình chữ nhật xung quanh khuôn mặt
                foreach (var face in faces)
                {
                    CvInvoke.Rectangle(frame, face, new MCvScalar(0, 0, 255)); // Vẽ hình chữ nhật đỏ quanh khuôn mặt
                }

                // Hiển thị thông báo "Thành công"
                MessageBox.Show ("Điểm danh thành công !"); // lblStatus là Label hiển thị trạng thái
            }
            else
            {
                // Nếu không phát hiện khuôn mặt, hiển thị "Không phát hiện khuôn mặt"
                MessageBox.Show( "Điểm danh không thành công !");
            }

            // Hiển thị khung hình đã xử lý trong PictureBox
            picturecamera.Image = frame.ToBitmap();
        }

        // Dừng camera khi đóng form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Stop();
                _capture.Dispose();
            }
            base.OnFormClosed(e);
        }

        private void FaceComp_Load(object sender, EventArgs e)
        {

        }
    }
}
