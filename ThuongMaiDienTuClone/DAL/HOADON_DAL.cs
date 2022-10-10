using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
     public class HOADON_DAL
    {
        HOADON hoadonDTO = new HOADON();
        public DataTable getDuLieuHoaDon()
        {
            string getDuLieuQuerry = "SELECT HD.MAHD,HD.NGHD,KH.TENKH,NV.TENNV FROM HOADON HD, KHACHHANG KH, NHANVIEN NV WHERE HD.MANV = NV.MANV AND HD.MAKH = KH.MAKH";
            DataTable hoadon = connectSQLDatabse.Instance.ExecuteSQL(getDuLieuQuerry);
            return hoadon;
            
        }
        public bool themHD(HOADON hd) 
        {
            bool isSuccess = true;
            try
            {
                string addHDQuerry = "INSERT HOADON VALUES (N'" + hd.MaHD + "','" + hd.NgayHD + "',N'" + hd.MAKH + "',N'" + hd.MANV + "')";
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(addHDQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool xoaCTHD(string maHD)
        {
            bool isSuccess = true;
            string deleteCTHDQuerry = "DELETE CTHD WHERE MAHD = N'" + maHD + "'";
            try
            {
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(deleteCTHDQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool xoaHD(string ma) 
        {
            xoaCTHD(ma);
            bool isSuccess = true;
            string deleteHDQuerry = "DELETE HOADON WHERE MAHD = N'" + ma + "'";
            try
            {
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(deleteHDQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }

    }
}
