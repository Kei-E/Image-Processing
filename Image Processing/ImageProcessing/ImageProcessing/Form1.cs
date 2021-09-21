using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadImage, resultImage;

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
                for (int j = 0; j < histData[i]/5; j++)
                {
                    myData.SetPixel(i, j, Color.Black);
                }

            display2.Image = myData;
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
