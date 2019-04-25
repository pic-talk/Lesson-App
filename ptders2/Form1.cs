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
using System.Management;

namespace ptders2
{
    public partial class Form1 : Form
    {
        Bitmap imageBitmap;
        float stretch_X;
        float stretch_Y;
        bool mouse = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e) // Integral
        {
            var integralPage = new integral();
            integralPage.setSerialPort(serialPort1,serialPort2);
            integralPage.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {/*
            var integralPage = new integral();
            integralPage.setSerialPort(serialPort1);
            integralPage.Show();*/
        }

        private void button_baglan_Click(object sender, EventArgs e)
        {
            if (button_baglan.Text == "Connect")
            {
                if (comboBox_seriport.Text != "")
                {

                    try
                    {
                        serialPort1.BaudRate = 115200;
                        serialPort1.PortName = comboBox_seriport.Text;
                        serialPort1.Open();
                        button_baglan.Text = "Disconnect";
                        label_seridurum.Text = "Connected";
                        label_seridurum.ForeColor = Color.Green;
                        button_baglan.ForeColor = Color.Red;
                        Task.Run(() => resetDevice());
                         toolStripStatusLabel_com.Text = serialPort1.PortName;

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
            }

            else
            {
                try
                {
                    serialPort1.Write(":ax&");
                    serialPort1.Close();
                    button_baglan.Text = "Connect";
                    label_seridurum.Text = "No Connection";
                    label_seridurum.ForeColor = Color.Red;
                    button_baglan.ForeColor = Color.Green;

                }
                catch (Exception)
                {

                }

            }
        }

        private void resetDevice()
        {
            System.Threading.Thread.Sleep(1000);
            serialPort1.Write(":08888888888888888888888888888888888888888888888888888888888888888&");
            System.Threading.Thread.Sleep(5000);
            serialPort1.Write(":00000000000000000000000000000000000000000000000000000000000000000&");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            imageBitmap = new Bitmap(pictureBox7.Image);
            stretch_X = pictureBox7.Image.Width / (float)pictureBox7.Width;
            stretch_Y = pictureBox7.Image.Height / (float)pictureBox7.Height;

            foreach (var item in SerialPort.GetPortNames())  //Installing Serial Ports to Program
            {
                comboBox_seriport.Items.Add(item);
                comboBox2.Items.Add(item);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var fractionPage = new fraction();
            fractionPage.setSerialPort(serialPort1);
            fractionPage.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           /* var circuitPage = new circuits();
            circuitPage.setSerialPort(serialPort1);
            circuitPage.Show();*/
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);
            textBox1.Text = "";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                richTextBox1.Text += "Serial:ID1: " + serialPort1.ReadLine();

            }
            catch { }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Connect")
            {
                if (comboBox2.Text != "")
                {
                    
                    try
                    {
                        serialPort2.BaudRate = 9600;
                        serialPort2.PortName = comboBox2.Text;
                        serialPort2.Open();
                        button2.Text = "Disconnect";
                        label9.Text = "Connected";
                        label9.ForeColor = Color.Green;
                        button2.ForeColor = Color.Red;
                      toolStripStatusLabel_com.Text = serialPort2.PortName;

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
            }

            else
            {
                try
                {
                    serialPort2.Write(":ax&");
                    serialPort2.Close();
                    button2.Text = "Connect";
                    label9.Text = "No Connection";
                    label_seridurum.ForeColor = Color.Red;
                    button2.ForeColor = Color.Green;

                }
                catch (Exception)
                {

                }

            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            richTextBox1.Text += "Serial:ID2: " + serialPort2.ReadLine();
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            comboBox_seriport.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())  //Installing Serial Ports to Program
            {
                comboBox_seriport.Items.Add(item);
               
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            circuit circuitPage = new circuit();
            circuitPage.setSerial(serialPort1);
            circuitPage.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                try
                {
                    var pixel = imageBitmap.GetPixel((int)(e.X * stretch_X), (int)(e.Y * stretch_Y));
                    Console.WriteLine(pixel.R.ToString() + "." + pixel.G + "." + pixel.B);
                    label15.Text = pixel.R.ToString() + "." + pixel.G + "." + pixel.B;

                    serialPort2.Write(pixel.R.ToString() + "/" + pixel.G + "/" + pixel.B + "/0" + "/0" + "/0" + ":");
                    System.Threading.Thread.Sleep(100);

                }
                catch
                {

                }
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            var integralPage = new integral();
            integralPage.setSerialPort(serialPort1, serialPort2);
            integralPage.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var fractionPage = new fraction();
            fractionPage.setSerialPort(serialPort1);
            fractionPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shapes shapesPage = new shapes();
            shapesPage.setSerialPort(serialPort1,serialPort2);
            shapesPage.Show();
        }

        private void label_math_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            drawing drawPage = new drawing();
            drawPage.setSerialPort(serialPort1);
            drawPage.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            colors colorPage = new colors();
            colorPage.setSerialPort(serialPort2);
            colorPage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            shapes shapesPage = new shapes();
            shapesPage.setSerialPort(serialPort1,serialPort2);
            shapesPage.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            circuit circuitPage = new circuit();
            circuitPage.setSerial(serialPort1);
            circuitPage.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
