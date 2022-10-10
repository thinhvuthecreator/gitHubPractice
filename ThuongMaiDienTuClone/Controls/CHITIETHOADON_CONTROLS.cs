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
   public  class CHITIETHOADON_CONTROLS
    {
        CTHD_DAL cthdDAL = new CTHD_DAL();
        public DataTable getDuLieuCTHD(string maHD)
        {
            return cthdDAL.getDuLieuCTHD(maHD);

        }
        public DataTable getDuLieuCTHD1(string maHD)
        {
            return cthdDAL.getDuLieuCTHD1(maHD);

        }
        public bool addCTHD(string hd, string sp, int soLuong)
        {
            return cthdDAL.addCTHD(hd, sp, soLuong);
        }
        public bool delCTHD(string ma)
        {
            return cthdDAL.xoaCTHD(ma);
        }

    }
}
