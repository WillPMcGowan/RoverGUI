using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARUDINOGUI
{
    public partial class ArduinoGUI : Form
    {

        public delegate void d1(string indata);
        private static int counter;
        public ArduinoGUI()
        {
            InitializeComponent();
            serialPort1.Open();
        }
        private void forward_click(object sender, EventArgs e)
        {
            //move forward
            serialPort1.Write("F");
        }

        private void right_click(object sender, EventArgs e)
        {
            // turn right
            serialPort1.Write("R");
        }
        //turn left
        private void left_click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
        }
        //stop
        private void stop_click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
        }
        private void back_click(object sender, EventArgs e)
        {
            //back
            string m1 = "B" + waterDetected.Text;
            serialPort1.Write(m1);
        }


        private void usd_Click(object sender, EventArgs e)
        {
            // send val
            string m1 = "D" + waterDetected.Text;
            serialPort1.Write(m1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            serialPort1.ReadExisting();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = serialPort1.ReadLine();
            d1 writeit = new d1(Write2form);
            Invoke(writeit, indata);
        }

        private void Write2form(string indata)
        {
            //function handles data sent form aurduino
            char firstchar;
            Single numdata;
            Single waterlevel;
            firstchar = indata[0];
            firstchar = indata[0];

            switch (firstchar)
            {
                case 'w':
                    numdata = Convert.ToSingle(indata.Substring(1));
                    waterlevel = numdata/10;
                    textBox3.Text = String.Format("{0:0.00 }", waterlevel);
                    if (waterlevel > 5)
                    {
                        serialPort1.Write("S");
                        waterDetected.BackColor = Color.Red;
                        waterDetected.Text = "WATER DETECTED";
                    }
                    else
                    {
                        waterDetected.Text = "No water";
                        waterDetected.BackColor = Color.Green;
                    }
                    break;
            }



        }




        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Control_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
