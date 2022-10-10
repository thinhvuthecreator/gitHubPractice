using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    // THAO TÁC VỚI DATABASE
    public class connectSQLDatabse
    {
        string stringConncection = @"Data Source=desktop-vav9qig\sqlexpress;Initial Catalog=QUANLYBANHANG;Integrated Security=True";
        
        private static connectSQLDatabse instance;
        public static connectSQLDatabse Instance
        {
            get { if (connectSQLDatabse.instance == null) connectSQLDatabse.instance = new connectSQLDatabse(); return connectSQLDatabse.instance; }
            private set { connectSQLDatabse.instance = value; }
        }
        private connectSQLDatabse() { }

        public DataTable ExecuteSQL(string stringQuerry)
        {
            SqlConnection QuanLyBanHangSQLconnection = new SqlConnection(stringConncection);
            SqlCommand querry = new SqlCommand(stringQuerry,QuanLyBanHangSQLconnection);
            SqlDataAdapter temporature = new SqlDataAdapter(querry);
            DataTable dataReturn = new DataTable();
            temporature.Fill(dataReturn);
            return dataReturn;
        }   // thực hiện câu truy vấn sql trả ra 1 datatable;
        public void ExecuteNONquerrySQL(string stringQuerry)
        {
            SqlConnection QuanLyBanHangSQLconnection = new SqlConnection(stringConncection);
            SqlCommand querry = new SqlCommand(stringQuerry, QuanLyBanHangSQLconnection);
            QuanLyBanHangSQLconnection.Open();
            querry.ExecuteNonQuery();
            QuanLyBanHangSQLconnection.Close();
          
        }   // thực hiện câu truy vấn sql không trả ra gì cả

        public bool Login(string user, string pass)
        {
            string AccountSelectQuerry = "EXEC AccountSelect @taikhoan = N' " + user + " ' , " + "@matkhau = N'" + pass + "'";
            DataTable AccountExistCount = connectSQLDatabse.instance.ExecuteSQL(AccountSelectQuerry);

            return AccountExistCount.Rows.Count > 0;
        }  //xem co ket qua nao thoa man khong, neu co thi dang nhap thanh cong
    }
}
