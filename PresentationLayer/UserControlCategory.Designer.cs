namespace PresentationLayer
{
    partial class UserControlCategory
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
            this.tabPageAddEdit = new System.Windows.Forms.TabPage();
            this.labelstatus = new System.Windows.Forms.Label();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxMota = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMota = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControlCategory = new System.Windows.Forms.TabControl();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabPageAddEdit.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAddEdit
            // 
            this.tabPageAddEdit.Controls.Add(this.buttonCancel);
            this.tabPageAddEdit.Controls.Add(this.labelstatus);
            this.tabPageAddEdit.Controls.Add(this.checkBoxOn);
            this.tabPageAddEdit.Controls.Add(this.label1);
            this.tabPageAddEdit.Controls.Add(this.buttonSave);
            this.tabPageAddEdit.Controls.Add(this.textBoxMota);
            this.tabPageAddEdit.Controls.Add(this.textBoxName);
            this.tabPageAddEdit.Controls.Add(this.labelMota);
            this.tabPageAddEdit.Controls.Add(this.labelName);
            this.tabPageAddEdit.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddEdit.Name = "tabPageAddEdit";
            this.tabPageAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEdit.Size = new System.Drawing.Size(1233, 665);
            this.tabPageAddEdit.TabIndex = 1;
            this.tabPageAddEdit.Text = "Tạo mới ";
            this.tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(302, 296);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(100, 25);
            this.labelstatus.TabIndex = 12;
            this.labelstatus.Text = "Trạng thái";
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.Checked = true;
            this.checkBoxOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOn.Location = new System.Drawing.Point(307, 336);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(124, 29);
            this.checkBoxOn.TabIndex = 11;
            this.checkBoxOn.Text = "Hoạt động";
            this.checkBoxOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(301, 412);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 49);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMota
            // 
            this.textBoxMota.Location = new System.Drawing.Point(301, 183);
            this.textBoxMota.Multiline = true;
            this.textBoxMota.Name = "textBoxMota";
            this.textBoxMota.Size = new System.Drawing.Size(405, 92);
            this.textBoxMota.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(301, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(405, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // labelMota
            // 
            this.labelMota.AutoSize = true;
            this.labelMota.Location = new System.Drawing.Point(296, 155);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(61, 25);
            this.labelMota.TabIndex = 2;
            this.labelMota.Text = "Mô tả";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(296, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(138, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên danh mục";
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
            this.tabPageList.Size = new System.Drawing.Size(1233, 665);
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
            this.panelData.Location = new System.Drawing.Point(3, 171);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1227, 491);
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
            this.dataGridView.Size = new System.Drawing.Size(1227, 491);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // tabControlCategory
            // 
            this.tabControlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCategory.Controls.Add(this.tabPageList);
            this.tabControlCategory.Controls.Add(this.tabPageAddEdit);
            this.tabControlCategory.Location = new System.Drawing.Point(20, 28);
            this.tabControlCategory.Name = "tabControlCategory";
            this.tabControlCategory.SelectedIndex = 0;
            this.tabControlCategory.Size = new System.Drawing.Size(1241, 703);
            this.tabControlCategory.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(469, 412);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 49);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(1280, 750);
            this.Load += new System.EventHandler(this.UserControlCategory_Load);
            this.tabPageAddEdit.ResumeLayout(false);
            this.tabPageAddEdit.PerformLayout();
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageAddEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxMota;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMota;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControlCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.Button buttonCancel;
    }
}
