using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class TableStatusDL : DataProvider
    {
        public List<TableStatus> GetAllTableStatuses()
        {
            string sql = "SELECT * FROM TrangThaiBan";
            List<TableStatus> tableStatuses = new List<TableStatus>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    int maTrangThai = Convert.ToInt32(reader["MaTrangThai"]);
                    string trangThai = reader["TrangThai"].ToString();
                    TableStatus tableStatus = new TableStatus { MaTrangThai = maTrangThai, TrangThai = trangThai };
                    tableStatuses.Add(tableStatus);
                }
                reader.Close();
                return tableStatuses;
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
