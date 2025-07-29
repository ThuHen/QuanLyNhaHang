using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DataLayer
{
    public class AccountDL : DataProvider
    {

        // Hàm đăng nhập
        // Trả về đối tượng Account nếu đăng nhập thành công, ngược lại trả về null
        public Account Login(string username, string password)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            try
            {
                List<SqlParameter> cacThamSo = new List<SqlParameter> {
                    new SqlParameter("@TenDangNhap",username),
                    new SqlParameter("@MatKhau", password)
                };
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, cacThamSo);
                if (reader.Read())
                {
                    Account account = new Account();
                    account.TenDangNhap = reader["TenDangNhap"].ToString();
                    account.MatKhau = reader["MatKhau"].ToString();
                    account.MaPhanQuyen = Convert.ToInt32(reader["MaPhanQuyen"]);
                    return account;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
