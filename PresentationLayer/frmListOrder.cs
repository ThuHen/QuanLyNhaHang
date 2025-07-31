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
    public partial class frmListOrder : Form
    {
        private OrderBL orderBL;
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
            dataGridView1.DataSource = listOrders;
            labelSum.Text = listOrders.Count.ToString();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns[0].DataPropertyName = "MaDonHang";
            dataGridView1.Columns[1].DataPropertyName = "TenBan";
            dataGridView1.Columns[2].DataPropertyName = "LoaiDonHang";
            dataGridView1.Columns[3].DataPropertyName = "ThoiGian";
            dataGridView1.Columns[4].DataPropertyName = "TrangThai";
            dataGridView1.Columns[5].DataPropertyName = "DaThanhToan";
        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
