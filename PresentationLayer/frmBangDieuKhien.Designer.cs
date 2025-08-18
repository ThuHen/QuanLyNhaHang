namespace PresentationLayer
{
    partial class frmBangDieuKhien
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxMinForm = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxMaxForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonTongQuan = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonMonAn = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonDanhMuc = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonPOS = new System.Windows.Forms.Button();
            this.buttonKitchen = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTop.Controls.Add(this.pictureBoxMinForm);
            this.panelTop.Controls.Add(this.labelTime);
            this.panelTop.Controls.Add(this.pictureBoxMaxForm);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1267, 50);
            this.panelTop.TabIndex = 7;
            // 
            // pictureBoxMinForm
            // 
            this.pictureBoxMinForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMinForm.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_26;
            this.pictureBoxMinForm.Location = new System.Drawing.Point(1122, 6);
            this.pictureBoxMinForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMinForm.Name = "pictureBoxMinForm";
            this.pictureBoxMinForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMinForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinForm.TabIndex = 12;
            this.pictureBoxMinForm.TabStop = false;
            this.pictureBoxMinForm.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTime.Location = new System.Drawing.Point(587, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(168, 50);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMaxForm
            // 
            this.pictureBoxMaxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaxForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxMaxForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMaxForm.Image = global::PresentationLayer.Properties.Resources.icons8_maximize_window_26;
            this.pictureBoxMaxForm.Location = new System.Drawing.Point(1169, 6);
            this.pictureBoxMaxForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMaxForm.Name = "pictureBoxMaxForm";
            this.pictureBoxMaxForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMaxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaxForm.TabIndex = 11;
            this.pictureBoxMaxForm.TabStop = false;
            this.pictureBoxMaxForm.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxClose.Image = global::PresentationLayer.Properties.Resources.icons8_close_window_26;
            this.pictureBoxClose.Location = new System.Drawing.Point(1217, 6);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 10;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLeft.Controls.Add(this.buttonTongQuan);
            this.panelLeft.Controls.Add(this.buttonLogout);
            this.panelLeft.Controls.Add(this.buttonMonAn);
            this.panelLeft.Controls.Add(this.buttonAccount);
            this.panelLeft.Controls.Add(this.buttonDanhMuc);
            this.panelLeft.Controls.Add(this.buttonReport);
            this.panelLeft.Controls.Add(this.buttonTable);
            this.panelLeft.Controls.Add(this.buttonStaff);
            this.panelLeft.Controls.Add(this.buttonSetting);
            this.panelLeft.Controls.Add(this.buttonPOS);
            this.panelLeft.Controls.Add(this.buttonKitchen);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(226, 664);
            this.panelLeft.TabIndex = 19;
            // 
            // buttonTongQuan
            // 
            this.buttonTongQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTongQuan.Location = new System.Drawing.Point(13, 19);
            this.buttonTongQuan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTongQuan.Name = "buttonTongQuan";
            this.buttonTongQuan.Size = new System.Drawing.Size(209, 52);
            this.buttonTongQuan.TabIndex = 7;
            this.buttonTongQuan.Text = "Tổng Quan";
            this.buttonTongQuan.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(13, 584);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(209, 48);
            this.buttonLogout.TabIndex = 17;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonMonAn
            // 
            this.buttonMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMonAn.Location = new System.Drawing.Point(13, 135);
            this.buttonMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMonAn.Name = "buttonMonAn";
            this.buttonMonAn.Size = new System.Drawing.Size(209, 48);
            this.buttonMonAn.TabIndex = 9;
            this.buttonMonAn.Text = "Món Ăn";
            this.buttonMonAn.UseVisualStyleBackColor = false;
            this.buttonMonAn.Click += new System.EventHandler(this.buttonMonAn_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(13, 472);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(209, 48);
            this.buttonAccount.TabIndex = 16;
            this.buttonAccount.Text = "Tài Khoản";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonDanhMuc
            // 
            this.buttonDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanhMuc.Location = new System.Drawing.Point(13, 79);
            this.buttonDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDanhMuc.Name = "buttonDanhMuc";
            this.buttonDanhMuc.Size = new System.Drawing.Size(209, 48);
            this.buttonDanhMuc.TabIndex = 8;
            this.buttonDanhMuc.Text = "Danh mục";
            this.buttonDanhMuc.UseVisualStyleBackColor = false;
            this.buttonDanhMuc.Click += new System.EventHandler(this.buttonDanhMuc_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(13, 416);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(209, 48);
            this.buttonReport.TabIndex = 15;
            this.buttonReport.Text = "Thống kê";
            this.buttonReport.UseVisualStyleBackColor = false;
            // 
            // buttonTable
            // 
            this.buttonTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTable.Location = new System.Drawing.Point(13, 191);
            this.buttonTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(209, 48);
            this.buttonTable.TabIndex = 10;
            this.buttonTable.Text = "Bàn Ăn";
            this.buttonTable.UseVisualStyleBackColor = false;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStaff.Location = new System.Drawing.Point(13, 360);
            this.buttonStaff.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(209, 48);
            this.buttonStaff.TabIndex = 13;
            this.buttonStaff.Text = "Nhân Viên";
            this.buttonStaff.UseVisualStyleBackColor = false;
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(13, 528);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(209, 48);
            this.buttonSetting.TabIndex = 14;
            this.buttonSetting.Text = "Cài Đặt";
            this.buttonSetting.UseVisualStyleBackColor = false;
            // 
            // buttonPOS
            // 
            this.buttonPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPOS.Location = new System.Drawing.Point(13, 248);
            this.buttonPOS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPOS.Name = "buttonPOS";
            this.buttonPOS.Size = new System.Drawing.Size(209, 48);
            this.buttonPOS.TabIndex = 11;
            this.buttonPOS.Text = "POS";
            this.buttonPOS.UseVisualStyleBackColor = false;
            this.buttonPOS.Click += new System.EventHandler(this.buttonPOS_Click);
            // 
            // buttonKitchen
            // 
            this.buttonKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKitchen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonKitchen.Location = new System.Drawing.Point(13, 304);
            this.buttonKitchen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKitchen.Name = "buttonKitchen";
            this.buttonKitchen.Size = new System.Drawing.Size(209, 48);
            this.buttonKitchen.TabIndex = 12;
            this.buttonKitchen.Text = "Nhà Bếp";
            this.buttonKitchen.UseVisualStyleBackColor = false;
            this.buttonKitchen.Click += new System.EventHandler(this.buttonKitchen_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(226, 50);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1041, 664);
            this.panelCenter.TabIndex = 20;
            // 
            // frmBangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBangDieuKhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangDieuKhien";
            this.Load += new System.EventHandler(this.frmBangDieuKhien_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxMaxForm;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinForm;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonTongQuan;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonMonAn;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonDanhMuc;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonPOS;
        private System.Windows.Forms.Button buttonKitchen;
        private System.Windows.Forms.Panel panelCenter;
    }
}