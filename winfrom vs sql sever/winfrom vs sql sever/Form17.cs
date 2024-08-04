using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfrom_vs_sql_sever
{
    public partial class Form17 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        BindingSource source = null;
        public Form17()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            String query = "select * from VATTU";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds= new DataSet();
            adapter.Fill(ds,"Table_VT");
            source = new BindingSource(ds, "Table_VT");
            textMaVT.DataBindings.Add("Text", source, "MaVTu");
            textTenVT.DataBindings.Add("Text", source, "TenVTu");
            textDVtinh.DataBindings.Add("Text", source, "DvTinh");
            textPhanTram.DataBindings.Add("Text", source, "PhanTram");
            lplPhanTrang.Text = "Trang " + (source.Position + 1) + " of " + source.Count;  


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            source.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            source.Position = source.Count-1;
            lplPhanTrang.Text = "Trang " + (source.Position + 1) + " of " + source.Count;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            source.Position = 0;
            lplPhanTrang.Text = "Trang " + (source.Position + 1) + " of " + source.Count;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (source.Position > 0)
            {
                source.Position = source.Position - 1;
                lplPhanTrang.Text = "Trang " + (source.Position+1) + " of " + source.Count;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (source.Position < source.Count)
            {
                source.Position+= 1;
                lplPhanTrang.Text = "Trang " + (source.Position+1) + " of " + source.Count;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            source.EndEdit();
            int kt = adapter.Update(ds.Tables["Table_VT"]);
            if (kt > 0)
            {
                MessageBox.Show("Xóa Thành Công!");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            source.RemoveCurrent();
            int kt = adapter.Update(ds.Tables["Table_VT"]);
            if (kt > 0)
            {
                MessageBox.Show("Lưu Thành Công!");
            }
            else
            {
                MessageBox.Show("Lưu Thất bại!");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có thực sự muốn thoát không!", "Hop thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes) {
                Close();
            }
        }
    }
}
