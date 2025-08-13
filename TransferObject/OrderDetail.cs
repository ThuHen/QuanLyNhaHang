using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class OrderDetail
    {
        public int MaChiTietDonHang { get; set; }
        public int MaDonHang { get; set; }
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public OrderDetail()
        {
        }
        //save
        //public OrderDetails( int maSanPham, int soLuong)
        //{
        //    MaSanPham = maSanPham;
        //    SoLuong = soLuong;         
        //}

    }
}
