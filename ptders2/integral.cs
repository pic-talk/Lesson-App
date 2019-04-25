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
    public partial class integral : Form
    {
        private bool mouse = false;
        SerialPort ShapeDisplayPort;
        SerialPort GlovePort;

        Bitmap imageBitmap;
        float stretch_X = 0;
        float stretch_Y = 0;

        public integral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => IntegralAnimation(1000));
        }

        public void IntegralAnimation(int sleep)
        {

            ShapeDisplayPort.Write(":00000000000000000000000000000000000000000000000000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            ShapeDisplayPort.Write(":00000000900000009000000090000000900000009000000090000000999999999&");
            System.Threading.Thread.Sleep(sleep);
            ShapeDisplayPort.Write(":00000000900000009000000099999999900000009000000090000000999999999&");
            System.Threading.Thread.Sleep(sleep);
            ShapeDisplayPort.Write(":00000000900000009000000099999999900900909009009090090090999999999&");
            System.Threading.Thread.Sleep(sleep);
            ShapeDisplayPort.Write(":00000000900000009000000099999999900999909009999090099990999999999&");
            System.Threading.Thread.Sleep(sleep);
            ShapeDisplayPort.Write(":00000000900000009000000099999999900999909009999090099990999999999&");
            System.Threading.Thread.Sleep(sleep);
        }

        public void setSerialPort(SerialPort portShapeDisplay, SerialPort portGlove)
        {
            ShapeDisplayPort = portShapeDisplay;
            GlovePort = portGlove;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                try
                {
                    var pixel = imageBitmap.GetPixel((int)(e.X * stretch_X), (int)(e.Y * stretch_Y));
                    Console.WriteLine(pixel.R.ToString() + "." + pixel.G + "." + pixel.B);
                    GlovePort.Write(pixel.R.ToString() + "/" + pixel.G + "/" + pixel.B + "/0" + "/0" + "/0" + ":");
                    System.Threading.Thread.Sleep(100);

                }
                catch
                {

                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void integral_Load(object sender, EventArgs e)
        {
            imageBitmap = new Bitmap(pictureBox1.Image);
            stretch_X = pictureBox1.Image.Width / (float)pictureBox1.Width;
            stretch_Y = pictureBox1.Image.Height / (float)pictureBox1.Height;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\integral.wav");
            player.Play();

        }

        private void sendGlove(Color pixel)
        {
            
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
