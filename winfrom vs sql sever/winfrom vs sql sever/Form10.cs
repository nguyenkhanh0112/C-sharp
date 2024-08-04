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
    public partial class Form10 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form10()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;// thủ tục nội tại
            cmd.CommandText = "hienThiDSPhieuNhap";
            cmd.Connection = sqlCon;
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                String SoPN = reader.GetString(0);
                DateTime ngaynhap = reader.GetDateTime(1);
                String soDH = reader.GetString(2);

                ListViewItem listViewItem = new ListViewItem(SoPN);
                listViewItem.SubItems.Add(ngaynhap.ToString("MM/dd/yyyy"));
                listViewItem.SubItems.Add(soDH);

                listView1.Items.Add(listViewItem);  
            }
            reader.Close();
            
        }
        private void HienthichitietPN(String pn)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand cmd = new SqlCommand("hienthichitietCTPNHAP");
            cmd.CommandType = CommandType.StoredProcedure;// thủ tục nội tại
            //cmd.CommandText = "hienthichitietCTPNHAP";
            SqlParameter parameterpn = new SqlParameter("@sopn", SqlDbType.Char);
          
            parameterpn.Value = pn;
            cmd.Parameters.Add(parameterpn);




            cmd.Connection = sqlCon;
            cmd.ExecuteNonQuery();



            SqlDataReader reader = cmd.ExecuteReader();
            listViewChitiet.Items.Clear();
            while(reader.Read()) { 
               
                String maVT = reader.GetString(1);
                int slNhap = reader.GetInt32(2);
                decimal Dgnhap = reader.GetDecimal(3);

                ListViewItem listViewItem = new ListViewItem(pn);
                listViewItem.SubItems.Add(maVT);
                listViewItem.SubItems.Add(slNhap.ToString());
                listViewItem.SubItems.Add(Dgnhap.ToString());

                listViewChitiet.Items.Add(listViewItem);
            }
            reader.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;


            ListViewItem listViewItem = listView1.SelectedItems[0];
            String soPN = listViewItem.SubItems[0].Text.Trim();
            HienthichitietPN(soPN);
        }

        private void listViewChitiet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
