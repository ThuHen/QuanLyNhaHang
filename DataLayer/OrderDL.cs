using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Xml.Linq;

namespace DataLayer
{
    public class OrderDL : DataProvider
    {
        public int InsertOrder(Order order)
        {
            if(order.MaBan != 0&&order.MaBan!=null)
            {
                ChangeStatusTable(order.MaBan.Value);
            }
            string query = @"INSERT INTO DonHang (LoaiDonHang, TrangThai, DaThanhToan, TongTien, TienNhan, TienThua, MaBan, GhiChu,ThoiGian)
                             VALUES (@OrderType, @Status,@Payment, @Total, @Received, @Change, @TableID,@Note, @Time);
                             SELECT SCOPE_IDENTITY();";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@OrderType", order.LoaiDonHang),
                new SqlParameter("@Status", order.TrangThai),
                new SqlParameter("@Payment", order.DaThanhToan),
                new SqlParameter("@Total", order.TongTien),
                new SqlParameter("@Received", order.TienNhan),
                new SqlParameter("@Change", order.TienThua),
                new SqlParameter("@TableID", order.MaBan as object ?? DBNull.Value),
                new SqlParameter("@Note", order.GhiChu),
                new SqlParameter("@Time", order.ThoiGian)
            };

            object result = MyExecuteScalar(query, CommandType.Text, parameters);
            int orderID = Convert.ToInt32(result);

            foreach (var detail in order.Details)
            {
                InsertOrderDetail(detail, orderID);
            }
            return orderID;
        }
        private int ChangeStatusTable(int tableId)
        {
            string query = @"UPDATE BanAn SET MaTrangThai = 2 WHERE MaBan = @TableID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TableID", tableId)
            };
            return MyExcuteNonQuery(query, CommandType.Text, parameters);
        }
        private void InsertOrderDetail(OrderDetail detail, int orderID)
        {
            string query = @"INSERT INTO ChiTietDonHang (MaDonHang,MaSanPham,SoLuong)
                             VALUES (@OrderID, @ProID, @Qty);";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@OrderID", orderID),
                new SqlParameter("@ProID", detail.MaSanPham),
                new SqlParameter("@Qty", detail.SoLuong),
            };

            int result = MyExcuteNonQuery(query, CommandType.Text, parameters);
        }
        public void UpdateOrder(Order order, int mainId)
        {
            //string query = @"UPDATE tblMain SET 
            //                        Status = @Status, 
            //                        Total = @Total,
            //                        Received = @Received, 
            //                        Change = @Change 
            //                        DriverID = @DriverID,                 
            //                        CusName = @CusName,
            //                        CusPhone = @CusPhone
            //                     WHERE MainID = @ID";

            //List<SqlParameter> parameters = new List<SqlParameter>
            //    {
            //        new SqlParameter("@Status", order.Status),
            //        new SqlParameter("@Total", order.Total),
            //        new SqlParameter("@Received", order.Received),
            //        new SqlParameter("@Change", order.Change),
            //        new SqlParameter("@DriverID", order.DriverID),
            //        new SqlParameter("@CusName", order.CusName),
            //        new SqlParameter("@CusPhone", order.CusPhone),
            //        new SqlParameter("@ID", mainId)
            //    };

            //MyExcuteNonQuery(query, CommandType.Text, parameters);

            //foreach (var detail in order.Details)
            //{
            //    if (detail.DetailID == 0)
            //        InsertOrderDetail(detail, mainId);
            //    else
            //        UpdateOrderDetail(detail);
            //}
        }



        //    private void UpdateOrderDetail(OrderDetail detail)
        //    {
        //        string query = @"UPDATE tblDetails SET 
        //                            ProID = @ProID, 
        //                            Qty = @Qty, 
        //                            Price = @Price, 
        //                            Amount = @Amount 
        //                         WHERE DetailID = @ID";

        //        List<SqlParameter> parameters = new List<SqlParameter>
        //        {
        //            new SqlParameter("@ProID", detail.ProID),
        //            new SqlParameter("@Qty", detail.Qty),
        //            new SqlParameter("@Price", detail.Price),
        //            new SqlParameter("@Amount", detail.Amount),
        //            new SqlParameter("@ID", detail.DetailID)
        //        };

        //        MyExcuteNonQuery(query, CommandType.Text, parameters);
        //    }


        public List<Order> GetListOrders()
        {
           
            string sql = @"
            SELECT MaDonHang, LoaiDonHang, ThoiGian, TrangThai, DaThanhToan, d.MaBan, TenBan  
            FROM DonHang d
            LEFT JOIN BanAn b ON d.MaBan = b.MaBan";

            List<Order> orders = new List<Order>();
            try
            {

                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

                while (reader.Read())
                {
                    int MaDonHang = Convert.ToInt32(reader["MaDonHang"]);
                    string LoaiDonHang = reader["LoaiDonHang"].ToString();
                    DateTime ThoiGian = Convert.ToDateTime(reader["ThoiGian"]);
                    
                    string TrangThai = reader["TrangThai"].ToString();
                    string DaThanhToan = reader["DaThanhToan"].ToString();
                    int? MaBan = reader["MaBan"] != DBNull.Value ? Convert.ToInt32(reader["MaBan"]) : (int?)null;
                    string TenBan;
                    if (MaBan != null)
                    {
                        TenBan = reader["TenBan"].ToString();
                    }
                    else
                    {
                        TenBan = " ";
                    }



                    Order order = new Order
                    {
                        MaDonHang = MaDonHang,
                        LoaiDonHang = LoaiDonHang,
                       
                        TrangThai = TrangThai,
                        DaThanhToan = DaThanhToan,
                        ThoiGian = ThoiGian,
                        TenBan = TenBan
                    };
                    orders.Add(order);
                }
                reader.Close();
                return orders;

            }
            catch (SqlException ex)
            {
                throw ex; // Có thể log hoặc xử lý chi tiết hơn
            }
            finally
            {
                Disconnect(); // Đóng kết nối
            }
        }
        public Order GetOrderById(int orderId)
        {
            string sql = "SELECT * FROM DonHang WHERE MaDonHang = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@id", orderId)
                };
            Order order = null;
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);
                if (reader.Read())
                {
                    order = new Order
                    {
                        MaDonHang = Convert.ToInt32(reader["MaDonHang"]),
                        LoaiDonHang = reader["LoaiDonHang"].ToString(),
                        DaThanhToan = reader["DaThanhToan"].ToString(),
                        //TongTien = Convert.ToDouble(reader["TongTien"]),
                        //TienNhan = Convert.ToDouble(reader["TienNhan"]),
                        //TienThua = Convert.ToDouble(reader["TienThua"]),
                        MaBan = reader["MaBan"] != DBNull.Value ? Convert.ToInt32(reader["MaBan"]) : (int?)null,
                        GhiChu = reader["GhiChu"].ToString(),
                        //ThoiGian = Convert.ToDateTime(reader["ThoiGian"]),


                    };


                }
                reader.Close();
                order.Details = GetOrderDetails(orderId);
                return order;
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
        public List<OrderDetail> GetOrderDetails(int orderID)
        {
            string sql = @"Select 
                            MaChiTietDonHang, ChiTietDonHang.MaSanPham,SoLuong, TenSanPham,GiaSanPham
                            FROM ChiTietDonHang 
                            inner join SanPham 
                            on ChiTietDonHang.MaSanPham = SanPham.MaSanPham
                            WHERE MaDonHang = @OrderID";

            List<SqlParameter> parameters = new List<SqlParameter>
                {
                new SqlParameter("@OrderID", orderID)
            };
            Connect();
            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            while (reader.Read())
            {
                OrderDetail details = new OrderDetail
                {
                    MaChiTietDonHang = Convert.ToInt32(reader["MaChiTietDonHang"]),
                    MaSanPham = Convert.ToInt32(reader["MaSanPham"]),
                    SoLuong = Convert.ToInt32(reader["SoLuong"]),
                    TenSanPham = reader["TenSanPham"].ToString(),
                    GiaSanPham = Convert.ToDouble(reader["GiaSanPham"]),


                };
                orderDetails.Add(details);
            }
            reader.Close();
            Disconnect();
            return orderDetails;
        }

        public int UpdatePayment(int orderId, double Total, double Received, double Change)
        {
            string sql = @"UPDATE DonHang 
                           SET TongTien = @Total, 
                               TienNhan = @rec, 
                               TienThua = @Change ,
                               DaThanhToan = N'Đã thanh toán'
                               WHERE MaDonHang = @id";
            List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Total", Total),
                    new SqlParameter("@rec", Received),
                    new SqlParameter("@Change", Change),
                    new SqlParameter("@id", orderId)
                };
            try
            {
                Connect();
                int row = MyExcuteNonQuery(sql, CommandType.Text, parameters);
                return row;
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


        public void MarkStatusOrder(int maDonHang, string trangThai)
        {
            string sql = "UPDATE DonHang SET TrangThai = @TrangThai WHERE MaDonHang = @MainID";
            List<SqlParameter> parameters = new List<SqlParameter>

            {
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MainID", maDonHang)
            };
            
            MyExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        //    public List<Order> GetKitchenOrders()
        //    {
        //        string sql = "SELECT MainID, Date, Time, TableName, WaiterName, OrderType FROM tblMain WHERE Status <>'Complete'";
        //        List<Order> orders = new List<Order>();

        //        try
        //        {
        //            Connect();
        //            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

        //            while (reader.Read())
        //            {
        //                int mainId = Convert.ToInt32(reader["MainID"]);
        //                DateTime date = Convert.ToDateTime(reader["Date"]);
        //                string time = reader["Time"].ToString();
        //                string tableName = reader["TableName"].ToString();
        //                string waiterName = reader["WaiterName"].ToString();
        //                string OrderType = reader["OrderType"].ToString();

        //                // Tạo đối tượng Order đầy đủ với MainID và các trường cần thiết
        //                Order order = new Order(mainId, date, time, tableName, waiterName, OrderType);
        //                //order.Details = GetOrderDetails(mainId); // nếu bạn vẫn muốn lấy chi tiết món
        //                orders.Add(order);

        //            }

        //            reader.Close();
        //            return orders;
        //        }
        //        finally
        //        {
        //            Disconnect();
        //        }
        //    }

        //    public List<OrderDetail> GetOrderDetails(int mainId)
        //    {
        //        string sql = @"SELECT d.DetailID, d.ProID, p.Name, d.Qty, d.Price, d.Amount 
        //                 FROM tblDetails d 
        //                 JOIN products p ON d.ProID = p.Id 
        //                 WHERE d.MainID = @MainID";

        //        List<SqlParameter> parameters = new List<SqlParameter>
        //{
        //    new SqlParameter("@MainID", mainId)
        //};

        //        List<OrderDetail> details = new List<OrderDetail>();

        //        try
        //        {
        //            Connect();

        //            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);

        //            while (reader.Read())
        //            {
        //                OrderDetail detail = new OrderDetail
        //                {
        //                    DetailID = Convert.ToInt32(reader["DetailID"]),
        //                    ProID = Convert.ToInt32(reader["ProID"]),
        //                    ProName = reader["Name"].ToString(),
        //                    Qty = Convert.ToInt32(reader["Qty"]),
        //                    Price = Convert.ToDouble(reader["Price"]),
        //                    Amount = Convert.ToDouble(reader["Amount"])
        //                };

        //                details.Add(detail);
        //            }
        //            reader.Close();
        //            return details;
        //        }
        //        catch (SqlException ex)
        //        {

        //            throw ex;
        //        }
        //        finally
        //        {
        //            Disconnect();
        //        }
        //    }




        //    public string GetOrderType(int mainId)
        //    {
        //        string sql = "SELECT OrderType FROM tblMain WHERE MainID = @MainID";
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //        {
        //            new SqlParameter("@MainID", mainId)
        //        };
        //        try
        //        {
        //            Connect();
        //            object result = MyExecuteScalar(sql, CommandType.Text, parameters);
        //            return result?.ToString();
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            Disconnect();
        //        }
        //    }



        //    public List<FullBillDetail> GetFullBillDetails(int mainId)
        //    {
        //        string qry = @"
        //    SELECT * FROM tblMain m
        //    JOIN tblDetails d ON d.MainID = m.MainID
        //    JOIN products p ON p.Id = d.ProID
        //    WHERE m.MainID = @MainID";

        //        List<SqlParameter> parameters = new List<SqlParameter>
        //{
        //    new SqlParameter("@MainID", mainId)
        //};
        //        List<FullBillDetail> details = new List<FullBillDetail>();
        //        try
        //        {
        //            Connect();

        //            SqlDataReader reader = MyExecuteReader(qry, CommandType.Text, parameters);

        //            while (reader.Read())
        //            {
        //                FullBillDetail detail = new FullBillDetail
        //                {

        //                    MainID = Convert.ToInt32(reader["MainID"]),
        //                    Date = Convert.ToDateTime(reader["Date"]),
        //                    Time = reader["Time"].ToString(),
        //                    TableName = reader["TableName"].ToString(),
        //                    WaiterName = reader["WaiterName"].ToString(),
        //                    CusName = reader["CusName"].ToString(),
        //                    OrderType = reader["OrderType"].ToString(),
        //                    Name = reader["Name"].ToString(),
        //                    Qty = Convert.ToInt32(reader["Qty"]),
        //                    Price = Convert.ToDouble(reader["Price"]),
        //                    Amount = Convert.ToDouble(reader["Amount"]),
        //                    Received = Convert.ToDouble(reader["Received"]),
        //                    Change = Convert.ToDouble(reader["Change"])

        //                };

        //                details.Add(detail);
        //            }

        //            reader.Close();
        //            return details;
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            Disconnect();
        //        }
        //    }

    }
}
