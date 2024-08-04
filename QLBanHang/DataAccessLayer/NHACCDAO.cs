using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class NHACCDAO
    {
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("sp_NHACC_select_all", null);
        }
        public DataTable GetDaTaByID(String MaNCC)
        {
            SqlParameter[] parameters = { new SqlParameter("@MaNCC", MaNCC) };         
            return db.GetData("sp_NHACC_select_Byid", parameters);
        }
        public int insert(NHACC obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC",obj.MaNCC),
                new SqlParameter("@TenNCC",obj.TenNCC),
                new SqlParameter("@DiaChi",obj.DiaChi),
                new SqlParameter("@DienThoai",obj.DienThoai)
            };
            return db.ExecuteSQL("sp_NHACC_insert", parameters);
        }
        public int update(NHACC obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC",obj.MaNCC),
                new SqlParameter("@TenNCC",obj.TenNCC),
                new SqlParameter("@DiaChi",obj.DiaChi),
                new SqlParameter("@DienThoai",obj.DienThoai)
            };
            return db.ExecuteSQL("sp_NHACC_update", parameters);
        }
        public int delete(NHACC obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC",obj.MaNCC)
            };
            return db.ExecuteSQL("sp_NHACC_delete", parameters);
        }

        public DataTable GetData1()
        { 
            return db.GetData("sp_NHACC_select_all");
        }
        public DataTable GetData1(String MaNCC)
        {
            SqlParameter[] sql = { new SqlParameter("@MaNCC", MaNCC) };
            return db.GetData("sp_NHACC_select_Byid", sql);
        }
      
    }
}
