namespace PresentationLayer
{
    partial class frmPOS
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelNote = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelTable = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.labelTakeAway = new System.Windows.Forms.Label();
            this.labelSendKitchen = new System.Windows.Forms.Label();
            this.labelDinin = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.pictureBoxCloseForm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.flowLayoutPanelCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelIsNOte = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelIsNOte);
            this.panelTop.Controls.Add(this.labelNote);
            this.panelTop.Controls.Add(this.panelInfo);
            this.panelTop.Controls.Add(this.labelList);
            this.panelTop.Controls.Add(this.labelTakeAway);
            this.panelTop.Controls.Add(this.labelSendKitchen);
            this.panelTop.Controls.Add(this.labelDinin);
            this.panelTop.Controls.Add(this.labelNew);
            this.panelTop.Controls.Add(this.pictureBoxCloseForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1476, 133);
            this.panelTop.TabIndex = 0;
            // 
            // labelNote
            // 
            this.labelNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelNote.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.labelNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNote.Location = new System.Drawing.Point(902, 9);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(92, 101);
            this.labelNote.TabIndex = 12;
            this.labelNote.Text = "Ghi chú";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNote.Click += new System.EventHandler(this.labelNote_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.labelTable);
            this.panelInfo.Location = new System.Drawing.Point(388, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(200, 98);
            this.panelInfo.TabIndex = 0;
            this.panelInfo.Visible = false;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(19, 15);
            this.labelTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(54, 25);
            this.labelTable.TabIndex = 12;
            this.labelTable.Text = "table";
            this.labelTable.Visible = false;
            // 
            // labelList
            // 
            this.labelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelList.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.labelList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelList.Location = new System.Drawing.Point(1201, 9);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(129, 101);
            this.labelList.TabIndex = 11;
            this.labelList.Text = "Danh sách";
            this.labelList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelList.Click += new System.EventHandler(this.labelList_Click);
            // 
            // labelTakeAway
            // 
            this.labelTakeAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTakeAway.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.labelTakeAway.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTakeAway.Location = new System.Drawing.Point(802, 9);
            this.labelTakeAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTakeAway.Name = "labelTakeAway";
            this.labelTakeAway.Size = new System.Drawing.Size(92, 101);
            this.labelTakeAway.TabIndex = 10;
            this.labelTakeAway.Text = "Mang đi";
            this.labelTakeAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelTakeAway.Click += new System.EventHandler(this.labelTakeAway_Click);
            // 
            // labelSendKitchen
            // 
            this.labelSendKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSendKitchen.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.labelSendKitchen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSendKitchen.Location = new System.Drawing.Point(1002, 9);
            this.labelSendKitchen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendKitchen.Name = "labelSendKitchen";
            this.labelSendKitchen.Size = new System.Drawing.Size(92, 101);
            this.labelSendKitchen.TabIndex = 9;
            this.labelSendKitchen.Text = "Gửi bếp";
            this.labelSendKitchen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelSendKitchen.Click += new System.EventHandler(this.labelSendKitchen_Click);
            // 
            // labelDinin
            // 
            this.labelDinin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDinin.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.labelDinin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDinin.Location = new System.Drawing.Point(702, 9);
            this.labelDinin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDinin.Name = "labelDinin";
            this.labelDinin.Size = new System.Drawing.Size(92, 101);
            this.labelDinin.TabIndex = 8;
            this.labelDinin.Text = "Tại bàn";
            this.labelDinin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDinin.Click += new System.EventHandler(this.labelDinin_Click);
            // 
            // labelNew
            // 
            this.labelNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelNew.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.labelNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNew.Location = new System.Drawing.Point(1101, 9);
            this.labelNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(92, 101);
            this.labelNew.TabIndex = 3;
            this.labelNew.Text = "Tạo mới";
            this.labelNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNew.Click += new System.EventHandler(this.labelNew_Click);
            // 
            // pictureBoxCloseForm
            // 
            this.pictureBoxCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxCloseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCloseForm.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.pictureBoxCloseForm.Location = new System.Drawing.Point(1400, 20);
            this.pictureBoxCloseForm.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pictureBoxCloseForm.Name = "pictureBoxCloseForm";
            this.pictureBoxCloseForm.Size = new System.Drawing.Size(54, 57);
            this.pictureBoxCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCloseForm.TabIndex = 3;
            this.pictureBoxCloseForm.TabStop = false;
            this.pictureBoxCloseForm.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.labelTime);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 133);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1476, 48);
            this.panelSearch.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1101, 10);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(48, 25);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "time";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(311, 10);
            this.textBoxSearch.MaxLength = 150;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(291, 30);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.button1);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.labelTotal);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 670);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1476, 124);
            this.panelBottom.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1017, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1261, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng tiền:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1360, 37);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 25);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "0,000";
            // 
            // flowLayoutPanelCategory
            // 
            this.flowLayoutPanelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelCategory.Location = new System.Drawing.Point(0, 181);
            this.flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            this.flowLayoutPanelCategory.Size = new System.Drawing.Size(186, 489);
            this.flowLayoutPanelCategory.TabIndex = 3;
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.dataGridView);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOrder.Location = new System.Drawing.Point(871, 181);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(605, 489);
            this.panelOrder.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.STT,
            this.TenSanPham,
            this.GiaSanPham,
            this.SoLuong,
            this.ThanhTien,
            this.delete});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(605, 489);
            this.dataGridView.TabIndex = 0;
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            this.MaSanPham.Visible = false;
            this.MaSanPham.Width = 125;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Món";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 200;
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.FillWeight = 60F;
            this.GiaSanPham.HeaderText = "Đơn giá";
            this.GiaSanPham.MinimumWidth = 6;
            this.GiaSanPham.Name = "GiaSanPham";
            this.GiaSanPham.ReadOnly = true;
            this.GiaSanPham.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 40;
            // 
            // ThanhTien
            // 
            this.ThanhTien.FillWeight = 80F;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 130;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 30;
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(186, 181);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(685, 489);
            this.flowLayoutPanelProduct.TabIndex = 5;
            // 
            // labelIsNOte
            // 
            this.labelIsNOte.AutoSize = true;
            this.labelIsNOte.Location = new System.Drawing.Point(269, 28);
            this.labelIsNOte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIsNOte.Name = "labelIsNOte";
            this.labelIsNOte.Size = new System.Drawing.Size(112, 25);
            this.labelIsNOte.TabIndex = 13;
            this.labelIsNOte.Text = "Có ghi chú!";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 794);
            this.Controls.Add(this.flowLayoutPanelProduct);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.flowLayoutPanelCategory);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategory;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelSendKitchen;
        private System.Windows.Forms.Label labelDinin;
        private System.Windows.Forms.Label labelTakeAway;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelIsNOte;
    }
}