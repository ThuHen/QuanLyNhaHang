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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PresentationLayer
{
    public partial class UserControlTable : UserControl
    {
        private TableBL tableBL;
        private TableStatusBL tableStatusBL;
        public UserControlTable()
        {
            InitializeComponent();
            tableBL = new TableBL();
            tableStatusBL = new TableStatusBL();
        }

        private void UserControlTable_Load(object sender, EventArgs e)
        {
            LoadAllTables();
            LoadTrangThaiBanToComboBox();
            textBoxSearch.Focus();
            SetupColumns();


        }
        private void LoadTrangThaiBanToComboBox()
        {
            comboBoxTrangThaiBan.DataSource = tableStatusBL.GetAllTableStatuses();
            comboBoxTrangThaiBan.DisplayMember = "TrangThai";
            comboBoxTrangThaiBan.ValueMember = "MaTrangThai";
            comboBoxTrangThaiBan.SelectedIndex = 0; // Chọn trạng thái đầu tiên

            //if (catID > 0)
            //{
            //    cbCat.SelectedValue = catID;
            //}

        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAllTables();

        }
        private void SetupColumns()
        {
            // Ẩn hoặc chỉnh sửa các cột
            dataGridView.Columns["MaBan"].Visible = false;
            dataGridView.Columns["NgayTao"].Visible = false;
            dataGridView.Columns["MaTrangThai"].Visible = false;

            dataGridView.Columns["NgayCapNhat"].HeaderText = "Ngày Cập Nhật";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns["TenBan"].HeaderText = "Tên bàn";
            dataGridView.Columns["TenBan"].FillWeight = 40;

            dataGridView.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView.Columns["TrangThai"].FillWeight = 50;

            dataGridView.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridView.Columns["GhiChu"].FillWeight = 50;

            dataGridView.Columns["SoChoNgoi"].HeaderText = "Số chỗ ngồi";
            dataGridView.Columns["SoChoNgoi"].FillWeight = 40;

            dataGridView.Columns["ViTri"].HeaderText = "Vị trí";
            dataGridView.Columns["ViTri"].FillWeight = 50;
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

        private void LoadAllTables()
        {
            try
            {
                if (textBoxSearch.Text == "")
                {
                    dataGridView.DataSource = tableBL.GetAllTables().OrderBy(c => c.TenBan).ToList();
                }
                else
                {
                    dataGridView.DataSource = tableBL.GetAllTables()
     .Where(c => c.TenBan.ToLower().Contains(textBoxSearch.Text.ToLower()))
     .OrderBy(c => c.TenBan)
     .ToList();
                }
                buttonTotal.Text = dataGridView.Rows.Count.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string id = dataGridView.Rows[row].Cells["MaBan"].Value.ToString();

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
                    tableBL.Del(id);

                    MessageBox.Show("Xóa thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadAllTables();

                }

                catch (SqlException sqlEx)
                {


                    // Nếu là lỗi khác, hiển thị thông báo lỗi chung
                    MessageBox.Show("Đã có lỗi xảy ra khi xóa danh mục: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }
        public string maBanEdit = "";
        private void SwitchToEdit(string id)
        {
            // Lấy giá trị tên hiện tại từ dòng đang chọn
            string currentName = dataGridView.CurrentRow.Cells["TenBan"].Value.ToString();
            string currentDescription = dataGridView.CurrentRow.Cells["GhiChu"].Value.ToString();
            int currentStatus = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaTrangThai"].Value);
            int currentSoChoNgoi = Convert.ToInt32(dataGridView.CurrentRow.Cells["SoChoNgoi"].Value);
            string currentViTri = dataGridView.CurrentRow.Cells["ViTri"].Value.ToString();


            // Mở tab sửa
            tabControlTable.SelectedTab = tabPageAddEdit;
            tabPageAddEdit.Text = "Chỉnh sửa";
            textBoxMota.Text = currentDescription;
            textBoxName.Text = currentName;
            comboBoxTrangThaiBan.SelectedValue = currentStatus;
            numericUpDownChoNgoi.Value = currentSoChoNgoi;
            textBoxVitri.Text = currentViTri;
            // Lưu mã bàn để chỉnh sửa

            maBanEdit = id;
        }

        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // save
            if (maBanEdit != "")
            {
                // Chỉnh sửa sản phẩm
                EditTable();
            }
            else
            {
                // Thêm sản phẩm mới
                AddTable();
            }
        }

        private void EditTable()
        {


            Table table = new Table
            {
                TenBan = textBoxName.Text.Trim(),
                ViTri = textBoxVitri.Text.Trim(),
                MaTrangThai = Convert.ToInt32(comboBoxTrangThaiBan.SelectedValue),
                SoChoNgoi = Convert.ToInt32(numericUpDownChoNgoi.Value),
                GhiChu = textBoxMota.Text.Trim(),
                
            };
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(table.TenBan) || string.IsNullOrEmpty(table.ViTri) || table.MaTrangThai <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            try
            {
                tableBL.Edit(maBanEdit, table);
                MessageBox.Show("Chỉnh sửa thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                LoadAllTables(); // Tải lại danh sách bàn
                resetInputField();
                tabControlTable.SelectedTab = tabPageList; // Quay lại tab danh sách
                tabPageAddEdit.Text = "Tạo mới";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi sửa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTable()
        {
            string name, soChoNgoi, trangThai, ghichu, vitri;
            name = textBoxName.Text.Trim();
            soChoNgoi = numericUpDownChoNgoi.Value.ToString();
            trangThai = comboBoxTrangThaiBan.SelectedValue.ToString();
            ghichu = textBoxMota.Text.Trim();
            vitri = textBoxVitri.Text.Trim();
            string viTri = textBoxVitri.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(soChoNgoi) || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            Table table = new Table(name, viTri, int.Parse(trangThai),int.Parse(soChoNgoi), ghichu );
            try
            {
                int numberOfRows = tableBL.Add(table);
                if (numberOfRows > 0)
                {
                    MessageBox.Show("Thêm bàn thành công!");
                    LoadAllTables(); // Tải lại danh sách bàn
                    resetInputField(); // Reset thông tin nhập
                    textBoxName.Focus();
                    
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void resetInputField()
        {
            textBoxVitri.Text = "";
            textBoxMota.Text = "";
            textBoxName.Text = "";
            numericUpDownChoNgoi.Value = 1;
            comboBoxTrangThaiBan.SelectedIndex = 0; // Chọn trạng thái đầu tiên
            maBanEdit = ""; // Reset mã bàn đang chỉnh sửa

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            resetInputField();
            tabControlTable.SelectedTab = tabPageList; // Quay lại tab danh sách
            tabPageAddEdit.Text = "Tạo mới"; // Đặt lại tiêu đề tab
        }

        
    }
}
