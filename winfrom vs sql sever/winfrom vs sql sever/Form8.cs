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
    public partial class Form8 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = "select * from NHOMMONAN";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                String nhomMA = reader.GetString(0);
                String tenNhomMA = reader.GetString(1);

                String line = nhomMA.Trim() + "/" + tenNhomMA;
                comboBox1.Items.Add(line);
            }
            reader.Close();
            sqlCon.Close();
        }
        private void load_hienthi(String NhomMA)
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
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from MONAN where IDNhomMA = '" + NhomMA + "'";
                    cmd.Connection = sqlCon;
                    SqlDataReader reader = cmd.ExecuteReader();
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        String idMonan = reader.GetString(0);
                        String idNhommonan = reader.GetString(1);
                        String tenMonan = reader.GetString(2);
                        String donVitinh = reader.GetString(3);
                        float donGia = reader.GetFloat(4);

                        ListViewItem listViewItem = new ListViewItem(idMonan);
                        listViewItem.SubItems.Add(idNhommonan);
                        listViewItem.SubItems.Add(tenMonan);
                        listViewItem.SubItems.Add(donVitinh);
                        listViewItem.SubItems.Add(donGia.ToString());

                        listView1.Items.Add(listViewItem);
                    }
                    reader.Close();
                    sqlCon.Close();
                
            
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1) return;
            String line = comboBox1.SelectedItem.ToString();
            String[] arr = line.Split('/');
            String NhomMA = arr[0];
            load_hienthi(NhomMA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq1 = MessageBox.Show("Bạn có thực sự muốn xóa hay không ", "Cảnh báo", MessageBoxButtons.YesNo);

            if (kq1 == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count == 0) return;
                ListViewItem listView = listView1.SelectedItems[0];

                String IDMA = listView.SubItems[0].Text.Trim();
                String IDnhomMA = listView.SubItems[1].Text.Trim();
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from MONAN where IDMA = '" + IDMA + "'";
                cmd.Connection = sqlCon;
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("xóa thông tin thành công");
                    load_hienthi(IDnhomMA);
                }
                else
                    MessageBox.Show("Xóa thông tin không thành công");
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kq1 = MessageBox.Show("Bạn có thực sự muốn xóa hay không ", "Cảnh báo", MessageBoxButtons.YesNo);

            if (kq1 == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count == 0) return;
                ListViewItem listView = listView1.SelectedItems[0];

                String IDMA = listView.SubItems[0].Text.Trim();
                String IDnhomMA = listView.SubItems[1].Text.Trim();
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from MONAN where IDMA = @IDMA";
                SqlParameter sqlParameter = new SqlParameter("@IDMA",SqlDbType.Char);
                sqlParameter.Value = IDMA;
                cmd.Parameters.Add(sqlParameter);   
                cmd.Connection = sqlCon;
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("xóa thông tin thành công");
                    load_hienthi(IDnhomMA);
                }
                else
                    MessageBox.Show("Xóa thông tin không thành công");
            }
        }
    }
}
