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
    public partial class Form14 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter= null;
        DataSet ds = null;


        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            HienThi_load();
        }
        private void HienThi_load() {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "select * from VATTU";
            adapter = new SqlDataAdapter(query, strCon);
            SqlCommandBuilder cmdbld = new SqlCommandBuilder(adapter);
            ds= new DataSet();
            adapter.Fill(ds,"Table_VT");
            dgvDanhSach.DataSource = ds.Tables["Table_VT"];
            
        }
        int index = -1;
        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không!", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  
            if (kq == DialogResult.Yes)
            {
                XoaDuLieu_Load();
            }
        }

        private void XoaDuLieu_Load()
        {
            if (index == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
                return;
            }
            DataRow row = ds.Tables["Table_VT"].Rows[index];
            row.Delete();
            int kq = adapter.Update(ds.Tables["Table_VT"]);
            if (kq > 0)
            { 
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index == -1) return;
        }
    }
}
