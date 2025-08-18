using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;


namespace DataLayer
{
    public class TableDL:DataProvider
    {
      
        public List<Table> GetAllTables()
        {
            string sql = @"
                    SELECT 
                        b.*,
                        t.TrangThai,
                        d.MaDonHang
                    FROM BanAn b
                    INNER JOIN TrangThaiBan t 
                        ON b.MaTrangThai = t.MaTrangThai
                    LEFT JOIN DonHang d 
                        ON b.MaBan = d.MaBan AND d.DaThanhToan <> N'Đã thanh toán'
                    ";
            // "where d.DaThanhToan != @daThanhToan"; // Lấy tất cả bàn trừ bàn đã xóa
            string id, name, viTri, trangThai, ghiChu;
            int soChoNgoi, maTrangThai, maDonHang;
            DateTime ngayTao, ngayCapNhat;
            List<Table> tables = new List<Table>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            //parameters.Add(new SqlParameter("@daThanhToan", "Đã thanh toán")); // Chỉ lấy bàn chưa thanh toán
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = reader["MaBan"].ToString();
                    name = reader["TenBan"].ToString();
                    viTri = reader["ViTri"].ToString();
                    maTrangThai = Convert.ToInt32(reader["MaTrangThai"]);
                    trangThai = reader["TrangThai"].ToString();
                    soChoNgoi = Convert.ToInt32(reader["SoChoNgoi"]);
                    ghiChu = reader["GhiChu"].ToString();
                    ngayTao = Convert.ToDateTime(reader["NgayTao"]);
                    ngayCapNhat = Convert.ToDateTime(reader["NgayCapNhat"]);
                    maDonHang = reader["MaDonHang"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MaDonHang"]);
                    Table table = new Table
                    {
                        MaBan = Convert.ToInt32(id),
                        TenBan = name,
                        ViTri = viTri,
                        MaTrangThai = maTrangThai,
                        TrangThai = trangThai,
                        SoChoNgoi = soChoNgoi,
                        GhiChu = ghiChu,
                        NgayTao = ngayTao,
                        NgayCapNhat = ngayCapNhat,
                        MaDonHang = maDonHang
                    };
                    tables.Add(table);
                }
                reader.Close();
                return tables;
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
        public int Add(Table table)
        {
            string sql = "INSERT INTO BanAn (TenBan, ViTri, MaTrangThai, SoChoNgoi, GhiChu) " +
                         "VALUES (@name, @viTri, @maTrangThai, @soChoNgoi, @ghiChu)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", table.TenBan));
            parameters.Add(new SqlParameter("@viTri", table.ViTri));
            parameters.Add(new SqlParameter("@maTrangThai", table.MaTrangThai));
            parameters.Add(new SqlParameter("@soChoNgoi", table.SoChoNgoi));
            parameters.Add(new SqlParameter("@ghiChu", table.GhiChu));
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
            string sql = "DELETE FROM BanAn WHERE MaBan = @id";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            try
            {
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Edit(string id, Table table)
        {
            string sql = "UPDATE BanAn SET TenBan = @name, ViTri = @viTri, MaTrangThai = @maTrangThai," +
                " SoChoNgoi = @soChoNgoi, GhiChu = @ghiChu, NgayCapNhat = GETDATE() WHERE MaBan = @id";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            parameters.Add(new SqlParameter("@name", table.TenBan));
            parameters.Add(new SqlParameter("@viTri", table.ViTri));
            parameters.Add(new SqlParameter("@maTrangThai", table.MaTrangThai));
            parameters.Add(new SqlParameter("@soChoNgoi", table.SoChoNgoi));
            parameters.Add(new SqlParameter("@ghiChu", table.GhiChu));



            try
            {
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException ex)
            {
                throw ex; 
            }
        }
        public void MarkStatusTable(int maBan, int status)
        {
            string sql = "UPDATE BanAn SET MaTrangThai = @maTrangThai, NgayCapNhat = GETDATE() WHERE MaBan = @maBan";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maBan", maBan),
                new SqlParameter("@maTrangThai", status)
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
