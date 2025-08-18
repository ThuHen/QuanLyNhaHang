using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BussinessLayer;
using PresentationLayer.Resources;
using TransferObject;

namespace PresentationLayer
{
    public partial class frmPOS : Form
    {
        private ProductBL productBL;
        private CategoryBL categoryBL;
        public string orderType = "";
        public int? maBan = 0;
        public string tenBan = "";
        public string ghiChuOrder = "";
        public int selectedOrder = 0;
        public string trangThai = "Chờ xử lý";
        public int isAdmin = 0; // 1: admin, 0: nhân viên
        public int isThanhToan = 0; // 1: đã thanh toán, 0: chưa thanh toán
        public double tongTien = 0; // Tổng tiền của đơn hàng
        public double tienNhan = 0; // Tiền khách đưa
        public double tienThua = 0; // Tiền thừa trả lại cho khách
        public double giamGia = 0; // Giảm giá nếu có
        public frmPOS(int isAdmin_)
        {
            InitializeComponent();
            productBL = new ProductBL();
            categoryBL = new CategoryBL();
            isAdmin = isAdmin_; // Lưu giá trị isAdmin từ tham số truyền vào
        }
        private void frmPOS_Load(object sender, EventArgs e)
        {
            ShowCurrentTime();
            dataGridView.RowTemplate.Height = 30;
            LoadProducts();
            LoadCategories();

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
        private void LoadProducts()
        {
            List<Product> products = productBL.GetListProductsForMenu();
            foreach (Product p in products)
            {
                Image productImage;
                //p.HinhAnh is byte[] imageArray
                //---kiểm tra biến p.HinhAnh có phải kiểu byte[] không,
                //---nếu đúng thì tự động gán nó cho biến mới tên là imageArray.
                if (p.HinhAnh != null && p.HinhAnh is byte[] imageArray)
                {
                    productImage = Image.FromStream(new MemoryStream(imageArray));
                }
                else
                {
                    // Dùng ảnh mặc định nếu không có ảnh
                    productImage = Properties.Resources.icons8_restaurant_48;
                }

                CreateItemProducts(p.MaSanPham.ToString(), p.TenSanPham, p.TenDanhMuc.ToString(),
                         p.GiaSanPham.ToString(), productImage);
            }

        }
        private void CreateItemProducts(string proID, string name, string cat, string price, Image img)
        {
            var ucpro = new UserControlOneProduct()
            {
                MaSanPham = int.Parse(proID),
                TenSanPham = name,
                GiaSanPham = price,
                HinhAnh = img,
                category = cat
            };
            flowLayoutPanelProduct.Controls.Add((ucpro));

            ucpro.onSelect += (sender, e) =>
            {
                var selectedProduct = (UserControlOneProduct)sender;

                foreach (DataGridViewRow item in dataGridView.Rows)
                {
                    if (Convert.ToInt32(item.Cells["MaSanPham"].Value) == selectedProduct.MaSanPham)
                    {
                        item.Cells["SoLuong"].Value = int.Parse(item.Cells["SoLuong"].Value.ToString()) + 1;
                        item.Cells["ThanhTien"].Value = int.Parse(item.Cells["SoLuong"].Value.ToString()) *
                                                        double.Parse(item.Cells["GiaSanPham"].Value.ToString());
                        GetTotal();//chon cung 1 product
                        return;
                    }
                }
                int stt = dataGridView.Rows.Count + 1;
                Image hinhDelete = Properties.Resources.icons8_trash_30;

                dataGridView.Rows.Add(new object[] {  selectedProduct.MaSanPham,stt, selectedProduct.TenSanPham,
                    selectedProduct.GiaSanPham, 1, selectedProduct.GiaSanPham,hinhDelete });
                GetTotal();//chon product khac
            };
        }
        private void GetTotal()
        {
            double total = 0;
            labelTotal.Text = "";
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                total += double.Parse(item.Cells["ThanhTien"].Value.ToString());
            }
            labelTotal.Text = total.ToString();
        }
        private void LoadCategories()
        {
            List<Category> categories = categoryBL.GetAllCategories().Where(c => c.TrangThai == 1).ToList();// Lọc danh mục đang hoạt động
            Button button = new Button();
            button.Size = new Size(170, 50);
            button.BackColor = Color.FromArgb(255, 128, 0);

            button.Text = "Tất cả";
            button.Click += new EventHandler(buttonDM_Click);
            flowLayoutPanelCategory.Controls.Add(button);
            foreach (Category c in categories)
            {
                Button buttonCat = new Button();
                buttonCat.Size = new Size(170, 50);
                buttonCat.BackColor = Color.FromArgb(255, 128, 0);
                buttonCat.Text = c.TenDanhMuc;
                buttonCat.Click += new EventHandler(buttonCat_Click);
                flowLayoutPanelCategory.Controls.Add(buttonCat);
            }
        }
        private void buttonCat_Click(object sender, EventArgs e)
        {
            Button cat = (Button)sender;
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var product = (UserControlOneProduct)item;
                product.Visible = product.category.ToLower().Contains(cat.Text.Trim().ToLower());
            }
        }
        private void buttonDM_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var product = (UserControlOneProduct)item;
                product.Visible = true;
            }
        }
        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            if (isAdmin == 1)
            {
                this.Close(); // Đóng form nếu là admin
                Form form = new frmBangDieuKhien();
                form.Show(); // Hiển thị form BangDieuKhien
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng cửa sổ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close(); // Đóng form nếu không phải admin
                    Form form = new frmDangNhap();
                    form.Show(); // Hiển thị form đăng nhập
                }
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var pro = (UserControlOneProduct)item;
                pro.Visible = pro.TenSanPham.ToLower().Contains(textBoxSearch.Text.Trim().ToLower());
            }
        }
        private void labelNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            labelTotal.Text = "0";
            dataGridView.Rows.Clear();
            ghiChuOrder = "";
            orderType = "";
            maBan = 0;
            tenBan = "";
            labelTable.Visible = false;
            panelInfo.Visible = false;
            ghiChuOrder = "";
            enableButtons(true); // Kích hoạt lại các nút khi tạo đơn hàng mới
            selectedOrder = 0; // Đặt lại mã đơn hàng đã chọn
        }
        private void labelDinin_Click(object sender, EventArgs e)
        {
            orderType = "Ăn tại bàn";
            Form form = new frmSelectTable();

            if (form.ShowDialog() == DialogResult.OK)
            {
                maBan = ((frmSelectTable)form).SelectedTableId;
                tenBan = ((frmSelectTable)form).SelectedTableName;

            }
            if (maBan != 0)
            {
                labelTable.Text = tenBan.ToString();
                labelTable.Visible = true;
                panelInfo.Visible = true;
            }
            else
            {
                labelTable.Visible = false;
                panelInfo.Visible = false;
            }
            buttonCash.Visible = false; // Hiển thị nút thanh toán
        }
        private void labelTakeAway_Click(object sender, EventArgs e)
        {
            buttonCash.Visible = true; // Hiển thị nút thanh toán
            orderType = "Mang đi";
            labelTable.Text = orderType;
            labelTable.Visible = true;
            panelInfo.Visible = true;
        }
        private void labelSendKitchen_Click(object sender, EventArgs e)
        {
            if (orderType == "")
            {
                MessageBox.Show("Vui lòng chọn loại đơn hàng trước khi gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (orderType == "Mang đi" && isThanhToan == 0)
            {
                MessageBox.Show("Đơn này chưa được thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (orderType == "Ăn tại bàn")
            {
                Order order = new Order
                {
                    LoaiDonHang = orderType,
                    TrangThai = "Chờ xử lý",
                    DaThanhToan = "Chưa thanh toán",
                    TongTien = tongTien,
                    TienNhan = tienNhan,
                    TienThua = tienThua,
                    GiamGia = giamGia,
                    MaBan = maBan == 0 ? null : maBan, // Nếu maBan là 0 thì để null
                    GhiChu = ghiChuOrder,
                    ThoiGian = DateTime.Now,
                    Details = GetOrderDetailsFromGrid()
                };
                selectedOrder = OrderBL.SaveOrder(order, selectedOrder);

                if (selectedOrder > 0)
                {
                    MessageBox.Show("Luu đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearForm();
            }
        }
        private List<OrderDetail> GetOrderDetailsFromGrid()
        {
            var details = new List<OrderDetail>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                details.Add(new OrderDetail
                {
                    MaSanPham = Convert.ToInt32(row.Cells["MaSanPham"].Value),
                    SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),

                });
            }
            return details;
        }
        private void labelNote_Click(object sender, EventArgs e)
        {
            Form form = new frmNoteOrder();
            ((frmNoteOrder)form).note = ghiChuOrder; // Truyền ghi chú hiện tại vào form ghi chú
            if (form.ShowDialog() == DialogResult.OK)
            {
                ghiChuOrder = ((frmNoteOrder)form).note;
            }


            if (ghiChuOrder != "")
            {

                labelIsNOte.Visible = true;
            }
            else
            {
                labelIsNOte.Visible = false;
            }
        }
        private void labelList_Click(object sender, EventArgs e)
        {
            Form form = new frmListOrder();
            if (form.ShowDialog() == DialogResult.OK)
            {
                enableButtons(false); // Vô hiệu hóa các nút khi đang xem danh sách đơn hàng
                buttonCash.Visible = true; // Hiển thị nút thanh toán

                selectedOrder = ((frmListOrder)form).maDonHang; // Lấy mã đơn hàng đã chọn từ frmListOrder
                if (selectedOrder != 0)
                {
                    OrderBL orderBL = new OrderBL();
                    Order order = orderBL.GetOrderById(selectedOrder);

                    if (order != null)
                    {
                        dataGridView.Rows.Clear();
                        foreach (var detail in order.Details)
                        {

                            int stt = dataGridView.Rows.Count + 1;
                            Image hinhDelete = Properties.Resources.icons8_trash_30;
                            dataGridView.Rows.Add(new object[] { detail.MaSanPham, stt, detail.TenSanPham, detail.GiaSanPham, detail.SoLuong, detail.SoLuong * detail.GiaSanPham, hinhDelete });

                        }
                        GetTotal();

                        if (order.MaBan != null)
                        {
                            maBan = order.MaBan.Value; // Chuyển đổi từ int? sang int
                            tenBan = order.TenBan;
                        }

                        if (maBan != 0)
                        {
                            labelTable.Text = order.TenBan;
                            labelTable.Visible = true;
                            panelInfo.Visible = true;
                        }
                        else
                        {
                            labelTable.Text = orderType;
                            labelTable.Visible = true;
                            panelInfo.Visible = true;
                        }
                        ghiChuOrder = order.GhiChu;
                        if (!string.IsNullOrEmpty(ghiChuOrder))
                        {
                            labelIsNOte.Visible = true;
                        }
                        else
                        {
                            labelIsNOte.Visible = false;
                        }
                        orderType = order.LoaiDonHang;
                        if (orderType != "")
                        {
                            labelTable.Text = orderType;
                        }
                        string daThanhToan = order.DaThanhToan;
                        if (daThanhToan == "Đã thanh toán")
                        {
                            buttonCash.Text = "Đã thanh toán"; // Cập nhật nút thanh toán
                            buttonCash.Enabled = false; // Vô hiệu hóa nút thanh toán
                        }
                        else
                        {
                            buttonCash.Text = "Thanh toán"; // Cập nhật nút thanh toán
                            buttonCash.Enabled = true; // Kích hoạt nút thanh toán
                        }
                        trangThai = order.TrangThai;
                    }
                }
            }
        }
        private void enableButtons(bool enable)
        {
            flowLayoutPanelProduct.Enabled = enable;
            labelSendKitchen.Enabled = enable;
            labelTakeAway.Enabled = enable;
            labelDinin.Enabled = enable;
            labelNote.Enabled = enable;
        }
        private void buttonCash_Click(object sender, EventArgs e)
        {
            if (trangThai != "Hoàn thành")
            {
                MessageBox.Show("Đơn hàng chưa hoàn thành, không thể thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedOrder == 0 && orderType == "Ăn taị bàn")
            {
                MessageBox.Show("Vui lòng tạo hóa đơn trước khi thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form form = new frmPayment();
            ((frmPayment)form).selectedOrder = selectedOrder;
            ((frmPayment)form).orderType = orderType;
            //((frmPayment)form).maBan = maBan;
            //((frmPayment)form).tenBan = tenBan;
            //((frmPayment)form).ghiChuOrder = ghiChuOrder;
            //((frmPayment)form).tienNhan = tienNhan;
            //((frmPayment)form).tienThua = tienThua;
            //((frmPayment)form).giamGia = giamGia;
            ((frmPayment)form).total = double.Parse(labelTotal.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isThanhToan = 1; // Đánh dấu đơn hàng đã thanh toán
            }
            ClearForm();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            int delColumnIndex = dataGridView.Columns["delete"].Index;
            if (row < 0) return;// nếu không có dòng nào được chọn thì thoát hàm
            //xoas dòng
            if (col == delColumnIndex)
            {

                dataGridView.Rows.RemoveAt(row);
                GetTotal();

            }

        }
    }
}

