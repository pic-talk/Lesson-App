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
    public partial class fraction : Form
    {
        SerialPort sameport;

        public fraction()
        {
            InitializeComponent();
        }

        public void setSerialPort(SerialPort port)
        {
            sameport = port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sleep = 1000;
            Task.Run(() => gauss(sleep));

        }

        public void gauss(int sleep)
        {
            sameport.Write(":00000000000000000000000000000000000000000000000000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000000000009000000000000000000000000000000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000000000009000000099000000000000000000000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000000000009000000099000000999000000000000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000000000009000000099000000999000009999000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000333300009000000099000000999000009999000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000333300009333000099000000999000009999000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000333300009333000099330000999000009999000000000000000000&");
            System.Threading.Thread.Sleep(sleep);
            sameport.Write(":00000000000333300009333000099330000999300009999000000000000000000&");

        }

        private void fraction_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"files\gauss.wav");
            player.Play();
        }
    }
}
