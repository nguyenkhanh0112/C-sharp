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
    public partial class fPNHAP : Form
    {
        PNHAPBLL obj_bll = new PNHAPBLL();
        PNHAP obj = new PNHAP();
        
        public fPNHAP()
        {
            InitializeComponent();
        }
       
        void hienthi()
        {
            dataGridView1.DataSource = obj_bll.GetData();
        }
       
        private void fPNHAP_Load(object sender, EventArgs e)
        {
            txtNgayNhap.Enabled = false;
            txtSoPN.Enabled= false;
            cbSoDH.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            addComboBoxSoDH();
            hienthi();
            addColumnButtomCTPNHAP();
        }
        void addComboBoxSoDH()
        {
            DONDHBLL bojjj = new DONDHBLL();
            DataTable db = new DataTable();
            db = bojjj.GetData();
            foreach(DataRow row in db.Rows)
            {
                cbSoDH.Items.Add(row["SoDH"].ToString());
                
            }
            
        }
        void addColumnButtomCTPNHAP()
        {
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnXemchitiet";
            btn.Text = "Xem chi tiết";
            btn.UseColumnTextForButtonValue= true;
            dataGridView1.Columns.Add(btn);
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtNgayNhap.Enabled = true;
            txtSoPN.Enabled = true;
            cbSoDH.Enabled = true;
            txtNgayNhap.Text = String.Empty;
            txtSoPN.Text = String.Empty;
            cbSoDH.Text = String.Empty;
            btnLuu.Enabled= true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.Ngaynhap = DateTime.Parse(txtNgayNhap.Text);
            obj.SoPN = txtSoPN.Text;
            obj.SoDH =  cbSoDH.Text;
            obj_bll.insert(obj);
            hienthi();
            MessageBox.Show("Lưu thành công!", "Thông Báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            obj.Ngaynhap = DateTime.Parse(txtNgayNhap.Text);
            obj.SoPN = txtSoPN.Text;
            obj.SoDH = cbSoDH.Text;
            obj_bll.update(obj);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông Báo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNgayNhap.Enabled = true;
            txtSoPN.Enabled = true;
            cbSoDH.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtNgayNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayNhap"].Value.ToString();
            txtSoPN.Text = dataGridView1.Rows[e.RowIndex].Cells["SoPN"].Value.ToString();
            cbSoDH.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDH"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không!","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obj.SoPN = txtSoPN.Text;
                obj_bll.delete(obj);
                hienthi();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnXemchitiet")
            {
                fCTPNHAP fCTPNHAP = new fCTPNHAP(dataGridView1.Rows[e.RowIndex].Cells["SoPN"].Value.ToString());
                fCTPNHAP.ShowDialog();
            }
           
        }
    }
}
