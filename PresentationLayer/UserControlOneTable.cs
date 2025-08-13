using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class UserControlOneTable : UserControl
    {
        public UserControlOneTable()
        {
            InitializeComponent();
        }
        public int MaBan { get; set; }
        public string TenBan
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }
       public int SoLuongCho
        {
            get { return int.Parse(labelSoChoNgoi.Text); }
            set { labelSoChoNgoi.Text = value.ToString()+" chỗ"; }
        }
        public int MaDonHang
        {
            get { return int.Parse(labelOrderId.Text); }
            set { labelOrderId.Text = "Đơn "+value.ToString() ; }
        }


        public event EventHandler onSelect = null;
       


       

        private void labelName_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void labelSoChoNgoi_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
