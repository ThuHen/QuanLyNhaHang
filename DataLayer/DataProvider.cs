using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace DataLayer
{
    public class DataProvider
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public DataProvider() {
            String sqlConnectionString = "Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True;";
            sqlConnection = new SqlConnection(sqlConnectionString);
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }  
        /// Kết nối đến cơ sở dữ liệu SQL Server.
        public void Connect()
        {
            try
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        /// Ngắt kết nối đến cơ sở dữ liệu SQL Server.
        public void Disconnect()
        {
            try
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        /// sqlCommand.ExcuteScalar
        /// Thực thi câu lệnh SQL và trả về giá trị đầu tiên của kết quả.
        public object MyExecuteScalar(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            try
            {
                Connect();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = type;

                if (parameters != null)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        sqlCommand.Parameters.Add(param);
                    }
                }

                return sqlCommand.ExecuteScalar();
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
        /// Thực thi câu lệnh SQL và trả về SqlDataReader để đọc dữ liệu.
        public SqlDataReader MyExecuteReader(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            if (parameters != null)
            {
                foreach (SqlParameter p in parameters)
                {
                    sqlCommand.Parameters.Add(p);
                }
            }
            try
            {
                return sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        /// Thực thi câu lệnh SQL và trả về số lượng dòng bị ảnh hưởng.
        public int MyExcuteNonQuery(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.CommandType = type;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    sqlCommand.Parameters.Add(parameter);
                }
            }
            try
            {
                Connect();
                return sqlCommand.ExecuteNonQuery();
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
