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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NGUYENKHANH\\NGUYENKHANH;Initial Catalog=Q_72DCHT20020_QLCH;Integrated Security=True");
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            loadGrVang();
            load_grv();


        }
        private void loadGrVang()
        {
            // b1 : link Database
            if(con.State == ConnectionState.Closed) { 
                con.Open();
            }
            //b2: tạo đối tượng command de thuc hien cau lenh truy van
            SqlCommand cmd = new SqlCommand("Select * From HANG",con);
            //b3 : tạo đối tượng dataAdapter để lây kết quả từ cmd
            SqlDataAdapter da  = new SqlDataAdapter();
            da.SelectCommand= cmd;
            // b4 : đổ dữ liệu từ DB vào datatable 
            DataTable tb  = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //b5: đưa kết quả từ tb vào DataGridView 
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        private void load_grv()
        {
            // b1: kết nối database 
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            // b2: tạo đối tượng command để thực hiện lệnh truy vấn
            SqlCommand cmd  = new SqlCommand("Select * From HANG",con);
            // b3: tạo đôi tượng dataAdapter để lây kêt quả từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand= cmd;
            // b4: đổ dữ liệu từ da vào datable
            DataTable tb  = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            // thêm một dòng vào vị trí đầu tiên của bảng tb
            DataRow r  = tb.NewRow();
            r["ma_Hang"] = "";
            r["ten_Hang"] = "---chọn một hàng";
            tb.Rows.InsertAt(r,0);
            // b5: do dữ liệu từ tb vào combobox
            comboBox1.DataSource = tb;
            comboBox1.DisplayMember= "ten_Hang";
            comboBox1.ValueMember = "ma_Hang";


        }
    }
}
   