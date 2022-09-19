using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace MyEmgucv
{
    public partial class MainForm : Form
    {
        string m_imagePath;
        Image<Bgr, Byte> m_image;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGetImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // 顯示預設路徑。
            ofd.InitialDirectory = "./";
            // 設定檔案儲存類型範例為.bmp若要增加其他類型可使用{名稱}|.{類型}。
            ofd.Filter = "Bitmap Files|*.bmp";
            ofd.Title = "選擇影像檔案";
            // 紀錄最後視窗路徑位置。
            ofd.RestoreDirectory = true;
            // 顯示視窗，當按下確定(OK)時進入。
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 保存使用者選擇檔案的路徑位置
                m_imagePath = ofd.FileName;
                textBoxImagePath.Text = m_imagePath;
                // 讀取影像並顯示。
                DisplayImage(m_imagePath);
            }
        }

        private void DisplayImage(string path)
        {
            try
            {
                // 為 Bitmap 讀取方式。
                // Bitmap bitmap = new Bitmap(m_imagePath);
                // 該方法則為 EmguCV 的讀取方式。
                m_image = new Image<Bgr, byte>(path);
                pictureBoxDisplayImage.Image = (Bitmap)m_image.ToBitmap().Clone();
                pictureBoxDisplayImage.Invalidate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2GrayImage_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;

            Image<Gray, Byte> grayImage = new Image<Gray, Byte>(m_image.Width, m_image.Height, new Gray(255));
            //
            grayImage = m_image.Convert<Gray, Byte>();
            pictureBoxDisplayImage.Image = (Bitmap)grayImage.ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }
    }
}
