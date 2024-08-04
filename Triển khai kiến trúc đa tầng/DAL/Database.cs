using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Database
    {
        String strCon = @"Data Source=NGUYENKHANH\NGUYENKHANH;Initial Catalog=Quanlybanhang;Integrated Security=True";
        protected SqlConnection sqlCon = null;

        public void OpenConnection()
        {
            if(sqlCon== null) { 
                sqlCon = new SqlConnection(strCon);
            }

            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        public void CloseConnection() { 
            if(sqlCon.State == ConnectionState.Open && sqlCon!=null ) {
                sqlCon.Close();
            }
        }
    }
}
