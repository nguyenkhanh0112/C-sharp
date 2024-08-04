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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
     
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            coparameter();
            loaddgv();
        }
        private void coparameter()
        {
            String ten = txtTen.Text.Trim();
            String MaSv = txtMASV.Text.ToString();
            String DiaChi = txtDiaChi.Text.ToString();
            int SDT = Int32.Parse(txtSDT.Text.ToString());
            String strCon = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyThongTin;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand("sp_them", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter1 = new SqlParameter("@MaSV", SqlDbType.NVarChar, 50);
            SqlParameter sqlParameter2 = new SqlParameter("@Ten", SqlDbType.NVarChar, 50);
            SqlParameter sqlParameter3 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50);
            SqlParameter sqlParameter4 = new SqlParameter("@SDT", SqlDbType.Int);
            sqlParameter1.Value = MaSv;
            sqlParameter2.Value = ten;
            sqlParameter3.Value = DiaChi;
            sqlParameter4.Value = SDT;
            cmd.Parameters.Add(sqlParameter1);
            cmd.Parameters.Add(sqlParameter2);
            cmd.Parameters.Add(sqlParameter3);
            cmd.Parameters.Add(sqlParameter4);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlCon.Close();

        }
        private void kocoparameter()
        {
            String ten = txtTen.Text.ToString();
            String MaSv = txtMASV.Text.ToString();
            String DiaChi = txtDiaChi.Text.ToString();
            int SDT = Int32.Parse(txtSDT.Text.ToString());
            String strCon = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyThongTin;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "insert into SinhVien values (N'" + MaSv + "',N'" + ten + "',N'" + DiaChi + "','" + SDT + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loaddgv();
        }
        private void loaddgv()
        {
            String strCon = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyThongTin;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }
            String sql = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;    
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmd.Dispose();
            sqlCon.Close();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        private void ExportExcel(String parth)
        {
            Excel.Application application= new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i+2,j+1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(parth);
            application.ActiveWorkbook.Saved = true;
        }
        private void ImportExcel(String parth)
        {
            using(ExcelPackage excelPackage = new ExcelPackage(new FileInfo(parth)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for(int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for(int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i,j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }

        }
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xls)|*.xlsx|Excel 2003(*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xls)|*.xlsx|Excel 2003(*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
