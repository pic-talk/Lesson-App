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
    public partial class colors : Form
    {
        SerialPort serialport;
        bool mouse = false;
        Bitmap imageBitmap;
        float stretch_X;
        float stretch_Y;

        public colors()
        {
            InitializeComponent();
        }

        private void colors_Load(object sender, EventArgs e)
        {
            imageBitmap = new Bitmap(pictureBox1.Image);
            stretch_X = pictureBox1.Image.Width / (float)pictureBox1.Width;
            stretch_Y = pictureBox1.Image.Height / (float)pictureBox1.Height;
        }

        public void setSerialPort(SerialPort port)
        {
            serialport = port;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                try
                {
                    var pixel = imageBitmap.GetPixel((int)(e.X * stretch_X), (int)(e.Y * stretch_Y));
                    Console.WriteLine(pixel.R.ToString() + "." + pixel.G + "." + pixel.B);
                    serialport.Write(pixel.R.ToString() + "/" + pixel.G + "/" + pixel.B + "/0" + "/0" + "/0" + ":");
                    System.Threading.Thread.Sleep(100);

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
    }
}
