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
    public partial class fCTDONDH : Form
    {   
        CTDONDH obj = new CTDONDH();
        CTDONDHBLL objjj = new CTDONDHBLL();
        String SoDH;
        public fCTDONDH(String e)
        {
            InitializeComponent();
            this.SoDH = e;

        }
        public fCTDONDH()
        {
            InitializeComponent();
        }


        void hienthi1()
        {
            dataGridView1.DataSource = objjj.GetDataById(SoDH);
        }
        void hienthi()
        {
            dataGridView1.DataSource=objjj.GetData();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cbMaVTu.Enabled = true;
            textSlDat.Enabled = true;
            cbSoDH.Enabled = true;
            btnLuu.Enabled = true;
            textSlDat.Text = string.Empty;
            cbMaVTu.Text = string.Empty;
            cbSoDH.Text = string.Empty;
        }

        private void fCTDONDH_Load(object sender, EventArgs e)
        {
            textSlDat.Enabled = false;
            cbMaVTu.Enabled = false;
            cbSoDH.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            addDataComboBoxMaVTu();
            addDataComboBoxSoDH();
            hienthi1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            textSlDat.Enabled = true;
            cbMaVTu.Enabled = true;
            cbSoDH.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) { 
                cbMaVTu.Text = dataGridView1.Rows[e.RowIndex].Cells["MaVTu"].Value.ToString();
                textSlDat.Text = dataGridView1.Rows[e.RowIndex].Cells["SlDat"].Value.ToString();
                cbSoDH.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDH"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.MaVTu = cbMaVTu.Text;
            obj.SLDat =int.Parse(textSlDat.Text);
            obj.SoDH = cbSoDH.Text;
            objjj.insert(obj);
            hienthi();
            MessageBox.Show("Thêm thành công!", "Thông Báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            obj.MaVTu = cbMaVTu.Text;
            obj.SLDat = int.Parse(textSlDat.Text);
            obj.SoDH = cbSoDH.Text;
            objjj.update(obj);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn xóa không!","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {   
                obj.SoDH = cbSoDH.Text;
                objjj.delete(obj);
                hienthi();
                MessageBox.Show("Xóa thành công");
            }
            

        }
        void addDataComboBoxMaVTu()
        {
            DataTable tb = new DataTable();
            VATTUBLL obj_vattu = new VATTUBLL();
            tb = obj_vattu.GetData();
            foreach(DataRow row in tb.Rows)
            {
                cbMaVTu.Items.Add(row["MaVTu"].ToString());
            }
        }
        void addDataComboBoxSoDH()
        {
            DataTable tb = new DataTable();
            DONDHBLL objjjj = new DONDHBLL();
            tb = objjjj.GetData();
            foreach (DataRow row in tb.Rows)
            {
                cbSoDH.Items.Add(row[0].ToString());
            }
            
        }

        private void cbSoDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMaVTu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
