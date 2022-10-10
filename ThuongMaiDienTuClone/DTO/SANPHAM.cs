using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SANPHAM
    {
        private string maSP, tenSP, giaSP, loaiSanPham;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string GiaSP { get => giaSP; set => giaSP = value; }
        public string LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }
        public SANPHAM() { }
        public SANPHAM(string ma, string ten, string gia, string loai)
        {
            maSP = ma;
            tenSP = ten;
            giaSP = gia;
            loaiSanPham = loai;
        }
    }
}
