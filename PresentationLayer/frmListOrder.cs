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
            LoadListOrder(0);
           
        }
        private void LoadListOrder(int option)
        {
            List<Order> listOrders= new List<Order>();
            switch (option)
            {
                case 0:
                    listOrders = orderBL.GetListOrders().OrderByDescending(o => o.ThoiGian).ToList(); // hoặc .OrderBy(o => o.ThoiGian) nếu cần tăng dần
                    break;
                case 1:
                    listOrders = orderBL.GetListOrders().Where(o => o.LoaiDonHang == "Ăn tại bàn").OrderByDescending(o => o.ThoiGian).ToList();
                    break;
                case 2:
                    listOrders = orderBL.GetListOrders().Where(o => o.LoaiDonHang == "Mang đi").OrderByDescending(o => o.ThoiGian).ToList();
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
            //Print frm = new Print();


            //mainID = Convert.ToInt32(dgvOrders.CurrentRow.Cells["MainID"].Value);

            //List<FullBillDetail> bill = orderBL.GetFullBillDetails(mainID);

            //DataTable dt = new DataTable("BillReportTableName");

            //dt.Columns.Add("Date", typeof(DateTime));
            //dt.Columns.Add("Time", typeof(string));

            //dt.Columns.Add("OrderType", typeof(string));
            //dt.Columns.Add("CusName", typeof(string));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("TableName", typeof(string));
            //dt.Columns.Add("Received", typeof(double));
            //dt.Columns.Add("Change", typeof(double));




            //dt.Columns.Add("Qty", typeof(int));
            //dt.Columns.Add("Amount", typeof(double));
            //dt.Columns.Add("Price", typeof(double));
            //dt.Columns.Add("WaiterName", typeof(string));

            //foreach (var item in bill)
            //{
            //    dt.Rows.Add(item.Date, item.Time, item.OrderType, item.CusName, item.Name, item.TableName,
            //         item.Received, item.Change, item.Qty, item.Amount, item.Price, item.WaiterName);
            //}

            //// Gắn DataSet vào ReportSource

            //reportBill rpt = new reportBill();
            //rpt.SetDataSource(dt);
            //frm.crystalReportViewer2.ReportSource = rpt;
            //frm.Show();
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
