using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageResize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "PNG images (*.png) | *.png";
            if(od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = od.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int width = 1366;
            int height = 768;
            Image img = pictureBox1.Image;
            Image newSizeImg = ResizeImage(img, width, height);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "PNG images (*.png) | *.png";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                newSizeImg.Save(sd.FileName);
            }
            img.Dispose();
            newSizeImg.Dispose();
        }

        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
