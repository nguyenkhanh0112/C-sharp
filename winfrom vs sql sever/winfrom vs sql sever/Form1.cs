using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winfrom_vs_sql_sever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String conctr = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Sinhvien;Integrated Security=True";
        SqlConnection con = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if(con == null) {
                con = new SqlConnection(conctr);
            }
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Kết nối thành công! ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ ex.Message);
            }
        }

        private void button2_Click(object   sender, EventArgs e)
        {
            if(con.State !=null && con.State == ConnectionState.Open) {
                con.Close();
                MessageBox.Show("Đóng kết nối thành công! ");
            }else
            {
                MessageBox.Show("Chưa tạo Kết Nối! ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
