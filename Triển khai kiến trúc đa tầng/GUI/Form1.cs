using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachVatTu(); 
        }

        private void HienThiDanhSachVatTu()
        {
            VatTuBLL vtbll = new VatTuBLL();
            List<VatTu> ds = vtbll.HienThiDanhSachVatTu();
            listView1.Items.Clear();
            foreach(VatTu item in ds) {
                ListViewItem listViewItem = new ListViewItem(item.MaVTu);
                listViewItem.SubItems.Add(item.TenVTu);
                listViewItem.SubItems.Add(item.DvTinh);
                listViewItem.SubItems.Add(item.PhanTram.ToString());

                listView1.Items.Add(listViewItem);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            VatTu vt = new VatTu();
            vt.MaVTu = txtMVT.Text.Trim();
            vt.TenVTu = txtTenVT.Text.Trim();
            vt.DvTinh = txtDvTinh.Text.Trim();
            vt.PhanTram =float.Parse( txtPTram.Text.Trim());

            VatTuBLL vtbll = new VatTuBLL();
            bool kt = vtbll.ThemVatTu(vt);

            if (kt)
            {
                MessageBox.Show("Thêm thành công");
                HienThiDanhSachVatTu();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            VatTu vt = new VatTu();
            vt.MaVTu = txtMVT.Text.Trim();
            vt.TenVTu = txtTenVT.Text.Trim();
            vt.DvTinh = txtDvTinh.Text.Trim();
            vt.PhanTram = float.Parse(txtPTram.Text.Trim());

            VatTuBLL vatTuBLL = new VatTuBLL();
            bool kq = vatTuBLL.SuaVatTu(vt);
            if (kq)
            {
                MessageBox.Show("Sửa  dữ liệu thành công!");
                HienThiDanhSachVatTu();
            }
            else
                MessageBox.Show("Sửa dữ liệu không thành công!");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0) { return; }

            ListViewItem listViewItem = listView1.SelectedItems[0];

            txtMVT.Text = listViewItem.SubItems[0].Text;
            txtTenVT.Text = listViewItem.SubItems[1].Text;
            txtDvTinh.Text = listViewItem.SubItems[2].Text;
            txtPTram.Text = listViewItem.SubItems[3].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            VatTu vt = new VatTu();
            vt.MaVTu = listView1.SelectedItems[0].Text.Trim();

            VatTuBLL vatTuBLL = new VatTuBLL();
            bool kq = vatTuBLL.XoaVatTu(vt);
            if (kq)
            {
                MessageBox.Show("Xóa thành công!");
                HienThiDanhSachVatTu();
            }
            else
                MessageBox.Show("Xóa không thành công!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có thực sự muốn thoát không!", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes)
            {
               this.Close();
            }
        }
    }
}
