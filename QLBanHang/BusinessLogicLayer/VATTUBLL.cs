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
    public class VATTUBLL
    {
        
        VATTUDAO dao = new VATTUDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataById(String MaVTu) {
            return dao.GetDataByid(MaVTu);
        }
        public int insert(VATTU obj)
        {
            return dao.insert(obj);
        }
        public int update(VATTU obj)
        {
            return dao.update(obj);
        }
        public int delete(VATTU obj)
        {
            return dao.delete(obj);
        }
    }
}
