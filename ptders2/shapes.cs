using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptders2
{
    public partial class shapes : Form
    {
        SerialPort serialportShapeDisplay;
        SerialPort serialPortGlove; 
   
        bool mouse = false;
        Bitmap imageBitmap;
        float stretch_X = 0;
        float stretch_Y = 0;


        public shapes()
        {
            InitializeComponent();
        }

        private void shapes_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(ptders2.Properties.Resources.like__1_);
            pictureBox1.Image = (Image)bmp;

            imageBitmap = new Bitmap(pictureBox1.Image);
            stretch_X = pictureBox1.Image.Width / (float)pictureBox1.Width;
            stretch_Y = pictureBox1.Image.Height / (float)pictureBox1.Height;

        }

        public void setSerialPort(SerialPort portDisplay, SerialPort portGlove)
        {
            serialportShapeDisplay = portDisplay;
            serialPortGlove = portGlove;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(ptders2.Properties.Resources.square1);
                pictureBox1.Image = (Image)bmp;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\square.wav");
                player.Play();
                serialportShapeDisplay.Write(":00000000000000000009999000090090000900900009999000000000000000000&");
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(ptders2.Properties.Resources.add__1_);
                pictureBox1.Image = (Image)bmp;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\plus.wav");
                player.Play();
                serialportShapeDisplay.Write(":00009900000099000000990009999999999999999000990000009900000099000&");

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(ptders2.Properties.Resources.triangle__1_);
                pictureBox1.Image = (Image)bmp;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\triangle.wav");
                player.Play();
                serialportShapeDisplay.Write(":00000000000000000000000000009900000900900090000909999999900000000&");
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(ptders2.Properties.Resources.oval__1_);
                pictureBox1.Image = (Image)bmp;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\circle.wav");
                player.Play();
                serialportShapeDisplay.Write(":00099990009000090900000099000000990000009990000090990009000999900&");
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(ptders2.Properties.Resources.rectangle__1_);
                pictureBox1.Image = (Image)bmp;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\rectangle.wav");
                player.Play();
                serialportShapeDisplay.Write(":00000000000000000099999900900009009000090099999900000000000000000&"); 
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(ptders2.Properties.Resources.like__1_);
                pictureBox1.Image = (Image)bmp;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\heart.wav");
                player.Play();
                serialportShapeDisplay.Write(":00990099099999999999999999999999909999990009999000009900000000000&");
            }
            catch
            {

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                calculateStretch(pictureBox1);
                try
                {
                    var pixel = imageBitmap.GetPixel((int)(e.X * stretch_X), (int)(e.Y * stretch_Y));
                    if((pixel.R != 0 &&pixel.G!=0 && pixel.B != 0))
                    {
                        Console.WriteLine(pixel.R.ToString() + "." + pixel.G + "." + pixel.B);
                        serialPortGlove.Write("255" + "/" + "0"+ "/" + "0"+ "/0" + "/0" + "/0" + ":");
                        System.Threading.Thread.Sleep(100);
                    }

                }
                catch
                {

                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void calculateStretch(PictureBox pt)
        {
            imageBitmap = new Bitmap(pictureBox1.Image);
            stretch_X = pictureBox1.Image.Width / (float)pictureBox1.Width;
            stretch_Y = pictureBox1.Image.Height / (float)pictureBox1.Height;
        }
    }
}
