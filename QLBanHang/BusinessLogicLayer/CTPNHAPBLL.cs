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
    public class CTPNHAPBLL
    {
        CTPNHAPDAO obj = new CTPNHAPDAO();
        public DataTable GetData()
        {
            return obj.GetData();
        }
        public DataTable GetDataById(String SoPN) {
            return obj.GetDataById(SoPN);
        }
        public int insert(CTPNHAP obj_data)
        {   
            return obj.insert(obj_data);
        }
        public int update(CTPNHAP obj_data)
        {
            return obj.update(obj_data);
        }
        public int delete(CTPNHAP obj_data)
        {
            return obj.delete(obj_data);
        }
    }
}
