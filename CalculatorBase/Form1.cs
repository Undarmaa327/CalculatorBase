using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBase
{
    public partial class Form1 : Form
    {

        double result = 0;
        double s = 0;
        string operation = "";
        bool enter_value = false;
        char iOperaiton;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || !(operation == ""))
            {
                if (!(textBox2.Text == ""))
                {

                    if (operation == "=")
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Text = ((Button)sender).Text;
                        operation = "";
                    }
                    else
                    {
                        textBox1.Text = ((Button)sender).Text;
                        operation = "";
                    }
                }
                else
                {
                    textBox1.Text = ((Button)sender).Text;
                    operation = "";
                }

            }
            else
            {
                textBox1.Text += ((Button)sender).Text;
            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                result = Double.Parse(textBox1.Text);
                textBox2.Text = textBox1.Text + "-";
                operation = "-";

            }
            else
            {
                result = result - Double.Parse(textBox1.Text);
                textBox2.Text = textBox2.Text + textBox1.Text + "-";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + result;

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                result = Double.Parse(textBox1.Text);
                textBox2.Text = textBox1.Text + "+";
                operation = "+";

            }
            else
            {
                result = result + Double.Parse(textBox1.Text);
                textBox2.Text = textBox2.Text + textBox1.Text + "+";

                textBox1.Text = "";
                textBox1.Text = textBox1.Text + result;

            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + textBox1.Text + "=";
            if (operation == "+")
            {
                result = result + Double.Parse(textBox1.Text);
            }
            else
            {
                result = result - Double.Parse(textBox1.Text);
            }

            textBox1.Text = "";
            textBox1.Text = textBox1.Text + result;
            operation = "=";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int t;
            t = int.Parse(textBox1.Text);
            t = t / 10;
            textBox1.Text = "";
            textBox1.Text = textBox1.Text + t;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
