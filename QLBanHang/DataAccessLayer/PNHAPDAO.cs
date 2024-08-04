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
    public class PNHAPDAO
    {
        dbConnect db = new dbConnect();
        public DataTable GetDaTa()
        {
           return  db.GetData("sp_PNHAP_select_all", null);
        }
        public DataTable GetDataById(String SoPN)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPN",SoPN)
            };
            return db.GetData("sp_PNHAP_select_ById", parameters);
        }
        public int insert(PNHAP obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPN",obj.SoPN),
                new SqlParameter("@Ngaynhap",obj.Ngaynhap),
                new SqlParameter("@SoDH",obj.SoDH)
            };
            return db.ExecuteSQL("sp_PNHAP_insert", parameters);
        }
        public int update(PNHAP obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPN",obj.SoPN),
                new SqlParameter("@Ngaynhap",obj.Ngaynhap),
                new SqlParameter("@SoDH",obj.SoDH)
            };
            return db.ExecuteSQL("sp_PNHAP_update", parameters);
        }
        public int delete(PNHAP obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPN",obj.SoPN),
            

               
            };
            return db.ExecuteSQL("sp_PNHAP_delete", parameters);
        }

    }
}
