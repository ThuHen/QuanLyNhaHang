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

namespace PresentationLayer
{
    public partial class frmDangNhap : Form
    {
        private AccountBL accountBL;
        public frmDangNhap()
        {
            InitializeComponent();
            accountBL = new AccountBL();
            
            buttonLogin.FlatStyle = FlatStyle.Flat; // Đặt kiểu phẳng cho nút đăng nhập
            buttonLogin.FlatAppearance.BorderSize = 0;


        }

        private Account ValidateLogin(string username, string password)
        {
            try
            {
                return accountBL.Login(username, password);
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Account currentUser = ValidateLogin(username, password);
            if (currentUser != null)
            {
                if (currentUser.MaPhanQuyen == 1)
                {
                    //BangDieuKhien frm = new BangDieuKhien(currentUser);
                    frmBangDieuKhien frm = new frmBangDieuKhien();
                    frm.Show();
                }
                else if (currentUser.MaPhanQuyen == 2)
                {
                    frmPOS frm = new frmPOS(0);
                    frm.Show();
                }
                else if (currentUser.MaPhanQuyen == 3)
                {
                }
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void pictureBoxMinimizeForm_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimizeForm, "Thu nhỏ cửa sổ");
        }

        private void pictureBoxCloseForm_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxCloseForm, "Đóng cửa sổ");
        }


        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Hiển thị mật khẩu");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Ẩn mật khẩu");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Visible = true;
            pictureBoxShow.Visible = false;
            textBoxPassword.UseSystemPasswordChar = false; // Hiển thị mật khẩu
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Visible = false;
            pictureBoxShow.Visible = true;
            textBoxPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu
        }
        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

       
    }
}
