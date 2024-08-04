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

namespace BAI_TAP_TREN_LOP
{
    public partial class Form11 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = NGUYENKHANH\NGUYENKHANH; Initial Catalog = Q_72DCHT20020_QLCH; Integrated Security = True");
        public Form11()
        {
            InitializeComponent();
        }
        private void load_cbMaHang()
        {
            //b1:kết nốt đến database
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2: tạo đối tượng conmand để thực hiện lệnh truy vấn 
            String sql1 = "select *From Hang";
            SqlCommand cmd = new SqlCommand(sql1, con);
            //b3: tạo đối tượng datAdapter để lấy kết quả từ cmd
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            //b4: đổ dữ liệu từ adapter vào database
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmd.Dispose();
            con.Close();
            //thêm 1 dòng vào vị trí đầu tiên của bảng tb;
            DataRow row = tb.NewRow();
            row["ma_hang"] = "";
            row["ten_hang"] = "--- Chọn một hàng hoa ---";
            tb.Rows.InsertAt(row, 0);
            //b5:đổ dữ liệu từ tb vào combobox
            comboBoxMaHang.DataSource = tb;
            comboBoxMaHang.DisplayMember = "ten_hang";
            comboBoxMaHang.ValueMember = "ma_hang";
        }
        private void load_grvDongHang()
        {
            //b1:kết nốt đến database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2: tạo đối tượng conmand để thực hiện lệnh truy vấn 
            String sql1 = "select *From DONGPHIEU";
            SqlCommand cmd = new SqlCommand(sql1, con);
            //b3: tạo đối tượng datAdapter để lấy kết quả từ cmd
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            //b4: đổ dữ liệu từ adapter vào database
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmd.Dispose();
            con.Close();
            //b5:đưa dữ liệu vào dataGridView
            dataGridView1.DataSource= tb;
            dataGridView1.Refresh();
        }
        private void checkTrungSoPhieu(String p_sophieu,ref int p_kq)
        {
            //b1:kết nối tới DB
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b2:tạo đối tượng conmand để gọi store và truyền giá trị vào tham số của store
            SqlCommand cmd = new SqlCommand("Check_TrungSoPhieu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.NVarChar, 50).Value=p_sophieu;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            p_kq = (int)kq.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            load_grvDongHang();
            load_cbMaHang();
            button2.Visible =false;
            button3.Visible=false;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu đổ người dùng nhập vào trên các control
            string p_sophieu = textSoPhieu.Text.Trim();
            String p_mahang = comboBoxMaHang.SelectedValue.ToString();
            // kiểm tra trung ma hàng
            int kq = 0;
            checkTrungSoPhieu(p_mahang, ref kq);
            if(kq == 1)
            {
                textSoPhieu.Focus();
                MessageBox.Show("Trùng số phiếu !");
                return;
            }
            // kiểm tra đơn giá không được rỗng
            String p_dongia = textDonGia.Text.Trim();
            if(p_dongia == "")
            {
                textDonGia.Focus();
                MessageBox.Show("Phải nhập đơn giá ");
                return;
            }
            String p_soluong = textSoLuong.Text.Trim();
            if (p_soluong == "")
            {
                textSoLuong.Focus();
                MessageBox.Show("Phải nhập đơn giá ");
                return;
            }
            //b2:kết nốt database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3: tạo đối tượng command để chèn dữ liệu vào bản đồng phiếu 
            String sql = "INSERT INTO DONGPHIEU values('"+p_sophieu+"',N'"+p_mahang+"',N'"+p_dongia+"',N'"+p_soluong+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            load_grvDongHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//lấy chỉ số của dòng được click vào 
            textSoPhieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBoxMaHang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textDonGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textSoLuong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textSoPhieu.Enabled = false;
            button2.Visible = true;
            button3.Visible = true;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //b1: lấy dữ liệu từ caca control trên from dưa vào biến 
            string p_sophieu = textSoPhieu.Text.Trim();
            String p_mahang = comboBoxMaHang.SelectedValue.ToString();
            String p_dongia = textDonGia.Text.Trim();
            String p_soluong = textSoLuong.Text.Trim();
            //b2: kết nốt databasse
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b3 tạo đối tượng command để sửa dữ liệu trong bảng 
            String p_sql = "update DONGPHIEU set ma_hang = '" + p_mahang + "'where so_phieu = '" + p_sophieu + "'";
            SqlCommand cmd = new SqlCommand(p_sql,con);
            cmd.ExecuteNonQuery();  
            cmd.Dispose();
            con.Close();
            load_grvDongHang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //b1 lấy số phiếu trên control
            string p_sophieu = textSoPhieu.Text.Trim();
            //b2: kết nốt databasse
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //tạo đối tượng command để tiến hành xóa số phiếu 
            SqlCommand cmd = new SqlCommand("Delete From DONGPHIEU where so_phieu = '"+p_sophieu+"'",con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close() ;   
            load_grvDongHang();
            MessageBox.Show("Xóa Thành Công ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textSoPhieu.Text = "";
            textSoLuong.Text = "";
            textDonGia.Text = "";
            load_cbMaHang();
            textSoPhieu.Enabled = true;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }
    }
}
