using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;


namespace DAL
{
    public class KHACHHANG_DAL
    {

        int ConvertSDTNV(string text)
        {
            try
            {
                return int.Parse(text);
            }
            catch
            {
                return -1;
            }

        }
        public DataTable getDuLieuKhachHang()
        {
            string getNVQuerry = "EXEC KhachHangSelect";            // lấy dữ liệu tất cả nhân viên
            DataTable getKhachHang = new DataTable();
            getKhachHang = connectSQLDatabse.Instance.ExecuteSQL(getNVQuerry);
            return getKhachHang;
        }
        public bool themKhachHang(KHACHHANG kh)
        {
            bool isSuccess = true;
            int SDTKHINT = ConvertSDTNV(kh.SoDienThoaiKH);
            try
            {
                if (SDTKHINT <= -1)
                {
                    return false;
                }
                else
                {
                    string addKHQuerry = "INSERT KHACHHANG VALUES (N'" + kh.MaKH + " ',N' " + kh.TenKH + "','" + kh.NgSinhKH.ToShortDateString() + "'," + "N'" + kh.GioiTinhKH + "'," + kh.SoDienThoaiKH + ")";
                    connectSQLDatabse.Instance.ExecuteNONquerrySQL(addKHQuerry);
                }

            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }           // them o database
        public bool updateKhachHang(KHACHHANG kh)
        {

            bool isSuccess = true;
            int SDTKHINT = ConvertSDTNV(kh.SoDienThoaiKH);
            try
            {
                if(SDTKHINT <= -1)
                {
                    return false;
                }
                string updateKHQuerry = "UPDATE KHACHHANG SET TENKH = N'" + kh.TenKH + "', NGSINH = '" + kh.NgSinhKH.ToShortDateString() + "', GIOITINH = N'" + kh.GioiTinhKH + "',SDT = " + kh.SoDienThoaiKH + " WHERE MAKH = N'" + kh.MaKH + "'";
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(updateKHQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }        // sua o database 
        public bool deleteKhachHang(string ma)
        {
            bool isSuccess = true;
            try
            {
                string deleteKHQuerry = "DELETE KHACHHANG WHERE MAKH = N'" + ma + "'";
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(deleteKHQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }          // xoa o database
    }
}
