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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonPOS = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonKitchen = new System.Windows.Forms.Button();
            this.buttonTongQuan = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonDanhMuc = new System.Windows.Forms.Button();
            this.buttonMonAn = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloseForm = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelLeft.Controls.Add(this.buttonLogout);
            this.panelLeft.Controls.Add(this.labelName);
            this.panelLeft.Controls.Add(this.buttonPOS);
            this.panelLeft.Controls.Add(this.buttonAccount);
            this.panelLeft.Controls.Add(this.buttonKitchen);
            this.panelLeft.Controls.Add(this.buttonTongQuan);
            this.panelLeft.Controls.Add(this.buttonTable);
            this.panelLeft.Controls.Add(this.buttonReport);
            this.panelLeft.Controls.Add(this.buttonStaff);
            this.panelLeft.Controls.Add(this.buttonDanhMuc);
            this.panelLeft.Controls.Add(this.buttonMonAn);
            this.panelLeft.Controls.Add(this.buttonSetting);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(254, 714);
            this.panelLeft.TabIndex = 6;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(13, 631);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(233, 48);
            this.buttonLogout.TabIndex = 17;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(11, 11);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(239, 50);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Quản Lý Nhà Hàng";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPOS
            // 
            this.buttonPOS.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPOS.Location = new System.Drawing.Point(13, 296);
            this.buttonPOS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPOS.Name = "buttonPOS";
            this.buttonPOS.Size = new System.Drawing.Size(233, 48);
            this.buttonPOS.TabIndex = 11;
            this.buttonPOS.Text = "Tạo đơn";
            this.buttonPOS.UseVisualStyleBackColor = true;
            this.buttonPOS.Click += new System.EventHandler(this.buttonPOS_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(13, 519);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(233, 48);
            this.buttonAccount.TabIndex = 16;
            this.buttonAccount.Text = "Tài Khoản";
            this.buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonKitchen
            // 
            this.buttonKitchen.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonKitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKitchen.Location = new System.Drawing.Point(14, 352);
            this.buttonKitchen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKitchen.Name = "buttonKitchen";
            this.buttonKitchen.Size = new System.Drawing.Size(233, 48);
            this.buttonKitchen.TabIndex = 12;
            this.buttonKitchen.Text = "Nhà Bếp";
            this.buttonKitchen.UseVisualStyleBackColor = true;
            // 
            // buttonTongQuan
            // 
            this.buttonTongQuan.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTongQuan.Location = new System.Drawing.Point(14, 72);
            this.buttonTongQuan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTongQuan.Name = "buttonTongQuan";
            this.buttonTongQuan.Size = new System.Drawing.Size(233, 48);
            this.buttonTongQuan.TabIndex = 7;
            this.buttonTongQuan.Text = "Tổng Quan";
            this.buttonTongQuan.UseVisualStyleBackColor = true;
            // 
            // buttonTable
            // 
            this.buttonTable.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTable.Location = new System.Drawing.Point(14, 240);
            this.buttonTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(233, 48);
            this.buttonTable.TabIndex = 10;
            this.buttonTable.Text = "Bàn Ăn";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(13, 463);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(233, 48);
            this.buttonReport.TabIndex = 15;
            this.buttonReport.Text = "Thống kê";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonStaff
            // 
            this.buttonStaff.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStaff.Location = new System.Drawing.Point(13, 408);
            this.buttonStaff.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(233, 47);
            this.buttonStaff.TabIndex = 13;
            this.buttonStaff.Text = "Nhân Viên";
            this.buttonStaff.UseVisualStyleBackColor = true;
            // 
            // buttonDanhMuc
            // 
            this.buttonDanhMuc.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanhMuc.Location = new System.Drawing.Point(14, 128);
            this.buttonDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDanhMuc.Name = "buttonDanhMuc";
            this.buttonDanhMuc.Size = new System.Drawing.Size(233, 48);
            this.buttonDanhMuc.TabIndex = 8;
            this.buttonDanhMuc.Text = "Danh mục";
            this.buttonDanhMuc.UseVisualStyleBackColor = true;
            this.buttonDanhMuc.Click += new System.EventHandler(this.buttonDanhMuc_Click);
            // 
            // buttonMonAn
            // 
            this.buttonMonAn.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMonAn.Location = new System.Drawing.Point(13, 184);
            this.buttonMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMonAn.Name = "buttonMonAn";
            this.buttonMonAn.Size = new System.Drawing.Size(233, 48);
            this.buttonMonAn.TabIndex = 9;
            this.buttonMonAn.Text = "Món Ăn";
            this.buttonMonAn.UseVisualStyleBackColor = true;
            this.buttonMonAn.Click += new System.EventHandler(this.buttonMonAn_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Image = global::PresentationLayer.Properties.Resources.icons8_eye_24;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(13, 575);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(233, 48);
            this.buttonSetting.TabIndex = 14;
            this.buttonSetting.Text = "Cài Đặt";
            this.buttonSetting.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pictureBoxMinimize);
            this.panelTop.Controls.Add(this.pictureBoxMaximize);
            this.panelTop.Controls.Add(this.pictureBoxCloseForm);
            this.panelTop.Controls.Add(this.labelTime);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(254, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1013, 61);
            this.panelTop.TabIndex = 7;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMinimize.Image = global::PresentationLayer.Properties.Resources.icons8_horizontal_line_64;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(871, 11);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 10;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxMaximize
            // 
            this.pictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxMaximize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMaximize.Image = global::PresentationLayer.Properties.Resources.icons8_horizontal_line_64;
            this.pictureBoxMaximize.Location = new System.Drawing.Point(918, 11);
            this.pictureBoxMaximize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMaximize.Name = "pictureBoxMaximize";
            this.pictureBoxMaximize.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximize.TabIndex = 3;
            this.pictureBoxMaximize.TabStop = false;
            this.pictureBoxMaximize.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // pictureBoxCloseForm
            // 
            this.pictureBoxCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxCloseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCloseForm.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.pictureBoxCloseForm.Location = new System.Drawing.Point(966, 11);
            this.pictureBoxCloseForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxCloseForm.Name = "pictureBoxCloseForm";
            this.pictureBoxCloseForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCloseForm.TabIndex = 2;
            this.pictureBoxCloseForm.TabStop = false;
            this.pictureBoxCloseForm.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTime.Location = new System.Drawing.Point(18, 6);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(239, 50);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(254, 61);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1013, 653);
            this.panelCenter.TabIndex = 8;
            // 
            // frmBangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBangDieuKhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangDieuKhien";
            this.Load += new System.EventHandler(this.frmBangDieuKhien_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonTongQuan;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonKitchen;
        private System.Windows.Forms.Button buttonPOS;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonMonAn;
        private System.Windows.Forms.Button buttonDanhMuc;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxMaximize;
        private System.Windows.Forms.PictureBox pictureBoxCloseForm;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelCenter;
    }
}