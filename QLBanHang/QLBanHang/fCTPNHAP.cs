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
    public partial class fCTPNHAP : Form
    {
        String SoPN;
        CTPNHAPBLL obj_bll = new CTPNHAPBLL();
        CTPNHAP obj_data = new CTPNHAP();
        public fCTPNHAP()
        {
            InitializeComponent();
        }
        public fCTPNHAP(String SoPN)
        {
            this.SoPN = SoPN;
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        void hienthi1()
        {
            dataGridView1.DataSource = obj_bll.GetDataById(this.SoPN);
        }
        void hienthi()
        {
            dataGridView1.DataSource = obj_bll.GetData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtDgNhap.Enabled = true;
            cbMaVTu.Enabled = true;
            txtSlNhap.Enabled = true;
            cbSoPN.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled= false;
            btnXoa.Enabled= false;
            txtDgNhap.Text = String.Empty;
            txtSlNhap.Text = String.Empty;
            cbMaVTu.Text = String.Empty;
            cbSoPN.Text = String.Empty;
        }

        private void fCTPNHAP_Load(object sender, EventArgs e)
        {
            txtDgNhap.Enabled = false;
            cbMaVTu.Enabled = false;
            txtSlNhap.Enabled = false;
            cbSoPN.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            addComboBoxMaVTu();
            addComboBoxSoPN();
            hienthi1();

        }
        
        void addComboBoxSoPN()
        {
            DataTable tb = new DataTable();
            PNHAPBLL pNHAPBLL = new PNHAPBLL();
            tb = pNHAPBLL.GetData();
            foreach(DataRow row in tb.Rows)
            {
                cbSoPN.Items.Add(row[0].ToString());   
            }
        }
        void addComboBoxMaVTu()
        {
            DataTable tb = new DataTable();
            VATTUBLL vATTUBLL = new VATTUBLL();
            tb = vATTUBLL.GetData();
            foreach(DataRow row in tb.Rows) {
                cbMaVTu.Items.Add(row[0].ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj_data.MaVTu = cbMaVTu.Text;
            obj_data.SoPn = cbSoPN.Text;
            obj_data.SlNhap = txtSlNhap.Text;
            obj_data.DgNhap = float.Parse(txtDgNhap.Text);
            obj_bll.insert(obj_data);
            hienthi();
            MessageBox.Show("Lưu thành công!", "Thông Báo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDgNhap.Enabled = true;
            cbMaVTu.Enabled = true;
            txtSlNhap.Enabled = true;
            cbSoPN.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbSoPN.Text = dataGridView1.Rows[e.RowIndex].Cells["SoPN"].Value.ToString();
                cbMaVTu.Text = dataGridView1.Rows[e.RowIndex].Cells["MaVTu"].Value.ToString();
                txtSlNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["SlNhap"].Value.ToString();
                txtDgNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["DgNhap"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            obj_data.MaVTu = cbMaVTu.Text;
            obj_data.SoPn = cbSoPN.Text;
            obj_data.SlNhap = txtSlNhap.Text;
            obj_data.DgNhap = float.Parse(txtDgNhap.Text);
            obj_bll.update(obj_data);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obj_data.SoPn = cbSoPN.Text;
                obj_data.MaVTu = cbMaVTu.Text;
                obj_bll.delete(obj_data);
                hienthi();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }
    }
}
