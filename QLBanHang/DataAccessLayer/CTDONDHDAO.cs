using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class CTDONDHDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetData()
        {
            return db.GetData("sp_CTDONDH_select_all",null);
        }
        public DataTable GetDataByID(String SoDH)
        {
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@SoDH",SoDH)
            };
            return db.GetData("sp_CTDONDH_select_Byid", sqlParameter);
        }
        public int insert(CTDONDH obj)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@SoDH",obj.SoDH),
                new SqlParameter("@MaVTu", obj.MaVTu),
                new SqlParameter("@SLDat",obj.SLDat)

            };
            return db.ExecuteSQL("sp_CTDONDH_insert", sqlParameters);
        }
        public int update(CTDONDH obj) {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@SoDH", obj.SoDH),
                new SqlParameter("@MaVTu", obj.MaVTu),
                new SqlParameter("@SLDat", obj.SLDat)
            };
            return db.ExecuteSQL("sp_CTDONDH_update", sqlParameters);
        }
        public int delete(CTDONDH obj) {
            SqlParameter[] sqlParameters =
                {
                new SqlParameter("@SoDH", obj.SoDH),
               
            };
            return db.ExecuteSQL("sp_CTDONDH_delete", sqlParameters);
        }

    }
}
