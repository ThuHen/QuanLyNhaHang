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
    public class CategoryDL : DataProvider
    {
        // Lấy danh sách các danh mục từ cơ sở dữ liệu
        public List<Category> GetAllCategories()
        {
            string sql = "SELECT * FROM DanhMuc";

            string id, name, description;
            int status;
            string createdAt, updatedAt;
            List<Category> categories = new List<Category>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = reader["MaDanhMuc"].ToString();
                    name = reader["TenDanhMuc"].ToString();
                    status = Convert.ToInt32(reader["TrangThai"]);
                    description = reader["MoTa"].ToString();
                    createdAt = reader["NgayTao"].ToString();
                    updatedAt = reader["NgayCapNhat"].ToString();
                    Category category = new Category(int.Parse(id), name, description ,status
                        , DateTime.Parse(createdAt), DateTime.Parse(updatedAt));
                    categories.Add(category);
                }
                reader.Close();
                return categories;
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
        // Thêm một danh mục mới vào cơ sở dữ liệu
        public int Add(Category category)
        {
            string sql = "INSERT INTO DanhMuc(TenDanhMuc,  TrangThai,MoTa, NgayTao, NgayCapNhat) " +
                         "VALUES(@name, @status, @description, @createdAt, @updatedAt); "; 
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", category.TenDanhMuc));
            parameters.Add(new SqlParameter("@status", category.TrangThai));
            parameters.Add(new SqlParameter("@description", category.MoTa));
            parameters.Add(new SqlParameter("@createdAt", category.NgayTao));
            parameters.Add(new SqlParameter("@updatedAt", category.NgayCapNhat));

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
            string sql = "DELETE FROM DanhMuc WHERE MaDanhMuc = @id";
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

        public void Edit(string id, Category category)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc = @name, MoTa = @mota," +
                " TrangThai = @status, NgayCapNhat = @ngayCapNhat WHERE MaDanhMuc = @id";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@mota", category.MoTa));
            parameters.Add(new SqlParameter("@status", category.TrangThai));
            parameters.Add(new SqlParameter("@name", category.TenDanhMuc));
            parameters.Add(new SqlParameter("@ngayCapNhat", category.NgayCapNhat));
            parameters.Add(new SqlParameter("@id", id));

            try
            {
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException ex)
            {
                throw ex; // Giữ nguyên stack trace gốc
            }
        }



    }
}
