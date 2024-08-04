using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class VatTuBLL
    {
        // hàm hiển thị danh sách vật tư 
        VatTuDAL vtDAL = new VatTuDAL();
        public List<VatTu> HienThiDanhSachVatTu()
        {
            return vtDAL.HienThiDanhSachVatTu();
        }
        public bool ThemVatTu(VatTu vt)
        {
            return vtDAL.ThemVatTu(vt);
        }
        public bool SuaVatTu(VatTu vt)
        {
           return vtDAL.SuaVatTu(vt);
        }
        public bool XoaVatTu(VatTu vt)
        {
            return vtDAL.XoaVatTu(vt);
        }
    }
}
