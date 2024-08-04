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
    public partial class Form13 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter= null;
        DataSet ds= null;
        public Form13()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void HienthiDanhSach_load()
        {
            if(sqlCon== null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "select * from VATTU";
            adapter = new SqlDataAdapter(query,sqlCon);
            SqlCommandBuilder cmdbld = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Table_VT");
            dgvDanhSach.DataSource= ds.Tables["Table_VT"];
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            HienthiDanhSach_load();
        }
        int index = -1;
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index == -1) return;
            DataRow row = ds.Tables["Table_VT"].Rows[index];
            txtMaVT.Text = row["MaVTu"].ToString();
            txtTenVT.Text = row["TenVTu"].ToString();
            txtDVtinh.Text = row["DvTinh"].ToString();
            txtPT.Text = row["PhanTram"].ToString();

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Bạn chưa chọn Vật Tư");
                return;
            }
            DataRow row = ds.Tables["Table_VT"].Rows[index];
            row.BeginEdit();
            row["MaVTu"] = txtMaVT.Text.Trim();
            row["TenVTu"] = txtTenVT.Text.Trim();
            row["DvTinh"] = txtDVtinh.Text.Trim();
            row["PhanTram"] = txtPT.Text.Trim();
            row.EndEdit();
            int kq = adapter.Update(ds.Tables["Table_VT"]);
            if (kq > 0) {
                MessageBox.Show("Chỉnh sửa dữ liệu thành công !");

            }else
            {
                MessageBox.Show("Chỉnh sửa dữ liệu thất bại!");
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
