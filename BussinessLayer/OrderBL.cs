using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BussinessLayer
{
    public class OrderBL
    {
        private OrderDL orderDL;

        public OrderBL()
        {
            orderDL = new OrderDL();
        }
        public static int SaveOrder(Order order, int selectedOrder)
        {
            OrderDL orderDL = new OrderDL();
            if (selectedOrder == 0)
            {

                return orderDL.InsertOrder(order);
            }
            else
            {
                orderDL.UpdateOrder(order, selectedOrder);
                return selectedOrder;
            }
        }
 public List<Order> GetListOrders()
        {
            try
            {
                return orderDL.GetListOrders();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Order GetOrderById(int mainId)
        {
            try
            {
                return orderDL.GetOrderById(mainId);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<OrderDetail> GetOrderDetails(int orderID)
        {
            try
            {
                return orderDL.GetOrderDetails(orderID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdatePayment(int orderId, double total,double discount, double received, double change)
        {
            
            return orderDL.UpdatePayment(orderId, total, discount, received, change);
        }
        public void MarkStatusOrder(int mainId, string trangThai)
        {
            orderDL.MarkStatusOrder(mainId, trangThai);
        }

        public int getTableIdByOrderId(int orderId)
        {
            return orderDL.getTableIdByOrderId(orderId);
        }

        //public List<Order> GetKitchenOrders()
        //{
        //    return orderDL.GetKitchenOrders();
        //}

        //public string GetOrderType(int mainId)
        //{
        //    return orderDL.GetOrderType(mainId);
        //}


        //public List<FullBillDetail> GetFullBillDetails(int mainId)
        //{
        //    return orderDL.GetFullBillDetails(mainId);
        //}

    }
}
