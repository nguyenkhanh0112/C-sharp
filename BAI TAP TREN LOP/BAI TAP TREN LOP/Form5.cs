﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.CheckedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(msv.Text.Trim());
            lv.SubItems.Add(hvt.Text.Trim());  
            lv.SubItems.Add(dt.Text.Trim());  
            lv.SubItems.Add(qq.Text.Trim());  
            lv.SubItems.Add(sex.Text.Trim());
            listView1.Items.Add(lv);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
        }

        private void msv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
