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
    public class ProductDL : DataProvider
    {
        //    public Product GetProduct(int id)
        //    {
        //        string sql = "SELECT * FROM SanPham WHERE ID = @id";
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //{
        //    new SqlParameter("@id", id)
        //};

        //        Product product = null;

        //        try
        //        {
        //            Connect();
        //            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters); // ✅ truyền parameters
        //            if (reader.Read())
        //            {
        //                int Id = Convert.ToInt32(reader["Id"]);
        //                string name = reader["Name"].ToString();
        //                double price = Convert.ToDouble(reader["Price"]);
        //                int categoryID = Convert.ToInt32(reader["CategoryID"]);
        //                byte[] image = reader["Image"] is DBNull ? null : (byte[])reader["Image"];

        //                product = new Product(Id, name, price, categoryID, image);
        //            }
        //            reader.Close();
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            Disconnect();
        //        }
        //        return product;
        //    }


        // Lấy tất cả sản phẩm từ cơ sở dữ liệu
        public List<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM SanPham sp INNER JOIN DanhMuc dm ON sp.MaDanhMuc = dm.MaDanhMuc";

            List<Product> ListProduct = new List<Product>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {


                    string id = reader["MaSanPham"].ToString();
                    string name = reader["TenSanPham"].ToString();
                    string price = reader["GiaSanPham"].ToString();
                    string categoryId = reader["MaDanhMuc"].ToString();
                    string categoryName = reader["TenDanhMuc"].ToString();
                    string motasanpham = reader["MoTa"].ToString();
                    int trangThai = Convert.ToInt32(reader["TrangThai"]); 

                    byte[] image = null; // khởi tạo null

                    if (!reader.IsDBNull(reader.GetOrdinal("HinhAnh")))
                    {
                        image = (byte[])reader["HinhAnh"];
                    }


                    Product product = new Product(int.Parse(id), name, double.Parse(price), 
                        int.Parse(categoryId), categoryName, motasanpham, trangThai,image);
                    ListProduct.Add(product);
                }
                reader.Close();
                return ListProduct;
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
        public int Add(Product product)
        {
            string sql = "INSERT INTO SanPham (TenSanPham, GiaSanPham, MaDanhMuc,MoTa,TrangThai, HinhAnh) " +
                         "VALUES (@Name, @price, @cat,@MoTa,@TrangThai, @img)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", product.TenSanPham),
                new SqlParameter("@price", product.GiaSanPham),
                new SqlParameter("@cat", product.MaDanhMuc),
                new SqlParameter("@MoTa", product.MoTa),
                new SqlParameter("@TrangThai", product.TrangThai),
                new SqlParameter("@img", product.HinhAnh)
            };
            try
            {
                Connect();
                return MyExcuteNonQuery(sql, CommandType.Text, parameters);
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
        public void Del(string id)
        {
            string sql = "DELETE FROM SanPham WHERE MaSanPham = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };
            try
            {
                Connect();
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
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
        public void Edit(string id, Product product)
        {
            string sql = "UPDATE SanPham SET TenSanPham = @name, GiaSanPham = @price, MaDanhMuc = @cat," +
                " MoTa = @MoTa,TrangThai = @TrangThai, HinhAnh = @img " +
                         "WHERE MaSanPham = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@name", product.TenSanPham),
                new SqlParameter("@price", product.GiaSanPham),
                new SqlParameter("@cat", product.MaDanhMuc),
                new SqlParameter("@MoTa", product.MoTa),
                new SqlParameter("@TrangThai", product.TrangThai),
                new SqlParameter("@img", product.HinhAnh),
                new SqlParameter("@id", id)
            };
            try
            {
                Connect();
                MyExcuteNonQuery(sql, CommandType.Text, parameters);
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
