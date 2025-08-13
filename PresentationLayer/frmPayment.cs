using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class frmPayment : Form
    {
        public double total;
        public string daThanhToan;
        public double thanhTien;
        public double tienNhan;
        public double tienThua;
        public double giamGia = 0;
        public int selectedOrder = 0;
        OrderBL orderBL;
        public frmPayment()
        {
            InitializeComponent();
            orderBL = new OrderBL();
        }


        private void buttonFastCash_Click(object sender, EventArgs e)
        {
            int thanhToan = orderBL.UpdatePayment(selectedOrder, thanhTien, thanhTien, 0);
            if (thanhToan > 0)
            {
                MessageBox.Show("Thanh toán thành công");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại, vui lòng thử lại sau");
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            tienNhan = double.Parse(textBoxReceive.Text);
            if (tienNhan < thanhTien)
            {
                MessageBox.Show("Tiền nhận không đủ để thanh toán");
                return;
            }

            if (giamGia < 0)
            {
                MessageBox.Show("Giảm giá không hợp lệ");
                return;
            }
            if (tienNhan < 0)
            {
                MessageBox.Show("Tiền nhận không hợp lệ");
                return;
            }

            int thanhToan = orderBL.UpdatePayment(selectedOrder, thanhTien, tienNhan, tienThua);
            if (thanhToan > 0)
            {
                MessageBox.Show("Thanh toán thành công");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại, vui lòng thử lại sau");
            }

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            textBoxTotal.Text = total.ToString() + " VND";
            giamGia = double.Parse(textBoxDiscount.Text);
            thanhTien = total - giamGia;
            textBoxAmount.Text = thanhTien.ToString() + " VND";

        }


        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiscount.Text != "")
            {
                giamGia = double.Parse(textBoxDiscount.Text);
                thanhTien = total - giamGia;
                
            }
            else
            {
                giamGia = 0;
                
            }
            textBoxAmount.Text = thanhTien.ToString() + " VND";


        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxReceive_TextChanged(object sender, EventArgs e)
        {
            if (textBoxReceive.Text != "")
            {
                tienNhan = double.Parse(textBoxReceive.Text);
                if (tienNhan < thanhTien)
                {
                    textBoxChange.Text = "0 VND";
                }
                else
                {
                    tienThua = tienNhan - thanhTien;
                    textBoxChange.Text = tienThua.ToString() + " VND";
                }
            }
            else
            {
                textBoxChange.Text = "0 VND";
            }
        }
    }
}
