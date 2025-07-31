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
using TransferObject;

namespace PresentationLayer
{
    public partial class frmPOS : Form
    {
        private ProductBL productBL;
        private CategoryBL categoryBL;
        public frmPOS()
        {
            InitializeComponent();
            productBL = new ProductBL();
            categoryBL = new CategoryBL();
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
            List<Product> products = productBL.GetAllProducts();
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
            var ucpro = new UserControOneProduct()
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
                var selectedProduct = (UserControOneProduct)sender;

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
                Image hinh = selectedProduct.HinhAnh;
                dataGridView.Rows.Add(new object[] {  selectedProduct.MaSanPham,stt, selectedProduct.TenSanPham,
                    selectedProduct.GiaSanPham, 1, selectedProduct.GiaSanPham,hinh,hinh });
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
            List<Category> categories = categoryBL.GetAllCategories();
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
                var product = (UserControOneProduct)item;
                product.Visible = product.category.ToLower().Contains(cat.Text.Trim().ToLower());
            }
        }
        private void buttonDM_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var product = (UserControOneProduct)item;
                product.Visible = true;
            }
        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form form = new frmDangNhap();
                form.Show();
                this.Hide();

            }
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelProduct.Controls)
            {
                var pro = (UserControOneProduct)item;
                pro.Visible = pro.TenSanPham.ToLower().Contains(textBoxSearch.Text.Trim().ToLower());
            }
        }

        private void labelNew_Click(object sender, EventArgs e)
        {
            ClearForm();    
        }
        private void ClearForm()
        {
            //MainId = 0;
            //lblTable.Text = "";
            //lblWaiter.Text = "";
            //lblTable.Visible = false;
            //lblWaiter.Visible = false;
            labelTotal.Text = "0";
            //lbDriverName.Text = "";
            dataGridView.Rows.Clear();
            ghiChu = "";
            orderType = "";
            maBan = 0; 
        }
        public string orderType = "";
        private void labelDinin_Click(object sender, EventArgs e)
        {
            orderType = "Ăn tại bàn";
            Form form = new frmSelectTable();
            form.ShowDialog();
            //if (form is frmSelectTable selectTableForm)
            //{
            //    maBan = selectTableForm.SelectedTableId;
            //    ghiChu = selectTableForm.Note;
            //    if (maBan != 0)
            //    {
            //        labelTable.Text = "Bàn: " + maBan.ToString();
            //        labelTable.Visible = true;
            //    }
            //    else
            //    {
            //        labelTable.Visible = false;
            //    }
            //}
        }

        private void labelTakeAway_Click(object sender, EventArgs e)
        {
            orderType = "Mang đi";
        }
        public int? maBan = 0;
        public string ghiChu = "";
        public int selectedOrder = 0;
        private void labelSendKitchen_Click(object sender, EventArgs e)
        {

            Order order = new Order
            {
                LoaiDonHang = orderType,
                MaTrangThai = 0,
                DaThanhToan = "Chưa thanh toán",
                TongTien = 0,
                TienNhan = 0,
                TienThua = 0,
                MaBan = maBan == 0 ? null : maBan, // Nếu maBan là 0 thì để null
                GhiChu = ghiChu,
                ThoiGian = DateTime.Now,
                Details = GetOrderDetailsFromGrid()
            };

            //if (order.Details.Count == 0 || order.OrderType == "" || (order.OrderType == "Din In" && (order.TableName == "" || order.WaiterName == "")))
            //{
            //    MessageBox.Show("Can not kot!! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            int orderID = OrderBL.SaveOrder(order, selectedOrder);
            if (orderID > 0)
            {
                MessageBox.Show("Luu đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            //}
        }
        private List<OrderDetails> GetOrderDetailsFromGrid()
        {
            var details = new List<OrderDetails>();
            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                details.Add(new OrderDetails
                {
                    MaSanPham = Convert.ToInt32(row.Cells["MaSanPham"].Value),
                    SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                                      
                });
            }
            return details;
        }

    }
}
