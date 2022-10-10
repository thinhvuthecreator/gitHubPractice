using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHACHHANG
    {
        private string maKH;
        private string tenKH;
        private DateTime ngSinhKH;
        private string gioiTinhKH;
        private string soDienThoaiKH;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgSinhKH { get => ngSinhKH; set => ngSinhKH = value; }
        public string GioiTinhKH { get => gioiTinhKH; set => gioiTinhKH = value; }
        public string SoDienThoaiKH { get => soDienThoaiKH; set => soDienThoaiKH = value; }
    }
}
