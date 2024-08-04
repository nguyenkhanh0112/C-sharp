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
    public class PXUATDAO
    {
        dbConnect _Connect = new dbConnect();
        public DataTable GetData()
        {
            return _Connect.GetData("sp_PXUAT_select_all", null);
        }
        public DataTable GetDataById(String SoPX)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPX",SoPX)
            };
            return _Connect.GetData("sp_PXUAT_select_all_ById", parameters);
        }
        public int insert(PXUAT obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPX",obj_data.SoPX),
                new SqlParameter("@Ngayxuat",obj_data.Ngayxuat),
                new SqlParameter("@TenKH",obj_data.TenKH)
            };
            return _Connect.ExecuteSQL("sp_PXUAT_insert", parameters);

        }
        public int update(PXUAT obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPX",obj_data.SoPX),
                new SqlParameter("@Ngayxuat",obj_data.Ngayxuat),
                new SqlParameter("@TenKH",obj_data.TenKH)
            };
            return _Connect.ExecuteSQL("sp_PXUAt_update", parameters);
        }
        public int delete(PXUAT obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoPX",obj_data.SoPX),
             
            };
            return _Connect.ExecuteSQL("sp_PXUAt_delete", parameters);

        }
    }
}
