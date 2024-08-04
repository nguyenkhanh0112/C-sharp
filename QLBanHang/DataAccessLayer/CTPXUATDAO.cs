using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class CTPXUATDAO
    {
        dbConnect _Connect = new dbConnect();
        public DataTable GetData()
        {
            return _Connect.GetData("sp_CTPXUAT_select_all", null);
        }
        public DataTable GetDataById(String SoPX)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPX",SoPX)
            };
            return _Connect.GetData("sp_CTPXUAT_select_all_ById", parameters);
        }
        public int insert(CTPXUAT obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("MaVTu",obj_data.MaVTu),
                new SqlParameter("@SoPX",obj_data.SoPX),
                new SqlParameter("@Slxuat",obj_data.SlXuat),
                new SqlParameter("@DgXuat",obj_data.DgXuat)
            };
            return _Connect.ExecuteSQL("sp_CTPXUAT_insert", parameters);

        }
        public int update(CTPXUAT obj_data)
        {
            SqlParameter[] parameters =
            {
               new SqlParameter("MaVTu",obj_data.MaVTu),
                new SqlParameter("@SoPX",obj_data.SoPX),
                new SqlParameter("@Slxuat",obj_data.SlXuat),
                new SqlParameter("@DgXuat",obj_data.DgXuat)
            };
            return _Connect.ExecuteSQL("sp_CTPXUAT_update", parameters);
        }
        public int delete(CTPXUAT obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPX",obj_data.SoPX)
               

            };
            return _Connect.ExecuteSQL("sp_CTPXUAT_delete", parameters);

        }
    }
}
