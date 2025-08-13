using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Resources
{
    public partial class frmNoteOrder : Form
    {
        public string note = ""; // Biến lưu trữ ghi chú đơn hàng
        public frmNoteOrder()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            note = textBoxNoteOrder.Text;
            this.DialogResult = DialogResult.OK; // Trả về kết quả OK khi lưu thành công
            this.Close(); // Đóng form sau khi lưu
        }

        private void frmNoteOrder_Load(object sender, EventArgs e)
        {
            textBoxNoteOrder.Text = note; // Hiển thị ghi chú hiện tại trong TextBox
        }
    }
}
