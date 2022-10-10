using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHANVIEN
    {
        private string maNV;
        private string tenNV;
        private DateTime ngSinhNV;
        private string gioiTinhNV;
        private string soDienThoaiNV;

        public string TenNV { get => tenNV; set => tenNV = value; }
        public String GioiTinhNV { get => gioiTinhNV; set => gioiTinhNV = value; }
        
        public DateTime NgSinhNV { get => ngSinhNV; set => ngSinhNV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string SoDienThoaiNV { get => soDienThoaiNV; set => soDienThoaiNV = value; }
    }
}
