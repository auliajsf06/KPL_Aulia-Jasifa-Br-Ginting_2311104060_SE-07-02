using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPModul3_2311104070
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string namaPraktikan = txtinput.Text.Trim();

            if (namaPraktikan.Equals("AULIA JASIFA", StringComparison.OrdinalIgnoreCase))
            {
                labeloutp.Text = $"Hallo {namaPraktikan}";
            }
            else
            {
                labeloutp.Text = "Nama tidak dikenal.";
            }
        }

        private void labeloutp_Click(object sender, EventArgs e)
        {

        }
    }
}
