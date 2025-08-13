using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class frmSelectTable : Form

    {
        private TableBL tableBL;
        private TableStatusBL tableStatusBL;
        public int SelectedTableId { get; set; } // Biến lưu mã bàn được chọn
        public string SelectedTableName { get; set; } // Biến lưu tên bàn được chọn
        public frmSelectTable()
        {
            InitializeComponent();
            tableBL = new TableBL();
            tableStatusBL = new TableStatusBL();
        }

        private void frmSelectTable_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadTrangThaiBan();

        }

        private void LoadTrangThaiBan()
        {
            List<TableStatus> trangThaiBans = tableStatusBL.GetAllTableStatuses();

            foreach (TableStatus trangThaiBan in trangThaiBans)
            {
                // Tạo panel chứa 1 màu + 1 chú thích
                Panel panel = new Panel();
                panel.Width = 190;
                panel.Height = 30;
                panel.Margin = new Padding(5, 30, 0, 0);
                panel.BackColor = Color.Transparent;
                //panel.BorderStyle = BorderStyle.FixedSingle;

                // Label màu
                System.Windows.Forms.Label labelColor = new System.Windows.Forms.Label();
                labelColor.Width = 20;
                labelColor.Height = 20;
                //labelColor.BorderStyle = BorderStyle.FixedSingle;
                labelColor.AutoSize = false; // Không tự động điều chỉnh kích thước
                labelColor.Margin = new Padding(0);

                switch (trangThaiBan.MaTrangThai)
                {
                    case 1:
                        labelColor.BackColor = Color.FromArgb(225, 225, 225); // Trống
                        break;
                    case 2:
                        labelColor.BackColor = Color.FromArgb(225, 192, 0); // Đặt trước
                        break;
                    case 3:
                        labelColor.BackColor = Color.FromArgb(0, 192, 0); // Có khách


                        break;
                    case 4:
                        labelColor.BackColor = Color.Gray;
                        break;
                }

                // Label chữ
                System.Windows.Forms.Label labelText = new System.Windows.Forms.Label();
                labelText.Text = trangThaiBan.TrangThai;
                labelText.Width = 170;
                //labelText.Height = 30;
                labelText.Location = new Point(35, 0);
                labelText.TextAlign = ContentAlignment.MiddleLeft;
                //labelText.BorderStyle = BorderStyle.FixedSingle;

                // Thêm vào panel
                panel.Controls.Add(labelColor);
                panel.Controls.Add(labelText);

                // Thêm panel vào flow layout
                flowLayoutPanelChuThich.Controls.Add(panel);
            }

        }

        private void LoadTable()
        {
            List<Table> tables = tableBL.GetAllTables();
            foreach (Table table in tables)
            {
                var ucTable = new UserControlOneTable();
                if (table.MaDonHang != 0)
                {
                    ucTable = new UserControlOneTable()
                    {
                        MaBan = table.MaBan,
                        TenBan = table.TenBan,
                        SoLuongCho = table.SoChoNgoi,
                        MaDonHang = table.MaDonHang // Hiển thị mã đơn hàng nếu có
                    };
                    ucTable.Enabled = false; // Nếu bàn đã có đơn hàng thì không cho chọn
                }
                else
                {
                    ucTable = new UserControlOneTable()
                    {
                        MaBan = table.MaBan,
                        TenBan = table.TenBan,
                        SoLuongCho = table.SoChoNgoi,

                    };
                }

                ucTable.Margin = new Padding(10);
                ucTable.BorderStyle = BorderStyle.FixedSingle;
                // Thiết lập màu sắc theo trạng thái bàn
                //de tam cai mau vao sau
                switch (table.MaTrangThai)
                {
                    case 1:
                        ucTable.BackColor = Color.FromArgb(225, 225, 225); // Available - white
                        break;
                    case 2:
                        ucTable.BackColor = Color.FromArgb(255, 192, 0); // Reserved 
                        //ucTable.Enabled = false;
                        break;
                    case 3:
                        ucTable.BackColor = Color.FromArgb(0, 192, 0); // Occupied - xanh
                        break;
                    case 4:
                        ucTable.BackColor = Color.Gray; // Default color
                        break;
                }
                flowLayoutPanelTable.Controls.Add((ucTable));

                ucTable.onSelect += (sender, e) =>
                {
                    SelectedTableId = ucTable.MaBan; // Lưu mã bàn được chọn
                    SelectedTableName = ucTable.TenBan; // Lưu tên bàn được chọn
                    this.DialogResult = DialogResult.OK; // Đặt kết quả của form là OK
                    this.Close(); // Đóng form
                };

            }
        }



        private void panelChuThich_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
