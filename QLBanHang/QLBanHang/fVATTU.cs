using BusinessLogicLayer;
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

namespace QLBanHang
{
    public partial class fVATTU : Form
    {
        VATTUBLL obj_bll = new VATTUBLL();
        VATTU obj = new VATTU();
        public fVATTU()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void hienthi()
        {
            
            dataGridView1.DataSource=obj_bll.GetData();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtDvTinh.Enabled = true;
            txtMaVTu.Enabled = true;
            txtPhanTram.Enabled = true;
            txtTenVT.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDvTinh.Text = String.Empty;
            txtMaVTu.Text= String.Empty;
            txtPhanTram.Text= String.Empty;
            txtTenVT.Text= String.Empty;
            btnLuu.Enabled= true;
        }

        private void fVATTU_Load(object sender, EventArgs e)
        {
            txtDvTinh.Enabled = false;
            txtMaVTu.Enabled = false;
            txtPhanTram.Enabled = false;
            txtTenVT.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            hienthi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.DvTinh = txtDvTinh.Text;
            obj.MaVTu = txtMaVTu.Text;
            obj.PhanTram =float.Parse(txtPhanTram.Text);
            obj.TenVT = txtTenVT.Text;
            obj_bll.insert(obj);
            hienthi();
            MessageBox.Show("Lưu thành công!", "Thông báo");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDvTinh.Enabled = true;
            txtMaVTu.Enabled = true;
            txtPhanTram.Enabled = true;
            txtTenVT.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtDvTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["DvTinh"].Value.ToString() ;
            txtMaVTu.Text = dataGridView1.Rows[e.RowIndex].Cells["MaVTu"].Value.ToString() ;
            txtPhanTram.Text = dataGridView1.Rows[e.RowIndex].Cells["PhanTram"].Value.ToString();
            txtTenVT.Text = dataGridView1.Rows[e.RowIndex].Cells["TenVTu"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            obj.DvTinh = txtDvTinh.Text;
            obj.MaVTu = txtMaVTu.Text;
            obj.PhanTram = float.Parse(txtPhanTram.Text);
            obj.TenVT = txtTenVT.Text;
            obj_bll.update(obj);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không !","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obj.MaVTu = txtMaVTu.Text;
                obj_bll.delete(obj);
                hienthi();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }
    }
}
