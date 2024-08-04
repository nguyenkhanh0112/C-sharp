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
    public class CTDONDHBLL
    {
        private CTDONDHDAO ctddhdao = new CTDONDHDAO();
        public DataTable GetData()
        {
            return ctddhdao.GetData();
        }
        public DataTable GetDataById(String SoDH)
        {
            return ctddhdao.GetDataByID(SoDH);
        }
        public int insert (CTDONDH obj)
        {
            return ctddhdao.insert(obj);
        }       
        public int update (CTDONDH obj)
        {
            return ctddhdao.update(obj);
        }
        public int delete (CTDONDH obj)
        {
            return ctddhdao.delete(obj);
        }
    }
}
