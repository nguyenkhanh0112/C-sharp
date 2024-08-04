using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_TREN_LOP
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(st1.Text.Trim());
            int b = int.Parse(st2.Text.Trim());
            int c = a + b;
            kq.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(st1.Text.Trim());
            int b = int.Parse(st2.Text.Trim());
            int c = a - b;
            kq.Text = c.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(st1.Text.Trim());
            int b = int.Parse(st2.Text.Trim());
            int c = a * b;
            kq.Text = c.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(st1.Text.Trim());
            int b = int.Parse(st2.Text.Trim());
            float c = (float)a / b;
            kq.Text = c.ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void st1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
