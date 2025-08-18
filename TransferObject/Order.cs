using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Order
    {
        public int MaDonHang { get; set; }
        public string LoaiDonHang { get; set; }
       
        public string TrangThai { get; set; }
        public string DaThanhToan { get; set; }
        public double TongTien { get; set; }
        public double GiamGia { get; set; }
        public double TienNhan { get; set; }
        public double TienThua { get; set; }
        public int? MaBan { get; set; }  
        public string TenBan { get; set; } 
        public string GhiChu { get; set; }
        public DateTime ThoiGian { get; set; }

        public List<OrderDetail> Details { get; set; }
        public Order()
        {
            Details = new List<OrderDetail>();
        }
       
      
    }
   
}
