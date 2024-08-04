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
    public partial class fDONDH : Form
    {
        DONDHBLL bll = new DONDHBLL();
        DONDH obj = new DONDH();
        public fDONDH()
        {
            InitializeComponent();
        }
        void hienthi()
        {
         
            dataGridView1.DataSource =  bll.GetData();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Visible = true,
                Name = "xemchitiet",
                Text = "Xem chi tiết",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cbMaNCC.Text = string.Empty;
            txtNgayDH.Text= string.Empty;
            txtSoDH.Text= string.Empty;
            btnLuu.Enabled = true;
            cbMaNCC.Enabled = true;
            txtNgayDH.Enabled = true;
            txtSoDH.Enabled = true;
        }

        private void fDONDH_Load(object sender, EventArgs e)
        {
            cbMaNCC.Enabled = false;
            txtNgayDH.Enabled = false;
            txtSoDH.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            addDataComboBox();
            hienthi();
           
              
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtNgayDH.Enabled = true;
            cbMaNCC.Enabled = true;
            txtSoDH.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtSoDH.Text = row.Cells["SoDH"].Value.ToString();
                txtNgayDH.Text = row.Cells["NgayDH"].Value.ToString();
                cbMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.MaNCC = cbMaNCC.Text;
            obj.NgayDH =DateTime.Parse(txtNgayDH.Text);
            obj.SoDH = txtSoDH.Text;
            bll.insert(obj);
            hienthi();
            MessageBox.Show("Lưu thành công!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            obj.MaNCC = cbMaNCC.Text;
            obj.NgayDH = DateTime.Parse(txtNgayDH.Text);
            obj.SoDH = txtSoDH.Text;
            bll.update(obj);
            hienthi();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }
        void addDataComboBox()
        {
            NACCCBLL bll1 = new NACCCBLL();
            DataTable db = new DataTable();
            db = bll1.GetData();
            foreach(DataRow row in db.Rows)
            {
                cbMaNCC.Items.Add(row["MaNCC"].ToString());
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không !","Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                obj.MaNCC = cbMaNCC.Text;
                bll.delete(obj);
                hienthi();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xemchitiet")
            {
                fCTDONDH fCTDONDH1 = new fCTDONDH(dataGridView1.Rows[e.RowIndex].Cells["SoDH"].Value.ToString());
                fCTDONDH1.ShowDialog();
            }
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
