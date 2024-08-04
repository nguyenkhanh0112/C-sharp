using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class fTRANGCHU : Form
    {
        public Form formall;
        public fTRANGCHU()
        {
            InitializeComponent();
            formall = new Form();

        }
        private void load_formChild(Form fromChild)
        {
            if(fromChild != null) {
                this.formall.Close();
            }
            formall = fromChild;
            fromChild.TopLevel = false;
            fromChild.FormBorderStyle= FormBorderStyle.None;
            btnPHIEUNHAP.Controls.Add(fromChild);
            fromChild.Dock = DockStyle.Fill;
            fromChild.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fVATTU bll = new fVATTU();
            load_formChild(bll);
            label1.Text = btnVattu.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            formall.Close();
            label1.Text = "QUẢN LÝ VẬT TƯ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            fNHACC bll = new fNHACC();
            load_formChild(bll);
            label1.Text = btnNCC.Text;
        }

        private void btnDondh_Click(object sender, EventArgs e)
        {
            load_formChild(new fDONDH());
            label1.Text = btnDondh.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load_formChild(new fPNHAP());
            label1.Text = btnPHIEUNHAP.Text;
        }

        private void btnPXUAt_Click(object sender, EventArgs e)
        {
            load_formChild(new fPXUAT());
            label1.Text = btnPXUAt.Text;
        }

        private void btnTONKHO_Click(object sender, EventArgs e)
        {
            load_formChild(new fTONKHO());
            label1.Text = btnTONKHO.Text;
        }

        private void fTRANGCHU_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
