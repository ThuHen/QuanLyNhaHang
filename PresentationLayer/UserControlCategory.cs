using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class UserControlCategory : UserControl
    {
        private CategoryBL categoryBL;
        public string maDanhMucEdit;
        public UserControlCategory()
        {
            InitializeComponent();
            categoryBL = new CategoryBL();
        }

        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
            textBoxSearch.Focus();
            SetupColumns();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCategories();

        }
        private void LoadCategories()
        {
            try
            {
                if (textBoxSearch.Text == "")
                {
                    dataGridView.DataSource = categoryBL.GetAllCategories().OrderBy(c => c.TenDanhMuc).ToList();
                }
                else
                {
                    dataGridView.DataSource = categoryBL.GetAllCategories()
     .Where(c => c.TenDanhMuc.ToLower().Contains(textBoxSearch.Text.ToLower()))
     .OrderBy(c => c.TenDanhMuc)
     .ToList();
                }
                buttonTotal.Text = dataGridView.Rows.Count.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetupColumns()
        {
            // Ẩn hoặc chỉnh sửa các cột
            dataGridView.Columns["MaDanhMuc"].Visible = false;
            dataGridView.Columns["NgayTao"].Visible = false;
            dataGridView.Columns["NgayCapNhat"].HeaderText = "Ngày Cập Nhật";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns["TenDanhMuc"].HeaderText = "Tên danh mục";
            dataGridView.Columns["TenDanhMuc"].FillWeight = 40;

            dataGridView.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView.Columns["TrangThai"].FillWeight = 20;

            dataGridView.Columns["MoTa"].HeaderText = "Mô tả";
            dataGridView.Columns["MoTa"].FillWeight = 90;
            dataGridView.RowTemplate.Height = 30;
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
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            //MessageBox.Show("col: " + col + " row: " + row);
            
            int editColumnIndex = dataGridView.Columns["Edit"].Index;
            int deleteColumnIndex = dataGridView.Columns["Delete"].Index;
            if (row < 0) return;
            string id = dataGridView.Rows[row].Cells["MaDanhMuc"].Value.ToString();

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
                    categoryBL.Del(id);

                    MessageBox.Show("Xóa thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadCategories();

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
            string currentName = dataGridView.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            string currentDescription = dataGridView.CurrentRow.Cells["MoTa"].Value.ToString();
            int currentStatus = Convert.ToInt32(dataGridView.CurrentRow.Cells["TrangThai"].Value);

            // Mở tab sửa
            tabControlCategory.SelectedTab = tabPageAddEdit;
            tabPageAddEdit.Text = "Chỉnh sửa";
            textBoxName.Text = currentName;
            textBoxMota.Text = currentDescription;
            if (currentStatus == 1)
            {
                checkBoxOn.Checked = true;
            }
            else
            {
                checkBoxOn.Checked = false;
            }
            maDanhMucEdit = id;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(maDanhMucEdit))
            {
                AddCategory();
            }
            else
            {
                EditCategory();

            }
        }

        private void AddCategory() {
            string text = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Vui lòng điền tên danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Category category = new Category(text, textBoxMota.Text.Trim(), checkBoxOn.Checked ? 1 : 0);
            try
            {
                int numberOfRows = categoryBL.Add(category);
                if (numberOfRows > 0)
                {
                    MessageBox.Show("Thêm danh mục thành công!");
                    LoadCategories();
                    resetInputField();
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Danh mục này đã tồn tại, không thể tạo thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditCategory()
        {
            Category category = new Category(textBoxName.Text.Trim(), textBoxMota.Text.Trim(), checkBoxOn.Checked ? 1 : 0);
            try
            {
                // Attempt to delete the category
                categoryBL.Edit(maDanhMucEdit, category);
                MessageBox.Show("Chỉnh sửa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
                resetInputField();
                tabControlCategory.SelectedTab = tabPageList; // Quay lại tab danh sách
                tabPageAddEdit.Text = "Tạo mới";
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi sửa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resetInputField()
        {
            textBoxName.Clear();
            textBoxMota.Clear();
            checkBoxOn.Checked = true; // Đặt lại trạng thái về "Hoạt động"
            maDanhMucEdit = string.Empty; // Reset mã danh mục đang chỉnh sửa
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            resetInputField();
            tabControlCategory.SelectedTab = tabPageList; // Quay lại tab danh sách
            tabPageAddEdit.Text = "Tạo mới";
        }
    }
}
