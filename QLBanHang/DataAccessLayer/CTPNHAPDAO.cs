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
    public class CTPNHAPDAO
    {
        
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("sp_CTPNHAP_select_all",null);
        }
        public DataTable GetDataById(String SoPN) {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPN",SoPN)

            };
            return db.GetData("sp_CTPNHAP_select_ById", parameters); 
        }
        public int insert(CTPNHAP obj)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter("@SoPN",obj.SoPn),
            new SqlParameter("@MaVTu", obj.MaVTu),
            new SqlParameter("@SlNhap", obj.SlNhap),
            new SqlParameter("@DgNhap", obj.DgNhap)
            };
            return db.ExecuteSQL("sp_CTPNHAP_insert", parameters);
        }
        public int update(CTPNHAP obj)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter("@SoPN",obj.SoPn),
            new SqlParameter("@MaVTu", obj.MaVTu),
            new SqlParameter("@SlNhap", obj.SlNhap),
            new SqlParameter("@DgNhap", obj.DgNhap)
            };
            return db.ExecuteSQL("sp_CTPNHAP_update", parameters);
        }
        public int delete(CTPNHAP obj)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter("@SoPN",obj.SoPn),
            new SqlParameter("@MaVTu",obj.MaVTu)
          
            };
            return db.ExecuteSQL("sp_CTPNHAP_delete", parameters);
        }
    }
}
