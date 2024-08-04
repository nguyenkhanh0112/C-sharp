using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   
        SqlConnection con =  new SqlConnection(@"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Q_71DCHT21_QLDiem111;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "excel file |*.xls;*.xlsx";
            f.FilterIndex = 1; //trỏ vào vị trí đầu tiên của bộ lọc
            f.RestoreDirectory = true; // nhớ đường dẫn của lần truy cập trước
            f.Multiselect = false; //không cho phép chọn nhiều file 1 lúc
            if (f.ShowDialog() == DialogResult.OK)
            {
                //txtFilePath.Text = f.FileName;
                //filename = f.FileName;  //Biến filename khai báo biến toàn cục
                //ReadExcel();
            }
        }
    }
}
