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
    public class DONDHDAO
    {
       
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("sp_DONDH_select_all", null);

        }
        public DataTable GetDataByID(String SoDH)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoDH",SoDH)
            };
            return db.GetData("sp_DONDH_select_Byid", parameters); 
        }
        public int insert(DONDH obj)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoDH",obj.SoDH),
                new SqlParameter("@NgayDH",obj.NgayDH),
                new SqlParameter("@MaNCC",obj.MaNCC)
            };
            return db.ExecuteSQL("sp_DONDH_insert", parameters);
        }
        public int update(DONDH obj)
        {
            SqlParameter[] parameters =
          {
                new SqlParameter("@SoDH",obj.SoDH),
                new SqlParameter("@NgayDH",obj.NgayDH),
                new SqlParameter("@MaNCC",obj.MaNCC)
            };
            return db.ExecuteSQL("sp_DONDH_update", parameters);
        }
        public int delete(DONDH obj)
        {
            SqlParameter[] parameters =
          {
                new SqlParameter("@SoDH",obj.SoDH),
         
            };
            return db.ExecuteSQL("sp_DONDH_update", parameters);
        }
    }
}
