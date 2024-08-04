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
    public partial class Form4 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnXemtt_Click(object sender, EventArgs e)
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from VATTU ";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
                String maVT = reader.GetString(0);
                String tenVT = reader.GetString(1);
                String donVT = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                ListViewItem listViewItem= new ListViewItem(maVT); 
                listViewItem.SubItems.Add(tenVT);
                listViewItem.SubItems.Add(donVT);
                listViewItem.SubItems.Add(phanTram.ToString());
                 lsVTT.Items.Add(listViewItem);   
            }
            reader.Close();
            sqlCon.Close();
        }
    }
}
