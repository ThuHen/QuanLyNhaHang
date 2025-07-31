namespace PresentationLayer
{
    partial class frmSelectTable
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxCloseForm = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelChuThich = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.pictureBoxCloseForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(829, 97);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(73, 32);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(156, 36);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Chọn Bàn";
            // 
            // pictureBoxCloseForm
            // 
            this.pictureBoxCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCloseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCloseForm.Image = global::PresentationLayer.Properties.Resources.icons8_close_64;
            this.pictureBoxCloseForm.Location = new System.Drawing.Point(753, 20);
            this.pictureBoxCloseForm.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pictureBoxCloseForm.Name = "pictureBoxCloseForm";
            this.pictureBoxCloseForm.Size = new System.Drawing.Size(54, 57);
            this.pictureBoxCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCloseForm.TabIndex = 2;
            this.pictureBoxCloseForm.TabStop = false;
            this.pictureBoxCloseForm.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(0, 220);
            this.flowLayoutPanelTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(829, 384);
            this.flowLayoutPanelTable.TabIndex = 1;
            // 
            // flowLayoutPanelChuThich
            // 
            this.flowLayoutPanelChuThich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelChuThich.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelChuThich.Location = new System.Drawing.Point(0, 97);
            this.flowLayoutPanelChuThich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelChuThich.Name = "flowLayoutPanelChuThich";
            this.flowLayoutPanelChuThich.Size = new System.Drawing.Size(829, 78);
            this.flowLayoutPanelChuThich.TabIndex = 2;
            // 
            // frmSelectTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 604);
            this.Controls.Add(this.flowLayoutPanelChuThich);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSelectTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectTable";
            this.Load += new System.EventHandler(this.frmSelectTable_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private System.Windows.Forms.PictureBox pictureBoxCloseForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChuThich;
    }
}