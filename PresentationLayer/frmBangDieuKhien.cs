using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmBangDieuKhien : Form
    {
        public frmBangDieuKhien()
        {
            InitializeComponent();
            ShowCurrentTime();
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

        public void AddUserControl(UserControl frm)
        {
            panelCenter.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            //frm.TopLevel = false;
            panelCenter.Controls.Add(frm);
            frm.Show();
        }

        private void buttonDanhMuc_Click(object sender, EventArgs e)
        {
            AddUserControl(new UserControlCategory());
        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form form = new frmDangNhap();
            form.Show();
            this.Hide();
        }

        private void buttonMonAn_Click(object sender, EventArgs e)
        {
            AddUserControl(new UserControlProduct());
        }
    }
}
