using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class TONKHOBLL
    {
        TONKHODAO tONKHODAO = new TONKHODAO();
        public DataTable GetData()
        {
            return tONKHODAO.GetData();
        }
        public DataTable GetDataById(String MaVTu)
        {
            return tONKHODAO.GetDataById(MaVTu);
        }
        public int insert(TONKHO obj)
        {
            return tONKHODAO.insert(obj);
        }
        public int update(TONKHO obj)
        {
            return tONKHODAO.update(obj);
        }
        public int delete(TONKHO obj)
        {
            return tONKHODAO.delete(obj);
        }
    }
}
