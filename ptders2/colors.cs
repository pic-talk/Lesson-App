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

        public colors()
        {
            InitializeComponent();
        }

        private void colors_Load(object sender, EventArgs e)
        {

        }

        public void setSerialPort(SerialPort port)
        {
            serialport = port;
        }
    }
}
