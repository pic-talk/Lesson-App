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
    public partial class circuits : Form
    {

        SerialPort serialport;

        public circuits()
        {
            InitializeComponent();
        }

        private void circuits_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialport.Write(":09999999990000009900000099000000990000009909090099990999900909000&");

        }

        public void setSerialPort(SerialPort port)
        {
            serialport = port;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialport.Write(":09990099990000009900000099000000990000009909090099990999900909000&");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialport.Write(":09999999990000009900000099000000990000009909090099990999900909000&");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialport.Write(":09999999990000009999999999000000990000009909090099990999900909000&");
        }
    }
}
