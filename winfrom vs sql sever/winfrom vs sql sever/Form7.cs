using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winfrom_vs_sql_sever
{
    public partial class From7 : Form
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection sqlCon = null;
        public From7()
        {
            InitializeComponent();
        }

        private void From7_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from NHOMMONAN";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                String idMonan = reader.GetString(0);
                String idNhommonan = reader.GetString(1);

                String line = idMonan.Trim() + " / " + idNhommonan;

                comboBox1.Items.Add(line);
            }
            reader.Close();
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            String line = comboBox1.SelectedItem.ToString();
            String[] arr = line.Split('/');
            String IDnhomMA = arr[0];

            HienThiMA_load(IDnhomMA);
        }
        private void HienThiMA_load(string IDnhomMA)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
           // cmd.CommandText= "select * from MONAN where IDNhomMA = '"+ IDnhomMA + "'";
            cmd.CommandText = "Select * from MONAN where IDNhomMA = @IDnhomMA";
            SqlParameter parameterIDnhomMA = new SqlParameter("@IDnhomMA", SqlDbType.Char);
            parameterIDnhomMA.Value = IDnhomMA;
            cmd.Parameters.Add(parameterIDnhomMA);
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

        private void btnkodungparameter_Click(object sender, EventArgs e)
        {
            String idMonan = txtIDmonan.Text.Trim();
            String idNhommonan =txtIDnhommonan.Text.Trim() ;
            String tenMonan = txtTenmonan.Text.Trim();
            String donVitinh = txtDonvitinh.Text.Trim();
            String donGia =txtDongia.Text.Trim();
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update MONAN set IDMA = N'" 
                + idMonan + "',IDNhomMA=N'" 
                + idNhommonan + "',TenMA=N'" 
                + tenMonan + "',DonViTinh=N'" 
                + donVitinh + "',DonGiaMA=N'" 
                + donGia + "' where IDMA =N'"+idMonan+"'";
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("chỉnh sửa thông tin thành công ");
                HienThiMA_load(idNhommonan);
            }
            else
                MessageBox.Show("chỉnh sửa thông tin không thành công ");
           
        }

        private void btncodungparameter_Click(object sender, EventArgs e)
        {
            String idMonan = txtIDmonan.Text.Trim();
            String idNhommonan = txtIDnhommonan.Text.Trim();
            String tenMonan = txtTenmonan.Text.Trim();
            String donVitinh = txtDonvitinh.Text.Trim();
            String donGia = txtDongia.Text.Trim();
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update MONAN set IDMA = @idMonan,IDNhomMA= @idNhommonan,TenMA= @tenMonan,DonViTinh= @donVitinh,DonGiaMA= @donGia where IDMA =@idMonan";
            SqlParameter parameterIDMA = new SqlParameter("@idMonan", SqlDbType.Char);
            SqlParameter parameterIDNhomMA = new SqlParameter("@idNhommonan", SqlDbType.Char);
            SqlParameter parameterTenMA = new SqlParameter("@tenMonan", SqlDbType.NVarChar);
            SqlParameter parameterDonViTinh = new SqlParameter("@donVitinh", SqlDbType.NVarChar);
            SqlParameter parameterDonGiaMA = new SqlParameter("@donGia", SqlDbType.Real);

            parameterIDMA.Value = idMonan;
            parameterIDNhomMA.Value = idNhommonan;
            parameterTenMA.Value = tenMonan;
            parameterDonViTinh.Value = donVitinh;
            parameterDonGiaMA.Value = donGia;

            cmd.Parameters.Add(parameterIDMA);
            cmd.Parameters.Add(parameterIDNhomMA);
            cmd.Parameters.Add(parameterTenMA);
            cmd.Parameters.Add(parameterDonViTinh);
            cmd.Parameters.Add(parameterDonGiaMA);

            cmd.Connection = sqlCon;
            cmd.ExecuteNonQuery();
            HienThiMA_load(idNhommonan);

            //int kq = cmd.ExecuteNonQuery();
            //if (kq > 0)
            //{
            //    MessageBox.Show("chỉnh sửa thông tin thành công ");
            //    HienThiMA_load(idNhommonan);
            //}
            //else
            //    MessageBox.Show("chỉnh sửa thông tin không thành công ");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0) { return; }

            // lấy phần từ được chọn 
            ListViewItem listView = listView1.SelectedItems[0];
            
            // hiển thị thông tin từ listview sang texbox;
            txtIDmonan.Text = listView.SubItems[0].Text;
            txtIDnhommonan.Text = listView.SubItems[1].Text;
            txtTenmonan.Text = listView.SubItems[2].Text;
            txtDonvitinh.Text = listView.SubItems[3].Text;
            txtDongia.Text = listView.SubItems[4].Text;
        }
    }
}
