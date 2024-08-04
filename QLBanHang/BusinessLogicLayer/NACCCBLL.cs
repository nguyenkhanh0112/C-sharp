using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class NACCCBLL
    {
        NHACCDAO nHACCDAO = new NHACCDAO();
        public DataTable GetData()
        {
            return nHACCDAO.GetData();
        }
        public DataTable GetDataByID(String MaNCC)
        {
            return nHACCDAO.GetDaTaByID(MaNCC);
        }

        public int insert(NHACC obj)
        {
            return nHACCDAO.insert(obj);
        }
        public int update(NHACC obj)
        {
            return nHACCDAO.update(obj);    
        }
        public int delete(NHACC obj) 
        { 
            return nHACCDAO.delete(obj);
        }
    }
}
