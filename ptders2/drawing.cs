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
    public partial class drawing : Form
    {
        bool painting = false;
        int pencil_thickness;

        SolidBrush color;
        public Bitmap palette;

        private bool check = false;


        private Bitmap _image;
        private int _count = 8;
        private int _size = 50;
        private bool[,] _pixels;

        private List<Tuple<int, int>> mouseovercoordinates = new List<Tuple<int, int>>();


        SerialPort displayPort;
        private SerialPort glovePort;
        private bool mouse;
        private List<string> serial_buffer;
        private string buffer;
        private bool clickchecked = false;

        public drawing()
        {
            InitializeComponent();
            palette = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g = Graphics.FromImage(palette);
            color = new SolidBrush(Color.White);
            g.FillRectangle(color, 0, 0, pictureBox1.Size.Height, pictureBox1.Size.Width);
            pictureBox1.Image = palette;


            comboBox2.SelectedItem = "Green";
            trackBar1.Value = 2;
            SetPic();

            _image = new Bitmap(pictureBox2.Size.Width, pictureBox2.Size.Height);
            pictureBox2.Image = _image;
            _pixels = new bool[_count, _count];
            ShowGrid();

            timer1.Interval = 500;

        }

        #region BUTON_EVENTLERİ

        private void button_ayarla_Click(object sender, EventArgs e)
        {
            check = true;
            SetPic();
        }

        private void button_silgi_Click(object sender, EventArgs e)
        {
            color = new SolidBrush(Color.White);
            MessageBox.Show("Silgi seçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            Graphics g;
            //pictureBox1.CreateGraphics()
            g = Graphics.FromImage(pictureBox1.Image);
            // pictureBox1.Image.Save(@"C:\Users\Musa\Documents\Visual Studio 2013\Projects\WindowsFormsApplication14\WindowsFormsApplication14\bin\Debug\kayıtlı resimler\bb.jpeg", ImageFormat.Jpeg);
            check = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Transparent);
            }
            pictureBox1.Invalidate();
        } //Tüm hepsini sil

        
        

        #endregion

        #region MOUSE EVENTLERİ

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            painting = true;
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            painting = false;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (painting && check)
                {
                    Graphics g = Graphics.FromImage(palette);
                    g.FillEllipse(color, e.X, e.Y, pencil_thickness * 10, pencil_thickness * 10);
                    pictureBox1.Image = palette;
                    Console.WriteLine(palette.GetPixel(e.X, e.Y).R + "," + palette.GetPixel(e.X, e.Y).B + palette.GetPixel(e.X, e.Y).G);
                }
                if (painting && !check)
                {
                    //  Console.WriteLine(palette.GetPixel(e.X, e.Y).R + "," + palette.GetPixel(e.X, e.Y).B + palette.GetPixel(e.X, e.Y).G);

                   
                    if (((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y).G == 128)
                    {
                        Console.WriteLine("0/255/0/0/0/0");
                        glovePort.WriteLine("0/255/0/0/0/0");
                    }    


                }
            }
            catch 
            {

            }
            
        }

        #endregion

        #region METODLAR

        public void SetPic()
        {
            string renk = comboBox2.SelectedItem.ToString();
            if (renk == "Red")
            {
                color = new SolidBrush(Color.Red);
            }
            if (renk == "Green")
            {
                color = new SolidBrush(Color.Green);
            }
            if (renk == "Blue")
            {
                color = new SolidBrush(Color.Blue);
            }

            pencil_thickness = trackBar1.Value;

        }

    

        public void setSerialPort(SerialPort port, SerialPort port2)
        {
            displayPort = port;
            glovePort = port2;
        }

        #endregion

        private void SetPixel(int x, int y, bool? on = null)
        {
            try
            {
                Graphics g = Graphics.FromImage(_image);
                Color color;

                if (on.HasValue)
                {
                    _pixels[x, y] = on.Value;
                }
                else
                {
                    _pixels[x, y] = !_pixels[x, y];
                }

                if (_pixels[x, y])
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.White;
                }

                // SendToArduino((byte)x, (byte)y, _pixels[x, y]);
                Brush brush = new SolidBrush(color);
                g.FillRectangle(brush, x * _size + 1, y * _size + 1, _size - 1, _size - 1);

                if (pictureBox2.InvokeRequired)
                {
                    pictureBox2.Invoke((Action)(() => pictureBox2.Refresh()));
                }
                else
                {
                    pictureBox2.Refresh();
                }
            }
            catch
            {

            }
            
        }


        private void ShowGrid()
        {
            Graphics g = Graphics.FromImage(_image);
            Pen pen = new Pen(Color.Black);
            for (int i = 0; i <= _count; i++)
            {
                g.DrawLine(pen, i * _size, 0, i * _size, _image.Height);
                g.DrawLine(pen, 0, i * _size, _image.Width, i * _size);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
          

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                var asf = new Tuple<int, int>(e.X / _size, e.Y / _size);
                if (!mouseovercoordinates.Contains(asf))
                {
                    mouseovercoordinates.Add(new Tuple<int, int>(e.X / _size, e.Y / _size));
                    SetPixel(e.X/_size, e.Y/_size);
                   
                }
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseovercoordinates.Clear();
            mouse = false;
            clickchecked = false;
            
        }

        
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (!clickchecked)
            {
                int x = e.X / _size;
                int y = e.Y / _size;
                SetPixel(x, y);
                timer1.Stop();
                clickchecked = false;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serial_buffer = new List<string>();
                buffer = ":0";


                for (int i = 7; i >= 0; i--)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        buffer += (Convert.ToInt16(_pixels[i, k]) * 8).ToString();
                    }
                }
                buffer += "&";
                displayPort.Write(buffer);

            }

            catch { }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 7; i >= 0; i--)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        SetPixel(i, k,false);
                    }
                }

                displayPort.Write(":00000000000000000000000000000000000000000000000000000000000000000&");
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clickchecked = true;
        }
    }
}
