using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PresentationLayer
{
    public partial class UserControlAccount : UserControl
    {
        private AccountBL accountBL;
        private string maAccountEdit = ""; // Biến lưu mã tài khoản đang chỉnh sửa
        private List<object> roles = new List<object>()
        {
            new { Text = "Quản trị", Value = 1 },
            new { Text = "Thu ngân", Value = 2 },
            new { Text = "Bếp", Value = 3 }
        };
        public UserControlAccount()
        {
            InitializeComponent();
            accountBL = new AccountBL();
        }
        private void UserControlAccount_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            textBoxSearch.Focus();
            SetupColumns();


            comboBoxChucVu.DataSource = roles;
            comboBoxChucVu.DisplayMember = "Text";
            comboBoxChucVu.ValueMember = "Value";
            comboBoxChucVu.SelectedIndex = -1; // Đặt giá trị mặc định

        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            buttonTotal.Text = dataGridView.Rows.Count.ToString();
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAccounts();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            //MessageBox.Show("col: " + col + " row: " + row);

            int editColumnIndex = dataGridView.Columns["Edit"].Index;
            int deleteColumnIndex = dataGridView.Columns["Delete"].Index;
            if (row < 0) return;
            string id = dataGridView.Rows[row].Cells["MaTaiKhoan"].Value.ToString();

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
        private void LoadAccounts()
        {
            List<Account> accounts = accountBL.GetAllAccount().OrderBy(c => c.MaPhanQuyen).ToList();
            try
            {
                if (textBoxSearch.Text == "")
                {
                    dataGridView.DataSource = accounts;
                }
                else
                {
                    dataGridView.DataSource = accounts
                         .Where(c => c.TenDangNhap.ToLower().Contains(textBoxSearch.Text.ToLower()))
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
            dataGridView.ReadOnly = true;
            // Ẩn hoặc chỉnh sửa các cột
            dataGridView.Columns["MaTaiKhoan"].Visible = false;
            dataGridView.Columns["MaPhanQuyen"].Visible = false; 
            dataGridView.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView.Columns["MatKhau"].HeaderText = "Mật khẩu";
            //dataGridView.Columns["MaPhanQuyen"].HeaderText = "Mã phân quyền";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động điều chỉnh kích thước cột

            dataGridView.Columns["TenDangNhap"].FillWeight = 100;
            dataGridView.Columns["MatKhau"].FillWeight = 70;
           

            dataGridView.RowTemplate.Height = 30; // Chiều cao của mỗi hàng trong DataGridView

            //
            DataGridViewComboBoxColumn colRole = new DataGridViewComboBoxColumn();
            colRole.HeaderText = "Chức vụ";
            colRole.DataPropertyName = "MaPhanQuyen"; // Cột trong DataSource (DB)
            colRole.DataSource = roles;
            colRole.DisplayMember = "Text";   // Hiển thị chữ
            colRole.ValueMember = "Value";    // Lưu số
            colRole.Width = 100;  
            //colRole.ReadOnly = true;
            dataGridView.Columns.Add(colRole);
            

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
                    accountBL.Del(id);

                    MessageBox.Show("Xóa thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    LoadAccounts();
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
            string loginName = dataGridView.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            string matKhau = dataGridView.CurrentRow.Cells["MatKhau"].Value.ToString();
            int maPhanQuyen = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaPhanQuyen"].Value);

            // Mở tab sửa
            tabControlAccount.SelectedTab = tabPageAddEdit;
            tabPageAddEdit.Text = "Chỉnh sửa";
            textBoxName.Text = loginName;
            textBoxMatKhau.Text = matKhau;
            comboBoxChucVu.SelectedValue = maPhanQuyen;
            maAccountEdit = id;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (maAccountEdit == "")
            {
                AddAccount();
            }
            else
            {
                EditAccount();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            resetInputField();
            tabControlAccount.SelectedTab = tabPageList; // Quay lại tab danh sách
            tabPageAddEdit.Text = "Tạo mới";
        }
        private void AddAccount()
        {
            string loginName = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(loginName))
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string password = textBoxMatKhau.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maPhanQuyen = Convert.ToInt32(comboBoxChucVu.SelectedValue);
            if (maPhanQuyen <= 0)
            {
                MessageBox.Show("Vui lòng chọn phân quyền cho tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Account account = new Account
            {
                TenDangNhap = loginName,
                MatKhau = password,
                MaPhanQuyen = maPhanQuyen
            };
            try
            {
                int numberOfRows = accountBL.Add(account);
                if (numberOfRows > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccounts();
                    resetInputField();
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Tài khoản này đã tồn tại, không thể tạo thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditAccount()
        {
            Account account = new Account
            {
                TenDangNhap = textBoxName.Text.Trim(),
                MatKhau = textBoxMatKhau.Text.Trim(),
                MaPhanQuyen = Convert.ToInt32(comboBoxChucVu.SelectedValue)
            };
            try
            {
                accountBL.Edit(maAccountEdit, account);
                MessageBox.Show("Chỉnh sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccounts();
                resetInputField();
                tabControlAccount.SelectedTab = tabPageList; // Quay lại tab danh sách
                tabPageAddEdit.Text = "Tạo mới";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi sửa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void resetInputField()
        {
            textBoxName.Text = "";
            textBoxMatKhau.Text = "";
            comboBoxChucVu.SelectedIndex = 0; // Đặt lại về giá trị đầu tiên
            maAccountEdit = ""; // Reset mã tài khoản đang chỉnh sửa
            comboBoxChucVu.SelectedIndex = -1; // Đặt giá trị mặc định không chọn
        }
    }
}
