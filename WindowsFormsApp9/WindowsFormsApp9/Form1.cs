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
using System.Collections;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Q_71DCHT21_QLDiem111;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void from_loadTTSV()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = " select * from Sinhvien";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvThongtinsv.DataSource = ds.Tables[0];
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timkiem_Click(object sender, EventArgs e)
        {

        }

        private void masinhvien_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            from_loadTTSV();
            cblop_load();
        }

        private void thoat_Click(object sender, EventArgs e)
        {

        }

        private void luu_Click(object sender, EventArgs e)
        {

        }
        private void cblop_load()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "select * from Lop";
            adapter = new SqlDataAdapter(query,sqlCon);
            ds = new DataSet();
            adapter.Fill(ds);
            DataRow row = ds.Tables[0].NewRow();
            row["Malop"] = "";
            row["Tenlop"] = "Chọn lớp ";
            ds.Tables[0].Rows.InsertAt(row,0);
            cblop.DataSource = ds.Tables[0];
            cblop.DisplayMember = "Tenlop";
            cblop.ValueMember = "Malop";
        }

        private void luu_Click_1(object sender, EventArgs e)
        {

            String masv = txtmasinhvien.Text.Trim();
            String hoten = txthovaten.Text.Trim();
            String lop = cblop.SelectedValue.ToString();
            int gt;
            if (cbgioitinh.SelectedItem.ToString() == "Nam")
            {
                gt = 1;
            }
            else gt = 0;
            DateTime ngaysinh = datengaysinh.Value;
            String cccd = txtcccdcmt.Text.Trim();
            String sdt = txtSodienthoai.Text.Trim();
            String quequan = txtquequan.Text.Trim();
            String query = " select * from Sinhvien";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);
            DataRow row = ds.Tables[0].NewRow();
            row["Masv"] = masv;
            row["Hoten"] = hoten;
            row["GioiTinh"] = gt;
            row["Ngaysinh"] = ngaysinh;
            row["Malop"] = lop;
            row["Quequan"] = quequan;
            row["Dienthoai"] = sdt;
            row["CCCD"] = cccd;
            ds.Tables[0].Rows.Add(row);
            int kq = adapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                from_loadTTSV();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!");
            }

        }

        private void sua_Click(object sender, EventArgs e)
        {
            String masv = txtmasinhvien.Text.Trim();
            String hoten = txthovaten.Text.Trim();
            String lop = cblop.SelectedValue.ToString();
            int gt;
            if (cbgioitinh.SelectedItem.ToString() == "Nam")
            {
                gt = 1;
            }
            else gt = 0;
            DateTime ngaysinh = datengaysinh.Value;
            String cccd = txtcccdcmt.Text.Trim();
            String sdt = txtSodienthoai.Text.Trim();
            String quequan = txtquequan.Text.Trim();
            String query = " select * from Sinhvien";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);
            if (index == -1) return;
            DataRow row = ds.Tables[0].Rows[index];
            row.BeginEdit();    
            row["Masv"] = masv;
            row["Hoten"]= hoten;
            row["GioiTinh"]= gt;
            row["Malop"] = lop;
            row["Quequan"]=quequan;
            row["Dienthoai"]=sdt;
            row["CCCD"]=cccd;
            row["Ngaysinh"] = ngaysinh;
            row.EndEdit();
            int kq = adapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                from_loadTTSV();
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu thất bại!");
            }

        }
        int index = -1;
        private void dgvThongtinsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String query = " select * from Sinhvien";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);


            index = e.RowIndex;
            if (index == -1) return;
            DataRow row = ds.Tables[0].Rows[index];
            txtmasinhvien.Text = row["Masv"].ToString();
            txthovaten.Text = row["Hoten"].ToString();
            //cbgioitinh.text = row["GioiTinh"].ToString();
            cblop.Text = row["Malop"].ToString();
            txtquequan.Text = row["Quequan"].ToString();
            txtSodienthoai.Text = row["Dienthoai"].ToString();
            txtcccdcmt.Text = row["CCCD"].ToString();
            datengaysinh.Text = row["Ngaysinh"].ToString() ;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            String query = " select * from Sinhvien";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);
            if (index == -1) return;
            DataRow row = ds.Tables[0].Rows[index];
            row.Delete();
            int kq = adapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
                from_loadTTSV();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!");
            }
        }
    }
}
