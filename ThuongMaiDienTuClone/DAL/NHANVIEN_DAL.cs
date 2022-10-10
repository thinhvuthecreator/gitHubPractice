using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        public DataTable getDuLieuNhanVien()
        {
            string getNVQuerry = "EXEC NhanVienSelect";            // lấy dữ liệu tất cả nhân viên
            DataTable getNhanVien = new DataTable();
            getNhanVien = connectSQLDatabse.Instance.ExecuteSQL(getNVQuerry);
            return getNhanVien;
        }
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

        public bool themNhanVien(NHANVIEN nv)
        {
            bool isSuccess = true;
            int SoDienThoaiNVINT = ConvertSDTNV(nv.SoDienThoaiNV);
            try
            {
               
                if (SoDienThoaiNVINT <= -1)
                {
                    return false;
                }
                else
                {
                    string addNVQuerry = "INSERT NHANVIEN VALUES (N'" + nv.MaNV + " ',N' " + nv.TenNV + " ','" + nv.NgSinhNV.ToShortDateString() + "'," + "N'" + nv.GioiTinhNV + "'," + nv.SoDienThoaiNV + ")";
                    connectSQLDatabse.Instance.ExecuteNONquerrySQL(addNVQuerry);
                }
                
            }
            catch
            {
                isSuccess = false ;
            }
            return isSuccess;
        }           // them o database
        public bool updateNhanVien(NHANVIEN nv)
        {
            bool isSuccess = true;
            int SDTNVINT = ConvertSDTNV(nv.SoDienThoaiNV);
            try
            {
                if(SDTNVINT <= -1)
                {
                    return false;
                }
                string updateNVQuerry = "UPDATE NHANVIEN SET TENNV = N'" + nv.TenNV + "', NGSINHNV = '" + nv.NgSinhNV.ToShortDateString() + "', GIOITINHNV = N'" + nv.GioiTinhNV + "',SDTNV = " + nv.SoDienThoaiNV + " WHERE MANV = N'" + nv.MaNV + "'";
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(updateNVQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }        // sua o database 
        public bool deleteNhanVien(string ma)
        {
            bool isSuccess = true;
            try
            {
                string deleteNVQuerry = "DELETE NHANVIEN WHERE MANV = N'" + ma + "'";
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(deleteNVQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }          // xoa o database
    }
}
