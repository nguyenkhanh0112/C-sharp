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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == " ") {
                textBox1.Focus();
                MessageBox.Show("Phải Nhập Họ Tên ");
            }
            if(maskedTextBox1.Text.Trim() == "/ /") { 
                maskedTextBox1.Focus();
                MessageBox.Show("Phải Nhập Ngày Tháng");
            }
            if (textBox2.Text.Trim() == "")
            {
                textBox2.Focus();
                MessageBox.Show("phải nhập địa chỉ ");
            }
            if (listBox1.Items.ToString()=="")
            {
                listBox1.Focus();
                MessageBox.Show("phải nhập thành phố");
            }
            if (comboBox1.Text.Trim()=="")
            {
                comboBox1.Focus();
                MessageBox.Show("phải nhập  quốc tịch");
            }
            if (maskedTextBox2.Text.Trim()=="   -    ")
            {
                maskedTextBox2.Focus();
                MessageBox.Show("phải nhập số điện thoại");
            }
            if (textBox3.Text.Trim()=="")
            {
                textBox3.Focus();
                MessageBox.Show("phải nhập Email");
            }
            if(dateTimePicker1.Text.Trim()==" ,   ,   ")
            {
                dateTimePicker1.Focus();
                MessageBox.Show("phải nhập ngày tháng");
            }
            String S = "Họ và Tên Nhân Viên: " + textBox1.Text.Trim() + "\n"+
                "Ngày Sinh: "+ maskedTextBox1.Text.ToString()+"\n"+
                "Địa chỉ: "+textBox2.Text.Trim()+"\n"+
                "Thành phố: "+listBox1.Text.Trim() + "\n"+
                "Quốc tịch: "+comboBox1.Text.Trim()+"\n"+
                "Số điện thoại: "+maskedTextBox2.Text.Trim() + "\n"+
                "Email: "+textBox3.Text.Trim()+"\n"+
                "Ngày đăng kí: "+maskedTextBox2.Text.Trim()+"\n";

            MessageBox.Show(S);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
