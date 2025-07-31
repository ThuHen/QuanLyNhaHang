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
        public int MaTrangThai { get; set; }
        public string TrangThai { get; set; }
        public string DaThanhToan { get; set; }
        public double TongTien { get; set; }
        public double TienNhan { get; set; }
        public double TienThua { get; set; }
        public int? MaBan { get; set; }     
        public string GhiChu { get; set; }
        public DateTime ThoiGian { get; set; }

        public List<OrderDetails> Details { get; set; }
        public Order()
        {
            Details = new List<OrderDetails>();
        }
        //save
        //public Order(string loaiDonHang, int maTrangThai, string daThanhToan, double tongTien, double tienNhan, double tienThua,
        //    int maBan, string ghiChu, DateTime thoiGian,List<OrderDetails> details)
        //{
            
        //    LoaiDonHang = loaiDonHang;
        //    MaTrangThai = maTrangThai;
        //    DaThanhToan = daThanhToan;
        //    TongTien = tongTien;
        //    TienNhan = tienNhan;
        //    TienThua = tienThua;
        //    MaBan = maBan;
        //    GhiChu = ghiChu;
        //    ThoiGian = thoiGian;
        //    Details = details;
        //}
      
    }
   
}
