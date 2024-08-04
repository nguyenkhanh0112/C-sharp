using BusinessLogicLayer;
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
    public partial class fCTPXUAT : Form
    {
        CTPXUAT obj_data = new CTPXUAT();
        CTPXUATBLL obj_bll = new CTPXUATBLL();
        String s;
        public fCTPXUAT()
        {
            InitializeComponent();
        }
        public fCTPXUAT(String s)
        {
            this.s = s;
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cbMaVTu.Enabled = true;
            cbSoPX.Enabled = true;
            txtDgxuat.Enabled = true;
            txtSlxuat.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDgxuat.Text = string.Empty;
            cbMaVTu.Text = string.Empty;
            cbSoPX.Text = string.Empty;
            txtSlxuat.Text = string.Empty;
        }

        private void fCTPXUAT_Load(object sender, EventArgs e)
        {
            cbMaVTu.Enabled = false;
            cbSoPX.Enabled = false;
            txtDgxuat.Enabled = false;
            txtSlxuat.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            addComboBoxMaVTu();
            addComboBoxSoPX();
            hienthi1();
        }
        void hienthi()
        {
            dataGridView1.DataSource = obj_bll.GetData();
        }
        void hienthi1()
        {   
            dataGridView1.DataSource = obj_bll.GetDataById(this.s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj_data.SlXuat =int.Parse(txtSlxuat.Text);
            obj_data.MaVTu = cbMaVTu.Text;
            obj_data.SoPX = cbSoPX.Text;
            obj_data.DgXuat =decimal.Parse(txtDgxuat.Text);
            obj_bll.insert(obj_data);
            hienthi();
            MessageBox.Show("Lưu thành công!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            obj_data.SlXuat = int.Parse(txtSlxuat.Text);
            obj_data.MaVTu = cbMaVTu.Text;
            obj_data.SoPX = cbSoPX.Text;
            obj_data.DgXuat = decimal.Parse(txtDgxuat.Text);
            obj_bll.update(obj_data);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }
        void addComboBoxSoPX()
        {
            PXUATBLL bll = new PXUATBLL();
            DataTable tb = new DataTable();
            tb = bll.GetData();
            foreach(DataRow row in tb.Rows)
            {
                cbSoPX.Items.Add(row["SoPX"].ToString());
            }
        }
        void addComboBoxMaVTu()
        {
            VATTUBLL bll = new VATTUBLL();
            DataTable tb = new DataTable();
            tb = bll.GetData();
            foreach (DataRow row in tb.Rows)
            {
                cbSoPX.Items.Add(row["MaVTu"].ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không!","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obj_data.MaVTu = cbMaVTu.Text;
                obj_data.SoPX = cbSoPX.Text;
                obj_bll.delete(obj_data);
                hienthi();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cbMaVTu.Enabled = true;
            cbSoPX.Enabled = true;
            txtDgxuat.Enabled = true;
            txtSlxuat.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if(e.RowIndex>=0&& e.ColumnIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbMaVTu.Text = row.Cells["MaVTu"].Value.ToString();
                cbSoPX.Text = row.Cells["SoPX"].Value.ToString();
                txtDgxuat.Text = row.Cells["DgXuat"].Value.ToString();
                txtSlxuat.Text = row.Cells["SlXuat"].Value.ToString();

            }

        }
    }
}
