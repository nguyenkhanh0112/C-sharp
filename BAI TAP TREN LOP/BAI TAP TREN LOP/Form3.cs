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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ketqua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(n.Text.Trim());
            int sum = 0;
            String s = "";
            for(int i = 0; i <= a; i++)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    sum += i;
                    s += (i+" ");
                }
            }
            textBox2.Text = s;
            textBox1.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void n_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
