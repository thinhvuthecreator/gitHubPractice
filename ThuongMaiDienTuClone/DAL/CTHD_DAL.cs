using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class CTHD_DAL
    {
        CHITIETHOADON cthd = new CHITIETHOADON();
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
        public DataTable getDuLieuCTHD(string maHD)
        {
            string getListCTHDQuerry = "SELECT CT.MAHD,SP.MASP ,SP.TENSP,CT.SOLUONG,SP.GIA FROM CTHD CT, SANPHAM SP WHERE MAHD = N'" + maHD + "' AND SP.MASP = CT.MASP" ;     // "SELECT SP.TENSP,SP.GIA,CT.SOLUONG FROM CTHD CT,SANPHAM SP WHERE CT.MASP = SP.MASP";
           
            DataTable listDulieuCTHD = connectSQLDatabse.Instance.ExecuteSQL(getListCTHDQuerry);
          
            return listDulieuCTHD;

        }
        public DataTable getDuLieuCTHD1(string maHD)
        {
            
            string getListCTHDQuerry1 = "SELECT CT.MAHD,SP.MASP ,SP.TENSP, SANPHAM SP WHERE MAHD = N'" + maHD + "' AND SP.MASP = CT.MASP";
            DataTable listDulieuCTHD1 = connectSQLDatabse.Instance.ExecuteSQL(getListCTHDQuerry1);
            return listDulieuCTHD1;
            

        }
        public bool updateSLcthd(int sl, string maHD)
        { bool isSuccess = true;
            try
            {
                string updateSL = "EXEC updateSL @sl ="+sl+", @maHD = N'"+maHD+"'"; 
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
            
        }
        public bool addCTHD(string maHD,string maSP,int soLuong)
        {
            bool isSuccess = true;
            string addCTHDQuerry = "INSERT CTHD (MASP,MAHD,SOLUONG) VALUES (N'"+maSP+"',N'"+maHD+"',"+soLuong +")";
            if (soLuong == -1)
            {
                return false;
            }
            else
            {
                try
                {

                    connectSQLDatabse.Instance.ExecuteNONquerrySQL(addCTHDQuerry);
                }
                catch
                {
                    isSuccess = false;
                }
            }
            return isSuccess;
        }
        
            
    }
}
