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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Mã Sinh Viên: " + textBox1.Text.Trim() + "\n" +
                "Họ Và Tên: " + textBox2.Text.Trim() + "\n" +
                "Niên Khóa: " + comboBox1.SelectedItem.ToString() + "\n" +
                "Học Kỳ: ";
            if (radioButton1.Checked)
                s += "Kì I" + "\n";
            if (radioButton2.Checked)
                s += "Kì II" + "\n";
            if (radioButton3.Checked)
                s += "Kì III" + "\n";
            if (radioButton4.Checked)
                s += "Kì IV" + "\n";
            s += "Môn Học:\n";
            for(int i=0;i<checkedListBox1.CheckedItems.Count;i++) {
                s += (i + 1)+" " + checkedListBox1.CheckedItems[i].ToString()+"\n";
            }
            MessageBox.Show(s);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
