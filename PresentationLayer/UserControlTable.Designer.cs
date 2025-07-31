namespace PresentationLayer
{
    partial class UserControlTable
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
            this.components = new System.ComponentModel.Container();
            this.tabControlTable = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageAddEdit = new System.Windows.Forms.TabPage();
            this.textBoxVitri = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMota = new System.Windows.Forms.TextBox();
            this.comboBoxTrangThaiBan = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelChoNgoi = new System.Windows.Forms.Label();
            this.numericUpDownChoNgoi = new System.Windows.Forms.NumericUpDown();
            this.labelMota = new System.Windows.Forms.Label();
            this.labelVitri = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelstatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlTable.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChoNgoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTable
            // 
            this.tabControlTable.Controls.Add(this.tabPageList);
            this.tabControlTable.Controls.Add(this.tabPageAddEdit);
            this.tabControlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTable.Location = new System.Drawing.Point(0, 0);
            this.tabControlTable.Name = "tabControlTable";
            this.tabControlTable.SelectedIndex = 0;
            this.tabControlTable.Size = new System.Drawing.Size(1449, 677);
            this.tabControlTable.TabIndex = 1;
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
            this.tabPageList.Size = new System.Drawing.Size(1441, 639);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Danh sách";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // buttonTotal
            // 
            this.buttonTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTotal.Location = new System.Drawing.Point(394, 16);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(60, 30);
            this.buttonTotal.TabIndex = 4;
            this.buttonTotal.Text = "buttonTotal";
            this.buttonTotal.UseVisualStyleBackColor = false;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(138, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(238, 30);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(41, 16);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(91, 25);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Tìm kiếm";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(3, 123);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1435, 513);
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
            this.dataGridView.Size = new System.Drawing.Size(1435, 513);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // tabPageAddEdit
            // 
            this.tabPageAddEdit.Controls.Add(this.textBoxVitri);
            this.tabPageAddEdit.Controls.Add(this.textBoxName);
            this.tabPageAddEdit.Controls.Add(this.textBoxMota);
            this.tabPageAddEdit.Controls.Add(this.comboBoxTrangThaiBan);
            this.tabPageAddEdit.Controls.Add(this.labelName);
            this.tabPageAddEdit.Controls.Add(this.labelChoNgoi);
            this.tabPageAddEdit.Controls.Add(this.numericUpDownChoNgoi);
            this.tabPageAddEdit.Controls.Add(this.labelMota);
            this.tabPageAddEdit.Controls.Add(this.labelVitri);
            this.tabPageAddEdit.Controls.Add(this.buttonSave);
            this.tabPageAddEdit.Controls.Add(this.buttonCancel);
            this.tabPageAddEdit.Controls.Add(this.labelstatus);
            this.tabPageAddEdit.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddEdit.Name = "tabPageAddEdit";
            this.tabPageAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEdit.Size = new System.Drawing.Size(1441, 639);
            this.tabPageAddEdit.TabIndex = 1;
            this.tabPageAddEdit.Text = "Tạo mới ";
            this.tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxVitri
            // 
            this.textBoxVitri.Location = new System.Drawing.Point(486, 178);
            this.textBoxVitri.Name = "textBoxVitri";
            this.textBoxVitri.Size = new System.Drawing.Size(281, 30);
            this.textBoxVitri.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(205, 178);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxMota
            // 
            this.textBoxMota.Location = new System.Drawing.Point(205, 271);
            this.textBoxMota.Multiline = true;
            this.textBoxMota.Name = "textBoxMota";
            this.textBoxMota.Size = new System.Drawing.Size(213, 83);
            this.textBoxMota.TabIndex = 3;
            // 
            // comboBoxTrangThaiBan
            // 
            this.comboBoxTrangThaiBan.FormattingEnabled = true;
            this.comboBoxTrangThaiBan.Location = new System.Drawing.Point(592, 321);
            this.comboBoxTrangThaiBan.Name = "comboBoxTrangThaiBan";
            this.comboBoxTrangThaiBan.Size = new System.Drawing.Size(175, 33);
            this.comboBoxTrangThaiBan.TabIndex = 19;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(200, 150);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên bàn";
            // 
            // labelChoNgoi
            // 
            this.labelChoNgoi.AutoSize = true;
            this.labelChoNgoi.Location = new System.Drawing.Point(481, 236);
            this.labelChoNgoi.Name = "labelChoNgoi";
            this.labelChoNgoi.Size = new System.Drawing.Size(116, 25);
            this.labelChoNgoi.TabIndex = 16;
            this.labelChoNgoi.Text = "Số chỗ ngồi";
            // 
            // numericUpDownChoNgoi
            // 
            this.numericUpDownChoNgoi.Location = new System.Drawing.Point(661, 234);
            this.numericUpDownChoNgoi.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownChoNgoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChoNgoi.Name = "numericUpDownChoNgoi";
            this.numericUpDownChoNgoi.Size = new System.Drawing.Size(106, 30);
            this.numericUpDownChoNgoi.TabIndex = 17;
            this.numericUpDownChoNgoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMota
            // 
            this.labelMota.AutoSize = true;
            this.labelMota.Location = new System.Drawing.Point(200, 236);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(79, 25);
            this.labelMota.TabIndex = 2;
            this.labelMota.Text = "Ghi chú";
            // 
            // labelVitri
            // 
            this.labelVitri.AutoSize = true;
            this.labelVitri.Location = new System.Drawing.Point(481, 150);
            this.labelVitri.Name = "labelVitri";
            this.labelVitri.Size = new System.Drawing.Size(50, 25);
            this.labelVitri.TabIndex = 14;
            this.labelVitri.Text = "Vị trí";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(285, 449);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 42);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(516, 449);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 42);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(481, 329);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(100, 25);
            this.labelstatus.TabIndex = 12;
            this.labelstatus.Text = "Trạng thái";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlTable";
            this.Size = new System.Drawing.Size(1449, 677);
            this.Load += new System.EventHandler(this.UserControlTable_Load);
            this.tabControlTable.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageAddEdit.ResumeLayout(false);
            this.tabPageAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChoNgoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTable;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPageAddEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxMota;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMota;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxVitri;
        private System.Windows.Forms.Label labelVitri;
        private System.Windows.Forms.NumericUpDown numericUpDownChoNgoi;
        private System.Windows.Forms.Label labelChoNgoi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxTrangThaiBan;
    }
}
