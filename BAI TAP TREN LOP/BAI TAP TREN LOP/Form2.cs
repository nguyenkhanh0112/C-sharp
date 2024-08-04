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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(NhapThang.Text.Trim());
            int b = int.Parse(NhapNam.Text.Trim());
            do
            {
                if (a <= 1 && a >= 12)
                    KQ.Text = "Ban da nhap sai, Hay nhap lai (Thang >=1 && thang <=12) ";
               
            
            } while (a <= 1 && a >= 12);
            switch (a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    KQ.Text = "Thang " + a + " co 31 Ngay";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    KQ.Text = "Thang " + a + " co 30 Ngay";
                    break;
                case 2:
                    if (b % 400 == 0 || b % 4 == 0 && b % 100 == 0)
                    {
                        KQ.Text = "Thang " + a + " co 29 Ngay";
                    }
                    else
                        KQ.Text = "Thang " + a + " co 28 Ngay ";
                    break;
            }
        }
        private void NhapNam_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void NhapThang_TextChanged(object sender, EventArgs e)
        {
            String a = NhapThang.Text;
            if (a == "2")
            {
                label2.Visible = true;
                NhapNam.Visible = true;
            }
            else
            {
                label2.Visible = false;
                NhapNam.Visible = false;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            NhapNam.Visible = false;
        }
    }
}
