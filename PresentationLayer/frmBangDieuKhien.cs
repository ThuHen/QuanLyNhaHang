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
        public void AddForm(Form frm)
        {
            panelCenter.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
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

        private void buttonTable_Click(object sender, EventArgs e)
        {
            AddUserControl(new UserControlTable());
        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            Form frm = new frmPOS(1);
            frm.Show();
            this.Hide();
        }

        private void frmBangDieuKhien_Load(object sender, EventArgs e)
        {
            ShowCurrentTime();
            //insertImgToButton(buttonTongQuan, Properties.Resources.icons8_chef_hat_100);
            //insertImgToButton(buttonDanhMuc, Properties.Resources.icons8_chef_hat_100);
            //insertImgToButton(buttonMonAn, Properties.Resources.icons8_chef_hat_100);
            //insertImgToButton(buttonTable, Properties.Resources.icons8_chef_hat_100);
            //insertImgToButton(buttonPOS, Properties.Resources.icons8_chef_hat_100);
            //insertImgToButton(buttonLogout, Properties.Resources.icons8_chef_hat_100);
        }
        private Image resizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
        private void insertImgToButton(Button button, Image image)
        {
            button.Image = resizeImage(image, 20, 20);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void buttonKitchen_Click(object sender, EventArgs e)
        {
            Form form = new frmKitchen(1);
            form.Show();
            this.Hide();
        }
    }
}
