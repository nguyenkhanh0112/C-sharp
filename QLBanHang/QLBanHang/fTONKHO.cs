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
    public partial class fTONKHO : Form
    {
        TONKHOBLL obj_bll = new TONKHOBLL();
        TONKHO obj_data = new TONKHO();
        public fTONKHO()
        {
            InitializeComponent();
        }
        void hienthi()
        {
            dataGridView1.DataSource = obj_bll.GetData();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cbMaVTu.Enabled = true;
            txtDate.Enabled = true;
            txtSlc.Enabled = true;
            txtSld.Enabled = true;
            txtTongSLN.Enabled = true;
            txtTongSLX.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cbMaVTu.Text = String.Empty;
            txtDate.Text = String.Empty;
            txtSlc.Text = String.Empty;
            txtSld.Text = String.Empty;
            txtTongSLN.Text = String.Empty;
            txtTongSLX.Text = String.Empty;
        }

        private void fTONKHO_Load(object sender, EventArgs e)
        {
            cbMaVTu.Enabled = false;
            txtDate.Enabled = false;
            txtSlc.Enabled = false;
            txtSld.Enabled = false;
            txtTongSLN.Enabled = false;
            txtTongSLX.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            addComboBoxMaVTu();
            hienthi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           obj_data.MaVTu = cbMaVTu.Text;
            obj_data.Namthang = txtDate.Text;
            obj_data.SlCuoi =  int.Parse(txtSlc.Text);
            obj_data.SlDau =int.Parse(txtSld.Text);
            obj_data.TongSLN = int.Parse(txtTongSLN.Text);
            obj_data.TongSLX = int.Parse(txtTongSLX.Text);
            obj_bll.insert(obj_data);
            hienthi();
            MessageBox.Show("Lưu thành công !", "Thông Báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            obj_data.MaVTu = cbMaVTu.Text;
            obj_data.Namthang = txtDate.Text;
            obj_data.SlCuoi = int.Parse(txtSlc.Text);
            obj_data.SlDau = int.Parse(txtSld.Text);
            obj_data.TongSLN = int.Parse(txtTongSLN.Text);
            obj_data.TongSLX = int.Parse(txtTongSLX.Text);
            obj_bll.update(obj_data);
            hienthi();
            MessageBox.Show("Sửa thành công !", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không! ","Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obj_data.MaVTu = cbMaVTu.Text;
                obj_bll.delete(obj_data);
                hienthi();
                MessageBox.Show("Xóa thành công !", "Thông Báo");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void addComboBoxMaVTu()
        {
            DataTable tb = new DataTable();
            VATTUBLL vATTUBLL = new VATTUBLL();
            tb = vATTUBLL.GetData();
            foreach(DataRow row in tb.Rows)
            {
                cbMaVTu.Items.Add(row["MaVTu"].ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaVTu.Enabled = true;
            txtDate.Enabled = true;
            txtSlc.Enabled = true;
            txtSld.Enabled = true;
            txtTongSLN.Enabled = true;
            txtTongSLX.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbMaVTu.Text = dataGridView1.Rows[e.RowIndex].Cells["MaVTu"].Value.ToString();
            txtDate.Text = dataGridView1.Rows[e.RowIndex].Cells["Namthang"].Value.ToString();
            txtSlc.Text = dataGridView1.Rows[e.RowIndex].Cells["SlCuoi"].Value.ToString();
            txtSld.Text = dataGridView1.Rows[e.RowIndex].Cells["SlDau"].Value.ToString();
            txtTongSLN.Text = dataGridView1.Rows[e.RowIndex].Cells["TongSLN"].Value.ToString();
            txtTongSLX.Text = dataGridView1.Rows[e.RowIndex].Cells["TongSLX"].Value.ToString();
        }
    }
}
