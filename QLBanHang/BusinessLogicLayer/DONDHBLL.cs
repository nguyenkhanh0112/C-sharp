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
    public class DONDHBLL
    {
        DONDHDAO objjj = new DONDHDAO();
        public DataTable GetData()
        {
            return objjj.GetData();
        }
        public DataTable GetDataByID(String SoDH)
        {
            return objjj.GetDataByID(SoDH);
        }
        public int insert(DONDH obj)
        {
            return objjj.insert(obj);
        }
        public int update(DONDH obj)
        {
            return objjj.update(obj);
        }
        public int delete(DONDH obj)
        {
            return objjj.delete(obj);
        }
    }
}
