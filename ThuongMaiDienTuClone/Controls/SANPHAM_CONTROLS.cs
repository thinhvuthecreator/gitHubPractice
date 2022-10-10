using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace Controls
{
    public class SANPHAM_CONTROLS
    {
        SANPHAM_DAL sanphamDAL = new SANPHAM_DAL();
        public DataTable sanphamSelect()
        {
            return sanphamDAL.getDuLieuSanPham();
        }   //ổn
        public bool themSP(SANPHAM sp)
        {
            return sanphamDAL.themSP(sp);
        }
        public bool updateSP(SANPHAM sp)
        {
            return sanphamDAL.updateSP(sp);
        }
        public bool deleteSP(string ma)
        {
            return sanphamDAL.xoaSP(ma);
        }
    }
}
