namespace PresentationLayer
{
    partial class UserControlProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageAddEdit = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxMota = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMota = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabControlProduct.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProduct
            // 
            this.tabControlProduct.Controls.Add(this.tabPageList);
            this.tabControlProduct.Controls.Add(this.tabPageAddEdit);
            this.tabControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProduct.Location = new System.Drawing.Point(0, 0);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.Size = new System.Drawing.Size(1071, 740);
            this.tabControlProduct.TabIndex = 1;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.buttonTotal);
            this.tabPageList.Controls.Add(this.textBoxSearch);
            this.tabPageList.Controls.Add(this.labelSearch);
            this.tabPageList.Controls.Add(this.panelData);
            this.tabPageList.ForeColor = System.Drawing.Color.Black;
            this.tabPageList.Location = new System.Drawing.Point(4, 34);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(1063, 702);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Danh sách";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // buttonTotal
            // 
            this.buttonTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTotal.Location = new System.Drawing.Point(395, 19);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(60, 30);
            this.buttonTotal.TabIndex = 4;
            this.buttonTotal.Text = "buttonTotal";
            this.buttonTotal.UseVisualStyleBackColor = false;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(139, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(238, 30);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(42, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(91, 25);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Tìm kiếm";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(3, 192);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1057, 507);
            this.panelData.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1057, 507);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // tabPageAddEdit
            // 
            this.tabPageAddEdit.Controls.Add(this.buttonCancel);
            this.tabPageAddEdit.Controls.Add(this.comboBoxCategory);
            this.tabPageAddEdit.Controls.Add(this.label3);
            this.tabPageAddEdit.Controls.Add(this.buttonUpload);
            this.tabPageAddEdit.Controls.Add(this.label2);
            this.tabPageAddEdit.Controls.Add(this.pictureBoxImage);
            this.tabPageAddEdit.Controls.Add(this.textBoxPrice);
            this.tabPageAddEdit.Controls.Add(this.label1);
            this.tabPageAddEdit.Controls.Add(this.labelstatus);
            this.tabPageAddEdit.Controls.Add(this.checkBoxOn);
            this.tabPageAddEdit.Controls.Add(this.buttonSave);
            this.tabPageAddEdit.Controls.Add(this.textBoxMota);
            this.tabPageAddEdit.Controls.Add(this.textBoxName);
            this.tabPageAddEdit.Controls.Add(this.labelMota);
            this.tabPageAddEdit.Controls.Add(this.labelName);
            this.tabPageAddEdit.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddEdit.Name = "tabPageAddEdit";
            this.tabPageAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEdit.Size = new System.Drawing.Size(1063, 702);
            this.tabPageAddEdit.TabIndex = 1;
            this.tabPageAddEdit.Text = "Tạo mới ";
            this.tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(525, 461);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 49);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(173, 207);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(304, 33);
            this.comboBoxCategory.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại sản phẩm";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpload.ForeColor = System.Drawing.Color.Black;
            this.buttonUpload.Location = new System.Drawing.Point(585, 224);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(140, 43);
            this.buttonUpload.TabIndex = 15;
            this.buttonUpload.Text = "Tải ảnh lên";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hình ảnh";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::PresentationLayer.Properties.Resources.icons8_restaurant_64;
            this.pictureBoxImage.Location = new System.Drawing.Point(755, 177);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(113, 104);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 13;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(585, 124);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(283, 30);
            this.textBoxPrice.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giá tiền";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(580, 310);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(100, 25);
            this.labelstatus.TabIndex = 10;
            this.labelstatus.Text = "Trạng thái";
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.Checked = true;
            this.checkBoxOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOn.Location = new System.Drawing.Point(585, 347);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(124, 29);
            this.checkBoxOn.TabIndex = 9;
            this.checkBoxOn.Text = "Hoạt động";
            this.checkBoxOn.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(344, 461);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 49);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxMota
            // 
            this.textBoxMota.Location = new System.Drawing.Point(173, 284);
            this.textBoxMota.Multiline = true;
            this.textBoxMota.Name = "textBoxMota";
            this.textBoxMota.Size = new System.Drawing.Size(304, 92);
            this.textBoxMota.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(173, 124);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // labelMota
            // 
            this.labelMota.AutoSize = true;
            this.labelMota.Location = new System.Drawing.Point(168, 256);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(61, 25);
            this.labelMota.TabIndex = 2;
            this.labelMota.Text = "Mô tả";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(168, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(138, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên sản phẩm";
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabControlProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(1071, 740);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            this.tabControlProduct.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageAddEdit.ResumeLayout(false);
            this.tabPageAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPageAddEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxMota;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMota;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
    }
}
