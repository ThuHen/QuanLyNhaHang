using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Category
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; } // 0: Không hoạt động, 1: Hoạt động

        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        
        //Add new
        public Category(string tenDanhMuc, string moTa = "", int trangThai = 1, DateTime? ngayTao = null, DateTime? ngayCapNhat = null)
        {

            TenDanhMuc = tenDanhMuc;
            TrangThai = trangThai;
            MoTa = moTa;
            NgayTao = ngayTao ?? DateTime.Now;
            NgayCapNhat = ngayCapNhat ?? DateTime.Now;
        }

        //Read data
        public Category(int maDanhMuc, string tenDanhMuc, string moTa, int trangThai, DateTime ngayTao, DateTime ngayCapNhat)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
            TrangThai = trangThai;
            MoTa = moTa;
            NgayTao = ngayTao;
            NgayCapNhat = ngayCapNhat;
        }
    }

}
