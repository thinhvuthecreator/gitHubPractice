using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace Controls
{
    public class KHACHHANG_CONTROLS
    {
        KHACHHANG_DAL khDAL = new KHACHHANG_DAL();
        public DataTable GetDuLieuKhachhang()
        {
            return khDAL.getDuLieuKhachHang();
        }
        public bool ThemKhachHang(KHACHHANG kh)
        {
            return khDAL.themKhachHang(kh);
        }
        public bool UpdateKhachHang(KHACHHANG kh)
        {
            return khDAL.updateKhachHang(kh);
        }
        public bool XoaKhachHang(string ma)
        {
            return khDAL.deleteKhachHang(ma);
        }


    }
}
