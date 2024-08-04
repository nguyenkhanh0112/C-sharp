using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Runtime.InteropServices;

namespace DAL
{
    public class VatTuDAL:Database
    {
        // Hàm hiển thị danh sách vật tư 
        public List<VatTu> HienThiDanhSachVatTu()
        {
            OpenConnection();
            List<VatTu> ds = new List<VatTu>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VATTU";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String ma = reader.GetString(0);
                String ten = reader.GetString(1);
                String dvTinh = reader.GetString(2);
                float phantram = reader.GetFloat(3);

                VatTu vatTu = new VatTu();
                vatTu.MaVTu = ma;
                vatTu.TenVTu = ten;
                vatTu.DvTinh = dvTinh;
                vatTu.PhanTram = phantram;
                ds.Add(vatTu);
            }
            reader.Close();
            CloseConnection();
            return ds;
        }
        // hàm thêm vật tư                  
        public bool ThemVatTu(VatTu vt)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into VATTU values(@ma,@ten,@donvitinh,@phantram)";
            SqlParameter sqlParameterMa = new SqlParameter("@ma", SqlDbType.Char);
            SqlParameter sqlParameterTen = new SqlParameter("@ten", SqlDbType.Char);
            SqlParameter sqlParameterDvtinh= new SqlParameter("@donvitinh", SqlDbType.Char);
            SqlParameter sqlParameterPhantram= new SqlParameter("@phantram", SqlDbType.Float);

            cmd.Parameters.Add(sqlParameterMa).Value=vt.MaVTu;
            cmd.Parameters.Add(sqlParameterTen).Value=vt.TenVTu;
            cmd.Parameters.Add(sqlParameterDvtinh).Value=vt.DvTinh;
            cmd.Parameters.Add(sqlParameterPhantram).Value=vt.PhanTram;


            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();

            if (kq > 0)
            {
               return true;
            }else
            { 
                return false; 
            }
            CloseConnection();  
        }
        //Hàm sửa vật tư 
        public bool SuaVatTu(VatTu vatTu)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update VATTU set MaVTU = @mavt,TenVTu = @tenvt,DvTinh = @dvtinh,PhanTram =@phantram where  MaVTU = @mavt";
            SqlParameter parameterMaVtu = new SqlParameter("@mavt", SqlDbType.Char);
            SqlParameter parameterTenvt = new SqlParameter("@tenvt", SqlDbType.Char);
            SqlParameter parameterDVTinh = new SqlParameter("@dvtinh", SqlDbType.Char);
            SqlParameter parameterPhanTram = new SqlParameter("@phantram", SqlDbType.Float);

            cmd.Parameters.Add(parameterMaVtu).Value = vatTu.MaVTu;
            cmd.Parameters.Add(parameterTenvt).Value = vatTu.TenVTu;
            cmd.Parameters.Add(parameterDVTinh).Value = vatTu.DvTinh;
            cmd.Parameters.Add(parameterPhanTram).Value = vatTu.PhanTram;
            
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                return true;
            }
            else
                return false;

            CloseConnection();
        }
        public bool XoaVatTu(VatTu vt)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From VATTU where MaVTu = @mavt";
            SqlParameter parameterMavt = new SqlParameter("@mavt", SqlDbType.Char);
            cmd.Parameters.Add(parameterMavt).Value = vt.MaVTu;
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                return true;
            }
            else return false;
            CloseConnection();
        }
      
    }
}
