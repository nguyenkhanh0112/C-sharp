using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK) { 
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // openFileDialog1.Filter = "(*.png) | *.png| (*.jpg)|*.jpg";
            openFileDialog1.Filter = "image files (*.png;*.jpg)|*.png;*.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button2.BackColor;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button3.Font;
            if(fontDialog1.ShowDialog()== DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                label2.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
