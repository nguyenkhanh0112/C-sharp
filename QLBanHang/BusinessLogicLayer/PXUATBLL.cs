using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class PXUATBLL
    {
        PXUATDAO PXUATDAO = new PXUATDAO();
        public DataTable GetData()
        {
            return PXUATDAO.GetData();
        }
        public DataTable GetDataById(String SoPX)
        {
            return PXUATDAO.GetDataById(SoPX);
        }
        public int insert(PXUAT obj)
        {
            return PXUATDAO.insert(obj);
        }
        public int update(PXUAT obj)
        {
            return PXUATDAO.update(obj);
        }
        public int delete(PXUAT obj)
        {
            return PXUATDAO.delete(obj);
        }
    }
}
