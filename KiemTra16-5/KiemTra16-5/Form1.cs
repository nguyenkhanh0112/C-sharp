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

namespace KiemTra16_5
{
    public partial class Form1 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=de3;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter sqlDataAdapter = null;
        DataSet ds = null; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Hienthi_loadfrom()
        {
            if (sqlCon == null)
            {
                sqlCon= new SqlConnection(strCon);
            }
            String query = "Select  * from Sanpham";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dgvthongtinsp.DataSource = ds.Tables[0] ;


        }
        private void loadcb()
        {
            
            if (sqlCon == null)
            {
                sqlCon= new SqlConnection(strCon);
            }
            String query = "Select  * from Nhacungcap";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            DataRow r = ds.Tables[0].NewRow();
            r["tenncc"] = "Chọn nhà cung cấp ";
            r["mancc"] = "";
            ds.Tables[0].Rows.InsertAt(r, 0);
            cbNCC.DataSource = ds.Tables[0];
            cbNCC.DisplayMember = "tenncc";
            cbNCC.ValueMember = "mancc";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi_loadfrom();
            from_vohieuhoatext();
            loadcb();
            btnLuu.Enabled = false;
            btnCN.Enabled = false;
            btnXoa.Enabled = false;

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnCN.Enabled = false;
            btnXoa.Enabled = false;
            Hienthi_loadfrom();
            String query = "Select  * from Sanpham";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            from_them();
            from_hienthi();
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
        int index = -1;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "Select  * from Sanpham";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            DataRow row = ds.Tables[0].NewRow();
            row["masp"] = txtMSP.Text.Trim();
            row["tensp"] = txtTSP.Text.Trim();
            row["gia"] = int.Parse(txtGia.Text.Trim());
            row["soluong"] = int.Parse(txtSL.Text.Trim());
            row["mancc"] = cbNCC.SelectedValue.ToString();
            if (int.Parse(txtSL.Text.Trim()) > 100)
            {
                MessageBox.Show("Số lượng nhập không quá 100,Nhập lại");
            }
            else
            {
                ds.Tables[0].Rows.Add(row);
                int kq = sqlDataAdapter.Update(ds.Tables[0]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    Hienthi_loadfrom();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!");
                }
            }
            
        }
        private void from_vohieuhoatext()
        {
            txtMSP.Enabled = false;
            txtGia.Enabled = false;
            txtSL.Enabled = false;
            txtTSP.Enabled = false;
            cbNCC.Enabled = false;
        }
        private void from_hienthi()
        {
            txtMSP.Enabled = true;
            txtGia.Enabled = true;
            txtSL.Enabled = true;
            txtTSP.Enabled = true;
            cbNCC.Enabled = true;
        }
        private void from_them()
        {
            txtMSP.Text = "";
            txtGia.Text = "";
            txtSL.Text = "";
            txtTSP.Text = "";
            loadcb();
        }
        private void dgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCN.Enabled = true;
            btnXoa.Enabled = true;
            from_hienthi();
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "Select  * from Sanpham";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            
            index = e.RowIndex;
            if (index == -1) return;
            DataRow row = ds.Tables[0].Rows[index];
            txtMSP.Text = row["masp"].ToString();
            txtTSP.Text = row["tensp"].ToString();
            txtGia.Text = row["gia"].ToString();
            txtSL.Text = row["soluong"].ToString();
            cbNCC.SelectedValue = row["mancc"].ToString();
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "Select  * from Sanpham";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            if (index == -1) return;
            DataRow row = ds.Tables[0].Rows[index];
            row.BeginEdit();
            row["masp"] = txtMSP.Text.Trim();
            row["tensp"] = txtTSP.Text.Trim();
            row["gia"] = int.Parse(txtGia.Text.Trim());
            row["soluong"] = int.Parse(txtSL.Text.Trim());
            row["mancc"] = cbNCC.SelectedValue.ToString();
            row.EndEdit();
            if (int.Parse(txtSL.Text.Trim()) > 100)
            {
                MessageBox.Show("Số lượng nhập không quá 100,Nhập lại");
            }
            else
            {
                int kq = sqlDataAdapter.Update(ds.Tables[0]);
                if (kq > 0)
                {
                    MessageBox.Show("Chỉnh sửa dữ liệu thành công !");
                    Hienthi_loadfrom();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa dữ liệu thất bại!");
                }
            }
           
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "Select  * from Sanpham";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            if (index == -1) return;
            DataRow row = ds.Tables[0].Rows[index];
            row.Delete();
            int kq = sqlDataAdapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công  !");
                Hienthi_loadfrom();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String tensp1 = txtTimkiem.Text.Trim();
            String query = "select * from Sanpham where tensp = '"+tensp1+"'";
            sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dgvthongtinsp.DataSource = ds.Tables[0];

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}
