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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p_hoten = textBox1.Text.Trim();
            listBox1.Items.Add(p_hoten);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i].ToString());
            }
            for(int i = listBox1.SelectedItems.Count-1; i >=0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = listBox2.SelectedItems.Count;
            for (int i = 0; i <listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i].ToString());
       
            }
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[i].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
