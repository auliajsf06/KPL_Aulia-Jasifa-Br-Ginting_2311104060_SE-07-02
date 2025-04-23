using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JURNAL3_2311104060
{
    public partial class Form1: Form
    {
        private double number1 = 0;
        private double number2 = 0;
        private bool isAdding = false;
        private bool isNewInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "0";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "0";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "1";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "2";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "3";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "4";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "5";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "6";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "7";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "8";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                textBoxOutput.Text = "9";
                isNewInput = false;
            }
            else
            {
                textBoxOutput.Text += "9";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOutput.Text))
            {
                number1 = Convert.ToDouble(textBoxOutput.Text);
                isAdding = true;
                isNewInput = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (isAdding && !string.IsNullOrEmpty(textBoxOutput.Text))
            {
                number2 = Convert.ToDouble(textBoxOutput.Text);
                double result = number1 + number2;
                textBoxOutput.Text = result.ToString();
                isAdding = false;
                isNewInput = true;
            }
        }
    }
}
