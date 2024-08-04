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
    public class PNHAPBLL
    {
        PNHAPDAO obj_dao = new PNHAPDAO();
        public DataTable GetData()
        {
            return obj_dao.GetDaTa();
        }
        public DataTable GetDataById(String SoPN)
        {
            return obj_dao.GetDataById(SoPN);
        }
        public int insert(PNHAP obj)
        {
            return obj_dao.insert(obj);
        }
        public int update(PNHAP obj)
        {
            return obj_dao.update(obj);
        }
        public int delete(PNHAP obj)
        {
            return obj_dao.delete(obj);
        }
    }
}
