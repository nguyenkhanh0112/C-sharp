using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_TREN_LOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text.Trim());
            int b = int.Parse(textBox2.Text.Trim());
            int c = int.Parse(textBox4.Text.Trim());
            double denta = b*b - 4 * a * c;
            if (a == 0)
            {
                ketqua.Text = "PT la PT bac Nhat ";
            }
            if (denta < 0)
                ketqua.Text = "PT vo nghiem";
            else if (denta == 0)
            {
                double x = -(b * 1.0) / 2 * a;
                ketqua.Text = "PT co 1 Nghiem -b/2a = " + x;
            }
            else
            {
                double x1 = (-(double)b - Math.Sqrt(denta)) /( 2 * a);
                double x2 = (-(double)b + Math.Sqrt(denta)) / (2 * a);
                ketqua.Text = "PT co 2 nghiem x1 ,x2 = " + x1 + " va " + x2;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
