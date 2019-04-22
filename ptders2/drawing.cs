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


        SerialPort sameport;

        public drawing()
        {
            InitializeComponent();
            palette = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g = Graphics.FromImage(palette);
            color = new SolidBrush(Color.White);
            g.FillRectangle(color, 0, 0, pictureBox1.Size.Height, pictureBox1.Size.Width);
            pictureBox1.Image = palette;


            comboBox2.SelectedItem = "Yeşil";
            trackBar1.Value = 2;
            SetPic();

       
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
                        sameport.WriteLine("0/255/0/0/0/0");
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
            if (renk == "Kırmızı")
            {
                color = new SolidBrush(Color.Red);
            }
            if (renk == "Yeşil")
            {
                color = new SolidBrush(Color.Green);
            }
            if (renk == "Mavi")
            {
                color = new SolidBrush(Color.Blue);
            }

            pencil_thickness = trackBar1.Value;

        }

    

        public void setSerialPort(SerialPort port)
        {
            sameport = port;
        }

        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void drawing_Load(object sender, EventArgs e)
        {

        }

        
    }
}
