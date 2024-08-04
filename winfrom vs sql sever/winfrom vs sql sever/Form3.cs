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
    

    public partial class Form3 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection con = null;   
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bntkhongdun_Click(object sender, EventArgs e)
        {
            if(con == null)
            {
                con = new SqlConnection(strCon);
            }
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // tạo đối tượng truy vấn 
            String maVT = txtMVT.Text.Trim();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from VATTU\r\nwhere MaVTu = '" + maVT + "'";
            cmd.Connection = con;

            // Thực thi 
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                String tenVT = reader.GetString(1);
                String donViTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                // hiện thị lên giap diện 
                txtTenVT.Text = tenVT;
                txtDonViTinh.Text = donViTinh;
                txtPhanTram.Text = phanTram.ToString();
            }
            // đóng đầu đọc 
            reader.Close();
            con.Close();

        }

        private void btncodung_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                con = new SqlConnection(strCon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // tạo đối tượng truy vấn 
            String maVT = txtMVT.Text.Trim();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from VATTU\r\nwhere MaVTu = @MaVTu";

            //định nghĩa
            SqlParameter parMavtu = new SqlParameter("@MaVTu", SqlDbType.Char);
            parMavtu.Value = maVT;  
            cmd.Parameters.Add(parMavtu);

            cmd.Connection = con;

            // Thực thi 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                String tenVT = reader.GetString(1);
                String donViTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                // hiện thị lên giap diện 
                txtTenVT.Text = tenVT;
                txtDonViTinh.Text = donViTinh;
                txtPhanTram.Text = phanTram.ToString();
            }
            // đóng đầu đọc 
            reader.Close();
            con.Close();

        }
    }
}
