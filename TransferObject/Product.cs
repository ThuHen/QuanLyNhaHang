using System;

namespace TransferObject
{
    public class Product
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double GiaSanPham { get; set; }
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; } 
        public byte[] HinhAnh { get; set; }


        
        public Product(int maSanPham, string tenSanPham, double giaSanPham, int maDanhMuc, string tenDanhMuc, string moTa,int trangThai, byte[] hinhAnh)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            GiaSanPham = giaSanPham;
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
            MoTa = moTa;
            TrangThai = trangThai;
            HinhAnh = hinhAnh;
        }
        public Product(string tenSanPham, double giaSanPham, int maDanhMuc, string moTa, int trangThai, byte[] hinhAnh)
        {
            TenSanPham = tenSanPham;
            GiaSanPham = giaSanPham;
            MaDanhMuc = maDanhMuc;
            MoTa = moTa;
            TrangThai = trangThai;
            HinhAnh = hinhAnh;
        }

    }
}
