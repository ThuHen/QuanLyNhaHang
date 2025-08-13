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
using TransferObject;

namespace PresentationLayer
{
    public partial class frmKitchen : Form
    {
        private int isAdmin;
        private OrderBL orderBL;
        public frmKitchen(int isAdmin_)
        {
            InitializeComponent();
            isAdmin = isAdmin_;
            orderBL = new OrderBL();
        }
        public void ShowCurrentTime()
        {

            timer1.Interval = 1000; // mỗi 1 giây
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            if (isAdmin == 1)
            {
                Form form = new frmBangDieuKhien();
                form.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Form form = new frmDangNhap();
                    form.Show();
                    this.Hide();
                }

            }
        }

        private void labelNote_Click(object sender, EventArgs e)
        {

        }

        private void frmKitchen_Load(object sender, EventArgs e)
        {
            LoadOrders();
            ShowCurrentTime();
        }

        private void buttonMark_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button != null && button.Tag != null)
            {
                int orderId = Convert.ToInt32(button.Tag.ToString());
                string trangThai = "Chờ xử lý";
                if (button.Text == "Chế biến")
                {
                    trangThai = "Đang chế biến";
                    orderBL.MarkStatusOrder(orderId, trangThai);
                    button.BackColor = Color.FromArgb(255, 193, 7); // Màu vàng cho đơn hàng đang chế biến
                    button.Text = "Đang chế biến"; // Đổi chữ nút sau khi nhấn

                }
                else if (button.Text == "Hoàn thành")
                {
                    DialogResult = MessageBox.Show("Bạn chắc chắn đã hoàn thành đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult == DialogResult.Yes)
                    {
                        trangThai = "Hoàn thành";
                        orderBL.MarkStatusOrder(orderId, trangThai);
                        LoadOrders();
                    }


                }

            }


        }
        private void LoadOrders()
        {
            List<Order> orders = new List<Order>();
            List<Order> allOrders = orderBL.GetListOrders();
            if (radioButtonAll.Checked)
            {
                orders = allOrders.Where(o => o.TrangThai != "Hoàn thành").ToList();
            }
            else if (radioButtonCheBien.Checked)
            {
                orders = allOrders.Where(o => o.TrangThai == "Đang chế biến").ToList();
            }
            
            foreach (var order in orders)
            {
                order.Details = orderBL.GetOrderDetails(order.MaDonHang);
            }
            flowLayoutPanelOrders.Controls.Clear(); // Xóa các điều khiển cũ trong FlowLayoutPanel trước khi thêm mới
            FlowLayoutPanel panel;
            buttonCount.Text = orders.Count.ToString(); // Cập nhật số lượng đơn hàng 
            for (int i = 0; i < orders.Count; i++)
            {
                Order order = orders[i];
                panel = new FlowLayoutPanel();
                panel.AutoSize = true;
                panel.Width = 180;
                //p1.Height = 350;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.BorderStyle = BorderStyle.FixedSingle;
                //p1.Margin = new Padding(2, 10, 10, 10);

                FlowLayoutPanel panelTop = new FlowLayoutPanel();
                panelTop = new FlowLayoutPanel();
                panelTop.BackColor = Color.FromArgb(50, 55, 89);
                //p2.AutoSize = true;
                panelTop.Width = 180;
                panelTop.Height = 70;
                panelTop.FlowDirection = FlowDirection.TopDown;
                //p2.Margin = new Padding(0, 0, 0, 0);


                Label maDon = new Label();
                maDon.ForeColor = Color.White;
                maDon.Margin = new Padding(10, 10, 0, 0);
                maDon.AutoSize = true;
                maDon.Text = "Mã đơn: " + order.MaDonHang.ToString();



                Label loaiDonHang = new Label();
                loaiDonHang.ForeColor = Color.White;
                loaiDonHang.Margin = new Padding(10, 0, 0, 0);
                loaiDonHang.AutoSize = true;

                if (order.LoaiDonHang == "Mang đi")
                {
                    loaiDonHang.Text = order.LoaiDonHang.ToString();
                }
                else
                {
                    loaiDonHang.Text = order.TenBan.ToString();
                }




                Label thoiGian = new Label();
                thoiGian.ForeColor = Color.White;
                thoiGian.Margin = new Padding(10, 0, 0, 0);
                thoiGian.AutoSize = true;
                thoiGian.Text = "Thời gian: " + order.ThoiGian.ToString("HH:mm");




                panelTop.Controls.Add(maDon);
                panelTop.Controls.Add(loaiDonHang);
                panelTop.Controls.Add(thoiGian);
                panel.Controls.Add(panelTop);


                if (order.Details != null && order.Details.Count > 0)

                {
                    for (int j = 0; j < order.Details.Count; j++)
                    {
                        OrderDetail orderDetail = order.Details[j];
                        Label itemLabel = new Label();
                        itemLabel.ForeColor = Color.Black;
                        itemLabel.Margin = new Padding(10, 0, 3, 0);
                        itemLabel.AutoSize = true;
                        itemLabel.Text = $"{j + 1} {". "}{orderDetail.TenSanPham.ToString()} {" - "}{orderDetail.SoLuong.ToString()}";
                        panel.Controls.Add(itemLabel);
                    }
                }
                Button button = new Button();
                button.AutoSize = true;
                button.BackColor = Color.FromArgb(241, 85, 126);
                //button.Margin = new Padding(60, 5, 3, 10);
                if (order.TrangThai == "Đang chế biến")
                {
                    button.BackColor = Color.FromArgb(255, 193, 7); // Màu vàng cho đơn hàng đang chế biến
                    button.Text = "Đang chế biến";
                    button.Enabled = false; // Vô hiệu hóa nút nếu đơn hàng đang chế biến
                }
                else
                    button.Text = "Chế biến";
                button.Tag = order.MaDonHang; // Gán ID để xử lý khi nhấn nút
                button.Click += new EventHandler(buttonMark_Click);

                Button buttonCom = new Button();
                buttonCom.AutoSize = true;
                buttonCom.BackColor = Color.FromArgb(241, 85, 126);
                //buttonCom.Margin = new Padding(60, 5, 3, 10);
                buttonCom.Text = "Hoàn thành";
                buttonCom.Tag = order.MaDonHang; // Gán ID để xử lý khi nhấn nút
                buttonCom.Click += new EventHandler(buttonMark_Click);


                panel.Controls.Add(button);
                panel.Controls.Add(buttonCom);
                flowLayoutPanelOrders.Controls.Add(panel);

            }
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void radioButtonCheBien_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
