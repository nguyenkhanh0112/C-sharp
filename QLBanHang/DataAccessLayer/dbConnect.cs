using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class dbConnect
    {
        private SqlConnection _connection;

        public dbConnect()
        {
            _connection = new SqlConnection(@"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True");
        }
        public DataTable GetData(String strSQL)// select 
        {
            DataTable dataTable= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL,_connection);
            _connection.Open();
            da.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable GetData(String procName, SqlParameter[] parameters) {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure ;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            cmd.Connection = _connection;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd; ;
            _connection.Open();
            da.Fill(dt);
            _connection.Close();
            return dt;
        }
        public int ExecuteSQL(String strSQL) {
            SqlCommand cmd = new SqlCommand(strSQL, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
            return row;
        }
        public int ExecuteSQL(String procName, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _connection;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
            return row;
        }
    }
}
