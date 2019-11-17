using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLedControllerInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox1.Text;
            textBox1.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Properties.Resources.green_led_off_hi;
            } else
            {
                pictureBox1.Image = Properties.Resources.white_led_off_md;
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

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

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
            if (checkBox2.Checked)
            {
                pictureBox2.Image = Properties.Resources.green_led_off_hi;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.white_led_off_md;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pictureBox3.Image = Properties.Resources.green_led_off_hi;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.white_led_off_md;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
  
    }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox11.BackColor = Color.Green;
                textBox11.Text = "ON";

            } else 
            {
                textBox11.BackColor = Color.Red;
                textBox11.Text = "OFF";

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
    }
}
