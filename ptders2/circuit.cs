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
    public partial class circuit : Form
    {
        SerialPort serialport;
        public circuit()
        {
            InitializeComponent();
        }

        public void setSerial(SerialPort port)
        {
            serialport = port;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write(":09999999990000009900000099000000990000009909090099990999900909000&");
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                serialport.Write(":09999999990000009999999999000000990000009909090099990999900909000&");
            }
            catch
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                serialport.Write(":09900099990000009900000099000000990000009909090099990999900909000&");
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                serialport.Write(":09999999990000009900000099000000990000009909090099990999900909000&");
            }
            catch
            {

            }

        }
    }
}
