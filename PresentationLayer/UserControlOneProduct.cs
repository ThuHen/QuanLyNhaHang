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
    public partial class UserControlOneProduct : UserControl
    {
        public UserControlOneProduct()
        {
            InitializeComponent();
        }
        public int MaSanPham { get; set; }
        public Image HinhAnh
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }
        public string TenSanPham
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public String GiaSanPham
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public String category { get; set; }
        public event EventHandler onSelect = null;
        private void pictureBox_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
