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
    public partial class Form6 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            String maVT = txtMaVT.Text.Trim();
            String tenVT = txtTenVtu.Text.Trim();
            String dvTinh = txtDVtinh.Text.Trim();
            float phantram =float.Parse(txtPhanTram.Text.Trim());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into VATTU values(N'"+maVT+"',N'"+tenVT+"',N'"+dvTinh+"',"+phantram+");";
            cmd.Connection = sqlCon;
           
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công ");
                HienThi_load();
            }
            else
                MessageBox.Show("Thêm dữ liệu không thành công ");
 
            
            sqlCon.Close();
        }
        private void HienThi_load()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VATTU";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while(reader.Read())
            {
                String maVT = reader.GetString(0);
                String tenVT = reader.GetString(1);
                String dvTinh = reader.GetString(2);
                float phantram = reader.GetFloat(3);

                ListViewItem  listViewItem = new ListViewItem(maVT);
                listViewItem.SubItems.Add(tenVT);
                listViewItem.SubItems.Add(dvTinh);
                listViewItem.SubItems.Add(phantram.ToString());

                lsvDanhSach.Items.Add(listViewItem);
            }
            reader.Close();
            
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            HienThi_load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            String maVT = txtMaVT.Text.Trim();
            String tenVT = txtTenVtu.Text.Trim();
            String dvTinh = txtDVtinh.Text.Trim();
            float phantram = float.Parse(txtPhanTram.Text.Trim());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into VATTU values(@maVT,@tenVT, @dvTinh,@phantram);";
            // định nghĩa 
            SqlParameter parameterMavt = new SqlParameter("@maVT",SqlDbType.Char);
            SqlParameter parameterTenvt = new SqlParameter("@tenVT", SqlDbType.NVarChar);
            SqlParameter parameterdvTinh = new SqlParameter("@dvTinh", SqlDbType.NVarChar);
            SqlParameter parameterphantram = new SqlParameter("@phantram",SqlDbType.Real);
            parameterMavt.Value = maVT;
            parameterTenvt.Value = tenVT;   
            parameterdvTinh.Value = dvTinh;
            parameterphantram.Value = phantram; 
            cmd.Parameters.Add(parameterMavt);
            cmd.Parameters.Add(parameterTenvt);
            cmd.Parameters.Add(parameterdvTinh);
            cmd.Parameters.Add(parameterphantram);
            cmd.Connection = sqlCon;
            
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công ");
                HienThi_load();
            }
            else
                MessageBox.Show("Thêm dữ liệu không thành công ");

            
            sqlCon.Close();
        }
    }
        
}
