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
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        String strCon =Properties.Settings.Default.StringCon;
        SqlConnection sqlCon = null;

        private void load_openketnoi()
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();  
            }

        }
        private void load_closeketnoi()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close(); 
            }
        }
        private void load_hienthi()
        {
            load_openketnoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from tblMayBay ";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd .ExecuteReader();
            lsvDanhsach.Items.Clear();
            lsvDanhsach.Groups.Clear();

            ListViewGroup listViewGroup1 = new ListViewGroup("Thương gia");
            lsvDanhsach.Groups.Add(listViewGroup1);

            ListViewGroup listViewGroup2 = new ListViewGroup("Phổ thông");
            lsvDanhsach.Groups.Add(listViewGroup2);

            while (reader.Read())
            {
                int mamaybay = reader.GetInt32(0);
                String tenmay = reader.GetString(1);
                String hangsx = reader.GetString(2);
                int kichthuoc =reader.GetInt32(3);
                int soghe =reader.GetInt32(4);
                String phanloai = reader.GetString(5);

                ListViewItem listViewItem = new ListViewItem(mamaybay.ToString());
                listViewItem.SubItems.Add(tenmay);
                listViewItem.SubItems.Add(hangsx);
                listViewItem.SubItems.Add(kichthuoc.ToString());
                listViewItem.SubItems.Add(soghe.ToString());
                listViewItem.SubItems.Add(phanloai);

                lsvDanhsach.Items.Add(listViewItem);

                if(String.Compare(phanloai,"Thương gia", true) == 0)
                {
                    listViewItem.Group = listViewGroup1;
                }else
                    listViewItem.Group = listViewGroup2;

                listViewItem.Tag = mamaybay;
            }
            reader.Close();
            load_closeketnoi();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            load_hienthi();
        }
        private void hienthichitiet_load(int ma)
        {
            load_openketnoi();
            SqlCommand cmd = new SqlCommand("Select * from tblMaybay where IDMayBay =@ma",sqlCon);
            SqlParameter sqlParameter = new SqlParameter("@ma", SqlDbType.Int) ;
            cmd.Parameters.Add(sqlParameter).Value = ma;

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read()) {
                int mamaybay = reader.GetInt32(0);
                String tenmay = reader.GetString(1);
                String hangsx = reader.GetString(2);
                int kichthuoc = reader.GetInt32(3);
                int soghe = reader.GetInt32(4);
                String phanloai = reader.GetString(5);

                txtMamaybay.Text = mamaybay.ToString();
                txtTenmaybay.Text = tenmay.ToString();
                txtkichthuoc.Text = kichthuoc.ToString();
                if (hangsx == "Vietnam Arilines") cbHangsanxuat.SelectedIndex = 0;
                else if (hangsx == "Vietjet Air") cbHangsanxuat.SelectedIndex = 1;
                else if (hangsx == "Jetstar Pacific Airlines") cbHangsanxuat.SelectedIndex = 2;
                else if (hangsx == "Bamboo Airways") cbHangsanxuat.SelectedIndex = 3;

                if (soghe == 100) cbSoghe.SelectedIndex = 0;
                else if (soghe == 200) cbSoghe.SelectedIndex =1;
                else if (soghe == 300) cbSoghe.SelectedIndex = 2;

                if (phanloai == "Thương gia") cbPhanloai.SelectedIndex = 0;
                else cbPhanloai.SelectedIndex = 1;
            }
            reader.Close();

        }

        private void lsvDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhsach.SelectedItems.Count == 0) return;
            ListViewItem list = lsvDanhsach.SelectedItems[0];
            int ma = (int) list.Tag;
            hienthichitiet_load(ma);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            load_openketnoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblMaybay values (@idmaybay ,  @tenmaybay, @hangsx,@kichthuoc, @soghe,@phanloai) ";
            SqlParameter parameterIDmaybay = new SqlParameter("@idmaybay", SqlDbType.Int);
            SqlParameter parameterTenMayBay = new SqlParameter("@tenmaybay", SqlDbType.NVarChar);
            SqlParameter parameterHangSX = new SqlParameter("@hangsx", SqlDbType.NVarChar);
            SqlParameter parameterKichThuoc = new SqlParameter("@kichthuoc", SqlDbType.Int);
            SqlParameter parameterSoGhe = new SqlParameter("@soghe", SqlDbType.Int);
            SqlParameter parameterPhanLoai = new SqlParameter("@phanloai", SqlDbType.NVarChar);

            cmd.Parameters.Add(parameterIDmaybay).Value= txtMamaybay.Text.Trim();
            cmd.Parameters.Add(parameterTenMayBay).Value = txtMamaybay.Text.Trim();
            cmd.Parameters.Add(parameterHangSX).Value = cbHangsanxuat.SelectedItem.ToString();
            cmd.Parameters.Add(parameterKichThuoc).Value = txtkichthuoc.Text.Trim();
            cmd.Parameters.Add(parameterSoGhe).Value= cbSoghe.SelectedItem.ToString();
            cmd.Parameters.Add(parameterPhanLoai).Value = cbPhanloai.SelectedItem.ToString();

            cmd.Connection = sqlCon;
            int kq= cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Lưu dữ liệu thành công!");
                load_hienthi();
            }
            else
            {
                MessageBox.Show("lưu  dữ liêu thất bại!");
            }
            load_closeketnoi();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMamaybay.Text = "";
            txtTenmaybay.Text = "";
            txtkichthuoc.Text = "";
            cbHangsanxuat.SelectedIndex = 0;
            cbSoghe.SelectedIndex = 0;
            cbPhanloai.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            load_openketnoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tblMaybay set IDMayBay=@idmaybay,TenMayBay=@tenmaybay,HangSX=@hangsx,KichThuoc=@kichthuoc,SoGhe=@soghe,PhanLoai=@phanloai where IDMayBay=@idmaybay ";
            SqlParameter parameterIDmaybay = new SqlParameter("@idmaybay", SqlDbType.Int);
            SqlParameter parameterTenMayBay = new SqlParameter("@tenmaybay", SqlDbType.NVarChar);
            SqlParameter parameterHangSX = new SqlParameter("@hangsx", SqlDbType.NVarChar);
            SqlParameter parameterKichThuoc = new SqlParameter("@kichthuoc", SqlDbType.Int);
            SqlParameter parameterSoGhe = new SqlParameter("@soghe", SqlDbType.Int);
            SqlParameter parameterPhanLoai = new SqlParameter("@phanloai", SqlDbType.NVarChar);

            cmd.Parameters.Add(parameterIDmaybay).Value = txtMamaybay.Text.Trim();
            cmd.Parameters.Add(parameterTenMayBay).Value = txtMamaybay.Text.Trim();
            cmd.Parameters.Add(parameterHangSX).Value = cbHangsanxuat.SelectedItem.ToString();
            cmd.Parameters.Add(parameterKichThuoc).Value = txtkichthuoc.Text.Trim();
            cmd.Parameters.Add(parameterSoGhe).Value = cbSoghe.SelectedItem.ToString();
            cmd.Parameters.Add(parameterPhanLoai).Value = cbPhanloai.SelectedItem.ToString();

            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Cập nhập liệu thành công!");
                load_hienthi();
            }
            else
            {
                MessageBox.Show("Cập nhập dữ liêu thất bại!");
            }
            load_closeketnoi();
        }
         
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhsach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dư liệu xóa!");
                return;
            }
            ListViewItem listViewItem = lsvDanhsach.SelectedItems[0];
            int ma = (int)listViewItem.Tag;
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không ", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq == DialogResult.Yes)
            {
                
                XoaDulieu(ma);
            }


        }

        private void XoaDulieu(int ma)
        {
            load_openketnoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tblMaybay where IDMayBay =@ma";
            SqlParameter parameter = new SqlParameter("@ma",SqlDbType.Int);
            cmd.Parameters.Add(parameter).Value = ma;
            cmd.Connection = sqlCon;
            int kq=cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
                load_hienthi();
            }
            else
                MessageBox.Show("Xóa dữ liệu thất bại!");
        }
        

        private void btnXuatExecl_Click(object sender, EventArgs e)
        {
            load_openketnoi();
            String query = "select * from tblMaybay ";
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlCon);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            ExportExcel(tb, "DSMayBay");

        }
        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = "THỐNG KÊ CÁC HÃNG MÁY BAY";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "IDMayBay";
            cl1.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Máy Bay";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Hãng Sản Xuất";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Kích Thước";
            cl4.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số Ghế";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Phân Loại";
            cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";


            //Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            //cl7.Value2 = "ĐIỂM";
            //cl7.ColumnWidth = 10;
            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "GHI CHÚ";
            //cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
