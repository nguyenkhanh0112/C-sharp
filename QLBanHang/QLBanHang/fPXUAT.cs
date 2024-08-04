using DataAccessLayer;
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
    public partial class fPXUAT : Form
    {
        PXUATBLL sPXUATBLL= new PXUATBLL();
        PXUAT pXUAT = new PXUAT();
        public fPXUAT()
        {
            InitializeComponent();
        }

        private void fPXUAT_Load(object sender, EventArgs e)
        {
            txtNgayxuat.Enabled = false;
            txtSoPX.Enabled = false;
            txtTenKH.Enabled  = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            hienThi();
            
        }
        void addColumndgv() 
        {
            DataGridViewButtonColumn dav = new DataGridViewButtonColumn();
            dav.Name = "Xemchitiet";
            dav.UseColumnTextForButtonValue = true;
            dav.Text = "Xem chi tiết";
            dataGridView1.Columns.Add(dav);
        }
        void hienThi()
        {
            dataGridView1.DataSource = sPXUATBLL.GetData();
            addColumndgv();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtNgayxuat.Enabled = true;
            txtSoPX.Enabled = true;
            txtTenKH.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtNgayxuat.Text = String.Empty;
            txtSoPX.Text = String.Empty;
            txtTenKH.Text = String.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            pXUAT.TenKH = txtTenKH.Text;
            pXUAT.Ngayxuat = DateTime.Parse(txtNgayxuat.Text);
            pXUAT.SoPX = txtSoPX.Text;
            sPXUATBLL.insert(pXUAT);
            hienThi();
            txtNgayxuat.Text = String.Empty;
            txtSoPX.Text = String.Empty;
            txtTenKH.Text = String.Empty;

            MessageBox.Show("Lưu thành công!","Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pXUAT.TenKH = txtTenKH.Text;
            pXUAT.Ngayxuat =DateTime.Parse(txtNgayxuat.Text);
            pXUAT.SoPX = txtSoPX.Text;
            sPXUATBLL.update(pXUAT);
            hienThi();
            txtNgayxuat.Text = String.Empty;
            txtSoPX.Text = String.Empty;
            txtTenKH.Text = String.Empty;
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có muốn xóa không!","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pXUAT.SoPX = txtSoPX.Text;
                sPXUATBLL.delete(pXUAT);
                hienThi();
                txtNgayxuat.Text = String.Empty;
                txtSoPX.Text = String.Empty;
                txtTenKH.Text = String.Empty;
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNgayxuat.Enabled = true;
            txtSoPX.Enabled = true;
            txtTenKH.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtNgayxuat.Text = dataGridView1.Rows[e.RowIndex].Cells["Ngayxuat"].Value.ToString();
                txtSoPX.Text = dataGridView1.Rows[e.RowIndex].Cells["SoPX"].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xemchitiet")
            {
                fCTPXUAT fCTPXUAT = new fCTPXUAT(dataGridView1.Rows[e.RowIndex].Cells["SoPX"].Value.ToString());
                fCTPXUAT.ShowDialog();
            }
        }
    }
}
