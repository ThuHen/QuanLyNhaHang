using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Table
    {
        public int MaBan { get; set; }
        public string TenBan { get; set; }
        public string ViTri { get; set; }
        public int MaTrangThai { get; set; }
        public string TrangThai { get; set; }
        public int SoChoNgoi { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int MaDonHang { get; set; } 

        public Table() { }
        public Table( string tenBan, string viTri, int maTrangThai, int soChoNgoi, string ghiChu)
        {         
            TenBan = tenBan;
            ViTri = viTri;
            MaTrangThai = maTrangThai;
            SoChoNgoi = soChoNgoi;
            GhiChu = ghiChu;
            NgayTao = DateTime.Now; // Set default creation date to now
            NgayCapNhat = DateTime.Now; // Set default update date to now
        }
        public Table(int maBan, string tenBan, string viTri, int maTrangThai,string trangThai, int soChoNgoi, string ghiChu, DateTime ngayTao, DateTime ngayCapNhat)
        {
            MaBan = maBan;
            TenBan = tenBan;
            ViTri = viTri;
            MaTrangThai = maTrangThai;
            TrangThai = trangThai;
            SoChoNgoi = soChoNgoi;
            GhiChu = ghiChu;
            NgayTao = ngayTao;
            NgayCapNhat = ngayCapNhat;
        }

    } 
}
