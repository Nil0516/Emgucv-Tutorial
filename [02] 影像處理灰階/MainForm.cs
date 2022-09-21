using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            ofd.Filter = "Bitmap Files|*.bmp|JPG Files|*.jpg|PNG Files|*.png";
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
                m_image = DisplayImageFromPath(m_imagePath);
                pictureBoxDisplayImage.Image = (Bitmap)m_image.ToBitmap().Clone();
            }
        }

        #region 影像處理(元件)
        private void button2GrayImage_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;

            pictureBoxDisplayImage.Image = (Bitmap)ChanneConvert1(m_image, EColorType.Gray).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonChannelBlue_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;
            
            pictureBoxDisplayImage.Image = (Bitmap)ChanneConvert1(m_image, EColorType.Blue).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonChannelGreen_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;

            pictureBoxDisplayImage.Image = (Bitmap)ChanneConvert1(m_image, EColorType.Green).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonChannelRed_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;

            pictureBoxDisplayImage.Image = (Bitmap)ChanneConvert1(m_image, EColorType.Red).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonKeepBlue_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;

            pictureBoxDisplayImage.Image = (Bitmap)ChannelReduce1(m_image, EColorType.Blue).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonKeepGreen_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;

            pictureBoxDisplayImage.Image = (Bitmap)ChannelReduce1(m_image, EColorType.Green).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonKeepRed_Click(object sender, EventArgs e)
        {
            if (m_image == null) return;
            pictureBoxDisplayImage.Image = (Bitmap)ChannelReduce1(m_image, EColorType.Red).ToBitmap().Clone();
            pictureBoxDisplayImage.Invalidate();
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            // "./" 代表當前路徑
            // 後面名稱需附上副檔名
            if (SaveImage((Bitmap)pictureBoxDisplayImage.Image, "./", "save_image.bmp") == true)
            {
                MessageBox.Show("保存影像成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("保存影像失敗。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Function
        private Image<Bgr, byte> DisplayImageFromPath(string path)
        {
            try
            {
                return new Image<Bgr, byte>(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new NullReferenceException("請檢查檔案影像是否正常。");
            }
        }

        private Image<Bgr, Byte> ChannelReduce1(Image<Bgr, Byte> a_bitmap, EColorType a_type)
        {
            if (a_bitmap == null)
            {
                throw new NullReferenceException("影像不得為空。");
            }

            Image<Bgr, Byte> convertImage;

            // 顏色轉換
            switch (a_type)
            {
                case EColorType.Blue:
                    convertImage = a_bitmap.Sub(new Bgr(0, 255, 255)).Clone();
                    break;
                case EColorType.Green:
                    convertImage = a_bitmap.Sub(new Bgr(255, 0, 255)).Clone();
                    break;
                case EColorType.Red:
                    convertImage = a_bitmap.Sub(new Bgr(255, 255, 0)).Clone();
                    break;
                default:
                    throw new NullReferenceException("無其他類型。");
            }

            return convertImage;
        }

        private Image<Gray, Byte> ChanneConvert1(Image<Bgr, Byte> a_bitmap, EColorType a_type)
        {
            if (a_bitmap == null)
            {
                throw new NullReferenceException("影像不得為空。");
            }

            Image<Gray, Byte> convertImage;

            // 顏色轉換
            switch (a_type)
            {
                case EColorType.Blue:
                    convertImage = a_bitmap[0].Clone();
                    break;
                case EColorType.Green:
                    convertImage = a_bitmap[1].Clone();
                    break;
                case EColorType.Red:
                    convertImage = a_bitmap[2].Clone();
                    break;
                case EColorType.Gray:
                    //convertImage = new Image<Gray, Byte>(m_image.Width, m_image.Height, new Gray(255));
                    convertImage = a_bitmap.Convert<Gray, Byte>().Clone();
                    break;
                default:
                    throw new NullReferenceException("無其他類型。");
            }

            return convertImage;
        }

        private bool SaveImage(Bitmap a_image, string a_path, string a_fileName)
        {
            try
            {
                a_image.Save($"{a_path}/{a_fileName}");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }

    public enum EColorType
    {
        Blue = 0,
        Green,
        Red,
        Gray
    }
}
