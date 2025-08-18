using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        public string MaTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int MaPhanQuyen { get; set; } // 1 = Admin, 2 = Cashier, 3 = Kitchen, 4 = Manager
        public Account() { }
    }
}
