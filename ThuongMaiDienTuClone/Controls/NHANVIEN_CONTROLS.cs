using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace Controls
{
    public class NHANVIEN_CONTROLS
    {
        NHANVIEN_DAL nvDAL = new NHANVIEN_DAL();
        public DataTable GetDuLieuNhanVien()
        {
            return nvDAL.getDuLieuNhanVien();
        }
        public bool ThemNhanVien(NHANVIEN nv)
        {
            return nvDAL.themNhanVien(nv);
        }
        public bool UpdateNhanVien(NHANVIEN nv)
        {
            return nvDAL.updateNhanVien(nv);
        }
        public bool XoaNhanVien(string ma)
        {
            return nvDAL.deleteNhanVien(ma);
        }


    }


}
