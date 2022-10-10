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
    public class HOADON_CONTROLS
    {
        HOADON hoadonDTO = new HOADON();
        HOADON_DAL hoadonDAL = new HOADON_DAL();
        public DataTable getDuLieuHoaDon()
        {
            return hoadonDAL.getDuLieuHoaDon();

        }

        public bool themHD(HOADON hd)
        {
            return hoadonDAL.themHD(hd); 
        }
        public bool xoaHD(string ma)
        {
            return hoadonDAL.xoaHD(ma);
        }
      
    }
}
