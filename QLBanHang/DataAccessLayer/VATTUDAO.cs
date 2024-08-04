using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class VATTUDAO
    {
       
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("sp_VATTU_select_all", null);
        }
        public DataTable GetDataByid(String MaVTu)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MaVTu",MaVTu)
            };
            return db.GetData("sp_VATTU_select_ById", sqlParameters);
        }
        public int insert(VATTU obj)
        {
            SqlParameter[] sqlParameters =
          {
                new SqlParameter("@MaVTu",obj.MaVTu),
                new SqlParameter("@TenVT",obj.TenVT),
                new SqlParameter("@Dvtinh",obj.DvTinh),
                new SqlParameter("@PhanTram",obj.PhanTram)
            };
            return db.ExecuteSQL("sp_VATTU_insert", sqlParameters);
        }
        public int delete(VATTU obj)
        {
            SqlParameter[] sqlParameters =
          {
                new SqlParameter("@MaVTu",obj.MaVTu),
                
            };
            return db.ExecuteSQL("sp_VATTU_delete", sqlParameters);
        }
        public int update(VATTU obj)
        {
            SqlParameter[] sqlParameters =
          {
                new SqlParameter("@MaVTu",obj.MaVTu),
                new SqlParameter("@TenVT",obj.TenVT),
                new SqlParameter("@Dvtinh",obj.DvTinh),
                new SqlParameter("@PhanTram",obj.PhanTram)
            };
            return db.ExecuteSQL("sp_VATTU_update", sqlParameters);
        }
    }
}
