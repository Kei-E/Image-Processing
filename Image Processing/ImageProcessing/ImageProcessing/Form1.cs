using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadImage, resultImage;
        Device[] myDevices;

        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            display1.Image = loadImage;
        }

        private void grey_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            //Explore all pixel
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    int grey = (pixel.R + pixel.R + pixel.B) / 3;

                    resultImage.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }

            display2.Image = resultImage;
        }

        private void Invert_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            //Explore all pixel
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);

                    resultImage.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }

            display2.Image = resultImage;
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            //Explore all pixel
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    int grey = (pixel.R + pixel.R + pixel.B) / 3;

                    resultImage.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }

            Color sample;
            int[] histData = new int[256];

            //Explore all pixel
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    sample = resultImage.GetPixel(i, j);    //0-255 either r,g, or b
                    
                    histData[sample.R]++;
                }

            Bitmap myData = new Bitmap(256, 800);

            //Explore all pixel
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 800; j++)
                {
                    myData.SetPixel(i, j, Color.White);
                }

            //Plot histogram data
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < Math.Min(histData[i]/5, 800); j++)
                {
                    myData.SetPixel(i, 799-j, Color.Black);
                }

            display2.Image = myData;
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void Sepia_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    int tRed = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tGreen = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tBlue = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    int r = 0;
                    int g = 0;
                    int b = 0;

                    //set new RGB value
                    if (tRed > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tRed;
                    }

                    if (tGreen > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tGreen;
                    }

                    if (tBlue > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tBlue;
                    }

                    //set the new RGB value in image pixel
                    resultImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

            display2.Image = resultImage;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDevices = DeviceManager.GetAllDevices();
        }

        private void OnCam_Click(object sender, EventArgs e)
        {
            myDevices[0].ShowWindow(display1);  //First Device Listed will show
        }

        private void OffCam_Click(object sender, EventArgs e)
        {
            myDevices[0].Stop();    //First Device Listed will stop
        }

        private void greyscale_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            resultImage = new Bitmap(b.Width, b.Height);

            //Explore all pixel
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color pixel = b.GetPixel(i, j);
                    int grey = (pixel.R + pixel.R + pixel.B) / 3;

                    resultImage.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }

            display2.Image = resultImage;
        }

        private void OffGreyscale_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);
            BitmapFilter.Sphere(b, false);  //Bitmap is controlled by the pointer

            display2.Image = b;
        }

        private void POffGrey_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void POnGrey_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            //Explore all pixel
            for(int i = 0; i < loadImage.Width; i++)
                for(int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    
                    resultImage.SetPixel(i, j, pixel);
                }

            display2.Image = resultImage;
        }
    }
}
