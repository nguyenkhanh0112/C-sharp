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
    public class CTPXUATBLL
    {

        CTPXUATDAO CTPXUATDAO = new CTPXUATDAO();
        public DataTable GetData()
        {
            return CTPXUATDAO.GetData();
        }
        public DataTable GetDataById(String SoPX)
        {
            return CTPXUATDAO.GetDataById(SoPX);
        }
        public int insert(CTPXUAT obj)
        {
            return CTPXUATDAO.insert(obj);
        }
        public int update(CTPXUAT obj)
        {
            return CTPXUATDAO.update(obj);
        }
        public int delete(CTPXUAT obj)
        {
            return CTPXUATDAO.delete(obj);
        }
    }
}
