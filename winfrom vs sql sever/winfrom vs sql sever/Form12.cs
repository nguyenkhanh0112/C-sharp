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
    public partial class Form12 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter Adapter = null;
        DataSet ds = null;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            Hienthidulieu_load();
        }

        private void Hienthidulieu_load()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "select * from VATTU ";
            Adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);
            ds = new DataSet();

            Adapter.Fill(ds, "Table_VT");
            dgvDanhSach.DataSource = ds.Tables["Table_VT"];
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["Table_VT"].NewRow();
            row["MaVTu"] = txtMaVT.Text.Trim();
            row["TenVTu"] = txtTenVT.Text.Trim();
            row["DvTinh"] = txtDVtinh.Text.Trim();
            row["PhanTram"] = txtPT.Text.Trim();

            ds.Tables["Table_VT"].Rows.Add(row);
            int kq = Adapter.Update(ds.Tables["Table_VT"]);
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!");
            }


        }
        int index = -1;

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
