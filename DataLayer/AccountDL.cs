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
        public List<Account> GetAllAccount()
        {
            string sql = "SELECT * FROM TaiKhoan";
            List<Account> accounts = new List<Account>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Account account = new Account
                    {
                        MaTaiKhoan = reader["MaTaiKhoan"].ToString(),
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        MaPhanQuyen = Convert.ToInt32(reader["MaPhanQuyen"])
                    };

                    accounts.Add(account);
                }
                reader.Close();
                return accounts;
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
        
        public int Add(Account account)
        {
            string sql = "INSERT into TaiKhoan (TenDangNhap, MatKhau, MaPhanQuyen) " +
                         "VALUES (@username, @password, @role)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", account.TenDangNhap),
                new SqlParameter("@password", account.MatKhau),
                new SqlParameter("@role", account.MaPhanQuyen)
            };

            try
            {
                return MyExcuteNonQuery(sql, CommandType.Text, parameters);

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public void Del(string id)
        {
            string sql = "DELETE FROM TaiKhoan WHERE MaTaiKhoan = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };
            try
            {
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Edit(string id, Account account)
        {
            string sql = "UPDATE TaiKhoan SET TenDangNhap = @username, MatKhau = @password, MaPhanQuyen = @role WHERE MaTaiKhoan = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id),
                new SqlParameter("@username", account.TenDangNhap),
                new SqlParameter("@password", account.MatKhau),
                new SqlParameter("@role", account.MaPhanQuyen)
            };

            try
            {
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
