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

namespace winfrom_vs_sql_sever
{
    public partial class Truyvanlaymotgiatri : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True");
        public Truyvanlaymotgiatri()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            // tạo đối tượng thực thi truy vấn 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  COUNT(*) from VATTU";
            // gửi truy vấn vào kết nối 
            cmd.Connection = con;
            // nhận kết quả 
            // thực hiện truy vấn lấy một giá trị sử dụng ExecuteScalar
            int soluonng = (int)cmd.ExecuteScalar();
            MessageBox.Show("số lượng vật tư: " + soluonng);
        }
    }
}
