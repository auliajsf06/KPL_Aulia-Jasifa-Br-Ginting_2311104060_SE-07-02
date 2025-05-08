using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPModul12_2311104060
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputTextBox.Text, out int number))
            {
                string result = CariTandaBilangan(number);
                resultLabel.Text = result;
            }
            else
            {
                resultLabel.Text = "Input tidak valid!";
            }
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            if (a > 0) return "Positif";
            return "Nol";
        }
    }
}
