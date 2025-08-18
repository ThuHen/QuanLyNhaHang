using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class frmListOrder : Form
    {
        private OrderBL orderBL;
        public int maDonHang { get; set; } // Biến để lưu mã đơn hàng khi sửa

        public frmListOrder()
        {
            InitializeComponent();
            orderBL = new OrderBL();

        }

        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadListOrder(0);//All type

        }
        private void LoadListOrder(int option)
        {
            List<Order> listAllOrders = orderBL.GetListOrders()
                .Where(o => o.DaThanhToan != "Đã thanh toán" || o.TrangThai != "Hoàn thành")
                .OrderByDescending(o => o.ThoiGian).ToList(); // hoặc .OrderBy(o => o.ThoiGian) nếu cần tăng dần
            List<Order> listOrders = new List<Order>();

            switch (option)
            {
                case 0:
                    listOrders = listAllOrders;
                    break;
                case 1:
                    listOrders = listAllOrders.Where(o => o.LoaiDonHang == "Ăn tại bàn").ToList();
                    break;
                case 2:
                    listOrders = listAllOrders.Where(o => o.LoaiDonHang == "Mang đi").ToList();
                    break;
            }
            dataGridView1.AutoGenerateColumns = false;// cai truoc khi gan
            dataGridView1.DataSource = listOrders;
            labelSum.Text = listOrders.Count.ToString();


            dataGridView1.Columns[1].DataPropertyName = "MaDonHang";
            dataGridView1.Columns[2].DataPropertyName = "TenBan";
            dataGridView1.Columns[5].DataPropertyName = "LoaiDonHang";
            dataGridView1.Columns[0].DataPropertyName = "ThoiGian";
            dataGridView1.Columns[3].DataPropertyName = "TrangThai";
            dataGridView1.Columns[4].DataPropertyName = "DaThanhToan";
        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            int editColumnIndex = dataGridView1.Columns["Edit"].Index;
            int printColumnIndex = dataGridView1.Columns["ColPrint"].Index;
            if (row < 0) return;
            
            string id = dataGridView1.Rows[row].Cells["MaDonHang"].Value.ToString();

            if (col == editColumnIndex)
            {
                // Lấy giá trị trạng thái từ row
                //string trangThai = dataGridView1.Rows[row].Cells["TrangThai"].Value.ToString();
                //if (trangThai == "Hoàn thành")
                //{
                //    MessageBox.Show("Đơn hàng đã hoàn thành, không thể sửa.");
                //    return;
                //}
                // Xử lý sửa
                maDonHang = int.Parse(id);

                this.DialogResult = DialogResult.OK; //tra ve selected order
                this.Hide();

            }
            else if (col == printColumnIndex)
            {
                // Xử lý in hoa do
                Print(id);
            }
        }

        private void Print(string id)
        {
            frmPrint frm = new frmPrint();
            int selectedOrderId = int.Parse(id);
            Order bill = orderBL.GetOrderById(selectedOrderId);

            string ngay = bill.ThoiGian.ToString("dd/MM/yyyy");
            string gio = bill.ThoiGian.ToString("HH:mm");
            string tenBan = bill.TenBan;
            double tienNhan = bill.TienNhan;
            double tienThua = bill.TienThua;
            double giamGia = bill.GiamGia;
            double tongTien = bill.TongTien;
            Reports._ReportDataSet__ ds = new Reports._ReportDataSet__();
            var dt = ds.BillReportDataTable;
            foreach (var item in bill.Details)
            {
                var row = dt.NewRow();
                row["Date"] = ngay;
                row["Time"] = gio;
                row["OrderId"] = id;
                row["TableName"] = tenBan;
                row["Received"] = tienNhan;
                row["Change"] = tienThua;
                row["Total"] = tongTien;
                row["Discount"] = giamGia;
                row["ThanhTien"] = tongTien - giamGia;
                row["ProductName"] = item.TenSanPham;
                row["Qty"] = item.SoLuong;
                row["Price"] = item.GiaSanPham;
                row["Amount"] = item.GiaSanPham * item.SoLuong;
                dt.Rows.Add(row);
            }

            //Gắn DataSet vào ReportSource
            Reports.reportBill rpt = new Reports.reportBill();
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.Show();
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadListOrder(1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadListOrder(2);
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadListOrder(0);
        }
    }
}
