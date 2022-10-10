using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOADON
    {
        private string maHD, maKH, maNV;
        private DateTime ngayHD;

      
        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MAKH { get => maKH; set => maKH = value; }
        public string MANV { get =>maNV; set => maNV = value; }
    }
}
