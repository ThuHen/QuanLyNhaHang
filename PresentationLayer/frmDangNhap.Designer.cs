namespace PresentationLayer
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizeForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloseForm = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxMinimizeForm);
            this.panel1.Controls.Add(this.pictureBoxCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxMinimizeForm
            // 
            this.pictureBoxMinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.pictureBoxMinimizeForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMinimizeForm.Image = global::PresentationLayer.Properties.Resources.icons8_horizontal_line_64;
            this.pictureBoxMinimizeForm.Location = new System.Drawing.Point(351, 7);
            this.pictureBoxMinimizeForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMinimizeForm.Name = "pictureBoxMinimizeForm";
            this.pictureBoxMinimizeForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMinimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizeForm.TabIndex = 1;
            this.pictureBoxMinimizeForm.TabStop = false;
            this.pictureBoxMinimizeForm.Click += new System.EventHandler(this.pictureBoxMinimizeForm_Click);
            this.pictureBoxMinimizeForm.MouseHover += new System.EventHandler(this.pictureBoxMinimizeForm_MouseHover);
            // 
            // pictureBoxCloseForm
            // 
            this.pictureBoxCloseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCloseForm.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.pictureBoxCloseForm.Location = new System.Drawing.Point(398, 7);
            this.pictureBoxCloseForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxCloseForm.Name = "pictureBoxCloseForm";
            this.pictureBoxCloseForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCloseForm.TabIndex = 0;
            this.pictureBoxCloseForm.TabStop = false;
            this.pictureBoxCloseForm.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            this.pictureBoxCloseForm.MouseHover += new System.EventHandler(this.pictureBoxCloseForm_MouseHover);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(93, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 70);
            this.label2.TabIndex = 7;
            this.label2.Text = "ĐĂNG NHẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHide.Image = global::PresentationLayer.Properties.Resources.icons8_hide_100;
            this.pictureBoxHide.Location = new System.Drawing.Point(376, 332);
            this.pictureBoxHide.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHide.TabIndex = 15;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Visible = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShow.Image = global::PresentationLayer.Properties.Resources.icons8_eye_100;
            this.pictureBoxShow.Location = new System.Drawing.Point(376, 331);
            this.pictureBoxShow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 14;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.FlatAppearance.BorderSize = 3;
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.buttonLogin.Location = new System.Drawing.Point(41, 433);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(374, 60);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "ĐĂNG NHẬP";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(150, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quên mật khẩu?";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new System.Drawing.Point(41, 332);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(326, 34);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "123";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(36, 299);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(114, 27);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(41, 223);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(374, 34);
            this.textBoxUsername.TabIndex = 10;
            this.textBoxUsername.Text = "admin";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(36, 190);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(180, 27);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(450, 570);
            this.Controls.Add(this.pictureBoxHide);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCloseForm;
        private System.Windows.Forms.PictureBox pictureBoxMinimizeForm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lblUserName;
    }
}

