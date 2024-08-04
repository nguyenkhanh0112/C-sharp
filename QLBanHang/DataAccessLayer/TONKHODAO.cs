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
    public class TONKHODAO
    {
        dbConnect _Connect = new dbConnect();
        public DataTable GetData()
        {
            return _Connect.GetData("sp_TONKHO_select_all", null);
        }
        public DataTable GetDataById(String MaVTu)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaVTu",MaVTu)
            };
            return _Connect.GetData("sp_TONKHO_select_all_ById", parameters);
        }
        public int insert(TONKHO obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter ("@MaVTu",obj_data.MaVTu),
                new SqlParameter ("@Namthang",obj_data.Namthang),
                new SqlParameter ("@SlDau",obj_data.SlDau),
                new SqlParameter ("@TongSLN",obj_data.TongSLN),
                new SqlParameter ("@TongSLX",obj_data.TongSLX),
                new SqlParameter ("@SlCuoi",obj_data.SlCuoi)
            };
            return _Connect.ExecuteSQL("sp_TONKHO_insert", parameters);
        }
        public int update(TONKHO obj_data)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter ("@MaVTu",obj_data.MaVTu),
                new SqlParameter ("@Namthang",obj_data.Namthang),
                new SqlParameter ("@SlDau",obj_data.SlDau),
                new SqlParameter ("@TongSLN",obj_data.TongSLN),
                new SqlParameter ("@TongSLX",obj_data.TongSLX),
                new SqlParameter ("@SlCuoi",obj_data.SlCuoi)
            };
            return _Connect.ExecuteSQL("sp_TONKHO_update", parameters);
        }
        public int delete(TONKHO obj_data)
        {
            SqlParameter[] parameters =
            {
                 new SqlParameter ("@MaVTu",obj_data.MaVTu)

            };
            return _Connect.ExecuteSQL("sp_TONKHO_delete", parameters);
        }
    }                  
}

