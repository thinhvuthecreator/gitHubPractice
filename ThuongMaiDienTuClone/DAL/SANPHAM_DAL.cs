using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SANPHAM_DAL
    {

        public DataTable getDuLieuSanPham()
        {
            DataTable spSelect = connectSQLDatabse.Instance.ExecuteSQL("EXEC SanPhamSeLect");
            return spSelect;
        }
        public int convertGiaSP(string text)
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
        public bool themSP(SANPHAM sp)
        {
            bool isSuccess = true;
            string themSPQuerry = "INSERT SANPHAM VALUES (N'" + sp.MaSP + "',N'" + sp.TenSP + "'," + sp.GiaSP + ", N'" + sp.LoaiSanPham + "')";
            int giaSP = convertGiaSP(sp.GiaSP);
            try
            {
                if (giaSP <= -1)
                {
                    return false;
                }
                else   // giaSP != -1 , convert duoc 
                {
                    
                    connectSQLDatabse.Instance.ExecuteNONquerrySQL(themSPQuerry);
                }
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool updateSP(SANPHAM sp)
        {
            bool isSuccess = true;
            string updateSPQuerry = "UPDATE SANPHAM SET TENSP = N'" + sp.TenSP + "',GIA = N'" + sp.GiaSP + "',LOAISANPHAM = N'" + sp.LoaiSanPham + "' WHERE MASP = N'" + sp.MaSP + "'";
            int giaSP = convertGiaSP(sp.GiaSP);
            try
            {
                if (giaSP <= -1)
                {
                    return false;
                }
                else   // giaSP != -1 , convert duoc 
                {
                   
                    connectSQLDatabse.Instance.ExecuteNONquerrySQL(updateSPQuerry);
                }
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool xoaSP(string ma)
        {
            bool isSuccess = true;
            string xoaSPQuerry = "DELETE FROM SANPHAM WHERE MASP = N'" + ma + "'";
            try
            {
                connectSQLDatabse.Instance.ExecuteNONquerrySQL(xoaSPQuerry);
            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }

    }

}
