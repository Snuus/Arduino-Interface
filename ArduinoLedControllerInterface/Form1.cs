using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoLedControllerInterface
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
      

        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();
            radioButton2.Checked = true;
            radioButton4.Checked = true;
            radioButton6.Checked = true;

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (isConnected)
            {
                port.Write("#TEXT" + textBox1.Text + "#\n");
                textBox9.Text = textBox1.Text;
                textBox1.Clear();
            }
        }


        private void enableControls()
        {
            checkBox1.Enabled = true;
            textBox1.Enabled = true;
            connectbutton.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
        }


        private void disableControls()
        {
            checkBox1.Enabled = false;
            textBox1.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (isConnected)
            {

                if (checkBox1.Checked)
                {
                    port.Write("#LED1ON\n");
                    pictureBox1.Image = Properties.Resources.green_led_off_hi;
                }
                else
                {
                    port.Write("#LED1OF\n");
                    pictureBox1.Image = Properties.Resources.white_led_off_md;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTiptext_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.Red;
            textBox11.Text = "OFF";
            progressBar1.Value = +(int)numericUpDown1.Minimum;
            numericUpDown1.Value = 0;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.Red;
            textBox12.Text = "OFF";
            progressBar2.Value = +(int)numericUpDown1.Minimum;
            numericUpDown2.Value = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox2.Checked)
                {
                    port.Write("#LED2ON\n");
                    pictureBox2.Image = Properties.Resources.green_led_off_hi;
                }
                else
                {
                    port.Write("#LED2OF\n");
                    pictureBox2.Image = Properties.Resources.white_led_off_md;
                }

            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox3.Checked)
                {
                    port.Write("#LED3ON\n");
                    pictureBox3.Image = Properties.Resources.green_led_off_hi;
                }
                else
                {
                    port.Write("#LED3OF\n");
                    pictureBox3.Image = Properties.Resources.white_led_off_md;
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
  
    }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            port.Write("#STAR\n");


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox11.BackColor = Color.Green;
                textBox11.Text = "ON";
                progressBar1.Value = +(int)numericUpDown1.Minimum;
            } else 
            {
                textBox11.BackColor = Color.Red;
                textBox11.Text = "OFF";
                progressBar1.Value = +(int)numericUpDown1.Minimum;
                numericUpDown1.Value = 0;

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox12.BackColor = Color.Green;
                textBox12.Text = "ON";

            }
            else
            {
                textBox12.BackColor = Color.Red;
                textBox12.Text = "OFF";

            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                textBox13.BackColor = Color.Green;
                textBox13.Text = "ON";

            }
            else
            {
                textBox13.BackColor = Color.Red;
                textBox13.Text = "OFF";

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = +(int)numericUpDown1.Value;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.Red;
            textBox13.Text = "OFF";
            progressBar3.Value = +(int)numericUpDown1.Minimum;
            numericUpDown3.Value = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar2.Value = +(int)numericUpDown2.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar3.Value = +(int)numericUpDown3.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }else
            {
                disconnectFromArduino();
            }
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            connectbutton.Text = "Connect";
            disableControls();
            //resetDefaults();
            

        }


        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            connectbutton.Text = "Disconnect";
            enableControls();
        }
    }
}
