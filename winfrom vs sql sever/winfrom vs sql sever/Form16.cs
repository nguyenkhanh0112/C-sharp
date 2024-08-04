using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfrom_vs_sql_sever
{
    public partial class Form16 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form16()
        {
            InitializeComponent();
        }
        bool kt = false;
        private void Form16_Load(object sender, EventArgs e)
        {
            if(sqlCon == null)
            {
                sqlCon= new SqlConnection(strCon);
            }
            String query = "select * from NHACC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
           
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            kt = false;
            listNCC.DataSource = ds.Tables[0];
            listNCC.ValueMember = "MaNCC";
            listNCC.DisplayMember = "TenNCC";
            kt = true;

        }
        private void listNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listNCC.SelectedIndex == -1) { return; }
            if(kt==false) { return; }

            String maNCC = (String)listNCC.SelectedValue;
            String query = "select * from DONDH where MaNCC ='" + maNCC + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvDonHang.DataSource = ds.Tables[0];


        }
    }
}
