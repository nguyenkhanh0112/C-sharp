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
    public partial class Form5 : Form
    {
        string strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;    
        public Form5()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if(sqlCon == null) 
                sqlCon = new SqlConnection(strCon);
            if(sqlCon.State == ConnectionState.Closed)
                 sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NHACC";
            cmd.Connection = sqlCon;

            SqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read()) {
                String maNCC = reader.GetString(0);
                String tenNCC = reader.GetString(1);

                String line = maNCC + "/" + tenNCC;

                lsbNCC.Items.Add(line);
            }
            reader.Close();
            sqlCon.Close();
        }

        private void lsbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbNCC.SelectedIndex == -1)
                return;
            String line = lsbNCC.SelectedItem.ToString();
            String[] arr = line.Split('/');
            string maNCC = arr[0];
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DONDH where MaNCC = @maNCC";
            SqlParameter parmaNCC = new SqlParameter("@maNCC", SqlDbType.Char);
            parmaNCC.Value = maNCC.Trim();
            cmd.Parameters.Add(parmaNCC);
            cmd.Connection = sqlCon;

            // thực thi truy vấn 
            SqlDataReader reader = cmd.ExecuteReader();
            lsvDonDH.Items.Clear();
            while(reader.Read())
            {
                String soDH = reader.GetString(0);
                DateTime ngayDH = reader.GetDateTime(1);
                String maNCC1 = reader.GetString(2);
                
                ListViewItem listViewItem = new ListViewItem(soDH);
                listViewItem.SubItems.Add(ngayDH.ToString());
                listViewItem.SubItems.Add(maNCC1);
                lsvDonDH.Items.Add(listViewItem);
            }
            reader.Close();
            sqlCon.Close();

        }
    }
}
