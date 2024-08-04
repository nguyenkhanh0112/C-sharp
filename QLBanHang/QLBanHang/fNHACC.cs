
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;
using BusinessLogicLayer;



namespace QLBanHang
{
    public partial class fNHACC : Form
    {
       
        private NHACC nhacc = new NHACC();
        private NACCCBLL nhaccbll =  new NACCCBLL();
        public fNHACC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FromNCC_Load(object sender, EventArgs e)
        {
            from_loadss();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhacc.MaNCC=txtNCC.Text;
            nhacc.TenNCC=txtTNCC.Text;
            nhacc.DiaChi = txtDiaChi.Text;
            nhacc.DienThoai = txtDienThoai.Text;
            nhaccbll.insert(nhacc);
            hienthi();
            MessageBox.Show("Lưu thành công!","Thông báo");
        }
        void hienthi()
        {
            dataGridView1.DataSource = nhaccbll.GetData();
        }
        public void from_loadss()
        {
            txtNCC.Enabled = false;
            txtTNCC.Enabled = false;
            txtDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            hienthi();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtNCC.Enabled = true;
            txtTNCC.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            btnLuu.Enabled = true;
            txtDienThoai.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtNCC.Text = String.Empty;
            txtTNCC.Text = String.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            nhacc.MaNCC = txtNCC.Text;
            nhacc.TenNCC = txtTNCC.Text;
            nhacc.DiaChi = txtDiaChi.Text;
            nhacc.DienThoai = txtDienThoai.Text; 
            nhaccbll.update(nhacc);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtNCC.Enabled = true;
            txtTNCC.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            // kiểm tra chọn ô người dùng không phải ô tiêu đề 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
                txtNCC.Text = rows.Cells[0].Value.ToString();
                txtTNCC.Text = rows.Cells[1].Value.ToString();
                txtDiaChi.Text = rows.Cells[2].Value.ToString();
                txtDienThoai.Text = rows.Cells[3].Value.ToString();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa không!","Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nhacc.MaNCC = txtNCC.Text;
                nhaccbll.delete(nhacc);
                hienthi();
                MessageBox.Show("Xóa thành công!","Thông Báo");
            }
        }
    }
}
