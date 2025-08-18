using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class UserControlProduct : UserControl
    {
        private ProductBL productBL;
        public byte[] imageByteArray = null;
        public string maSanPhamEdit = "";
        public UserControlProduct()
        {
            InitializeComponent();
            productBL = new ProductBL();
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            LoadCategory();
            textBoxSearch.Focus();
            SetupColumns();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAllProducts();
        }
        private void LoadAllProducts()
        {
            try
            {
                if (textBoxSearch.Text == "")
                {
                    dataGridView.DataSource = productBL.GetAllProducts().OrderBy(c => c.TenSanPham).ToList();
                }
                else
                {
                    dataGridView.DataSource = productBL.GetAllProducts()
                             .Where(c => c.TenSanPham.ToLower().Contains(textBoxSearch.Text.ToLower()))
                             .OrderBy(c => c.TenSanPham)
                             .ToList();
                }
                buttonTotal.Text = dataGridView.Rows.Count.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCategory()
        {
            CategoryBL category = new CategoryBL();
            List<Category> categoryList = category.GetAllCategories().OrderBy(c => c.TenDanhMuc).ToList();
            comboBoxCategory.DataSource = categoryList;
            comboBoxCategory.DisplayMember = "TenDanhMuc";
            comboBoxCategory.ValueMember = "MaDanhMuc";
            comboBoxCategory.SelectedIndex = -1;

            Icon defaultIcon = SystemIcons.Application;
            pictureBoxImage.Image = defaultIcon.ToBitmap();
            //pictureBoxImage.Image = Properties.Resources.icons8_food_bar_100;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();
            }
        }
        private void SetupColumns()
        {

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ẩn hoặc chỉnh sửa các cột
            dataGridView.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["TenSanPham"].FillWeight = 50;

            dataGridView.Columns["GiaSanPham"].HeaderText = "Giá sản phẩm";
            dataGridView.Columns["GiaSanPham"].FillWeight = 30;

            dataGridView.Columns["TenDanhMuc"].HeaderText = "Tên danh mục";
            dataGridView.Columns["TenDanhMuc"].FillWeight = 40;

            dataGridView.Columns["HinhAnh"].HeaderText = "Hình ảnh";
            //dataGridView.Columns["HinhAnh"].FillWeight = 30;
            ((DataGridViewImageColumn)dataGridView.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;


            dataGridView.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView.Columns["TrangThai"].FillWeight = 20;

            dataGridView.Columns["MoTa"].HeaderText = "Mô tả";
            dataGridView.Columns["MoTa"].FillWeight = 90;

            // Ẩn hoặc chỉnh sửa các cột
            dataGridView.Columns["MaSanPham"].Visible = false;
            dataGridView.Columns["MaDanhMuc"].Visible = false;
            //dataGridView.Columns["HinhAnh"].Visible = false;
            dataGridView.RowTemplate.Height = 50;

            // Cột Edit
            DataGridViewImageColumn colEdit = new DataGridViewImageColumn();
            colEdit.Name = "Edit";
            colEdit.HeaderText = "";
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEdit.Image = Properties.Resources.icons8_edit_pencil_30;
            dataGridView.Columns.Add(colEdit);

            // Cột Delete
            DataGridViewImageColumn colDelete = new DataGridViewImageColumn();
            colDelete.Name = "Delete";
            colDelete.HeaderText = "";
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDelete.Image = Properties.Resources.icons8_trash_30;
            dataGridView.Columns.Add(colDelete);

        }
        private void buttonTotal_Click(object sender, EventArgs e)
        {
            buttonTotal.Text = dataGridView.Rows.Count.ToString();
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(.jpg, .png)|*.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                pictureBoxImage.Image = new Bitmap(filePath);
            }
            Image temp = new Bitmap(pictureBoxImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            //MessageBox.Show("col: " + col + " row: " + row);

            int editColumnIndex = dataGridView.Columns["Edit"].Index;
            int deleteColumnIndex = dataGridView.Columns["Delete"].Index;
            if (row < 0) return;
            string id = dataGridView.Rows[row].Cells["MaSanPham"].Value.ToString();

            if (col == editColumnIndex)
            {
                // Xử lý sửa
                SwitchToEdit(id);

            }
            else if (col == deleteColumnIndex)
            {
                // Xử lý xóa
                Delete(id);
            }
        }
        private void Delete(string id)
        {
            // Need to confirm before delete
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Attempt to delete the category
                    productBL.Del(id);

                    MessageBox.Show("Xóa thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadAllProducts(); // Tải lại danh sách sản phẩm

                }

                catch (SqlException sqlEx)
                {
                    // Nếu là lỗi khác, hiển thị thông báo lỗi chung
                    MessageBox.Show("Đã có lỗi xảy ra khi xóa danh mục: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SwitchToEdit(string id)
        {
            // Lấy giá trị tên hiện tại từ dòng đang chọn
            string currentName = dataGridView.CurrentRow.Cells["TenSanPham"].Value.ToString();
            string currentPrice = dataGridView.CurrentRow.Cells["GiaSanPham"].Value.ToString();
            string currentDescription = dataGridView.CurrentRow.Cells["MoTa"].Value.ToString();
            int currentStatus = Convert.ToInt32(dataGridView.CurrentRow.Cells["TrangThai"].Value);
            int currentCategoryId = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaDanhMuc"].Value);
            imageByteArray = (byte[])dataGridView.CurrentRow.Cells["HinhAnh"].Value;
            // Mở tab sửa
            tabControlProduct.SelectedTab = tabPageAddEdit;
            tabPageAddEdit.Text = "Chỉnh sửa";
            textBoxName.Text = currentName;
            textBoxPrice.Text = currentPrice;
            textBoxMota.Text = currentDescription;
            if (currentStatus == 1)
            {
                checkBoxOn.Checked = true;
            }
            else
            {
                checkBoxOn.Checked = false;
            }
            comboBoxCategory.SelectedValue = currentCategoryId;
            if (imageByteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(imageByteArray))
                {
                    pictureBoxImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxImage.Image = null; // Nếu không có hình ảnh, đặt hình ảnh là null
            }
            maSanPhamEdit = id;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //save
            if (maSanPhamEdit != "")
            {
                // Chỉnh sửa sản phẩm
                EditProduct();
            }
            else
            {
                // Thêm sản phẩm mới
                AddProduct();
            }

        }
        private void AddProduct()
        {
            string name, price, categoryId, mota;
            name = textBoxName.Text.Trim();
            price = textBoxPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            categoryId = comboBoxCategory.SelectedValue.ToString();
            int trangThai = checkBoxOn.Checked ? 1 : 0;
            mota = textBoxMota.Text.Trim();
            try
            {
                double.Parse(price);
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ. Vui lòng nhập số.",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            Product product = new Product(name, double.Parse(price), int.Parse(categoryId), mota, trangThai, imageByteArray);
            try
            {
                int numberOfRows = productBL.Add(product);
                if (numberOfRows > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    LoadAllProducts(); // Tải lại danh sách sản phẩm
                    resetInputField(); // Reset thông tin nhập


                    textBoxName.Focus();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void EditProduct()
        {
            Product product = new Product(textBoxName.Text.Trim(), double.Parse(textBoxPrice.Text.Trim()),
                int.Parse(comboBoxCategory.SelectedValue.ToString()), textBoxMota.Text.Trim(),
                checkBoxOn.Checked ? 1 : 0, imageByteArray);
            try
            {
                // Attempt to delete the category
                productBL.Edit(maSanPhamEdit, product);
                MessageBox.Show("Chỉnh sửa thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                LoadAllProducts();
                resetInputField();
                tabControlProduct.SelectedTab = tabPageList; // Quay lại tab danh sách
                tabPageAddEdit.Text = "Tạo mới";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi sửa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resetInputField()
        {
            maSanPhamEdit = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxMota.Text = "";
            checkBoxOn.Checked = true;
            pictureBoxImage.Image = null; // Xóa hình ảnh đã chọn 
            comboBoxCategory.SelectedIndex = -1;
        }
        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            resetInputField();
            tabControlProduct.SelectedTab = tabPageList; // Quay lại tab danh sách
            tabPageAddEdit.Text = "Tạo mới";
        }
    }
}
