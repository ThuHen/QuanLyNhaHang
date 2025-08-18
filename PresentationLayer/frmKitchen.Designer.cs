namespace PresentationLayer
{
    partial class frmKitchen
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
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCheBien = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMinForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaxForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTop.Controls.Add(this.pictureBoxMinForm);
            this.panelTop.Controls.Add(this.pictureBoxMaxForm);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Controls.Add(this.labelNote);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1412, 50);
            this.panelTop.TabIndex = 5;
            // 
            // labelNote
            // 
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNote.Location = new System.Drawing.Point(166, 0);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(123, 58);
            this.labelNote.TabIndex = 3;
            this.labelNote.Text = "Bếp";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNote.Click += new System.EventHandler(this.labelNote_Click);
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(35, 160);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(1349, 609);
            this.flowLayoutPanelOrders.TabIndex = 7;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(641, 108);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(46, 33);
            this.buttonCount.TabIndex = 9;
            this.buttonCount.Text = "button1";
            this.buttonCount.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_reload_50;
            this.pictureBox1.Location = new System.Drawing.Point(693, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCheBien);
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Location = new System.Drawing.Point(55, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonCheBien
            // 
            this.radioButtonCheBien.AutoSize = true;
            this.radioButtonCheBien.Location = new System.Drawing.Point(143, 20);
            this.radioButtonCheBien.Name = "radioButtonCheBien";
            this.radioButtonCheBien.Size = new System.Drawing.Size(159, 29);
            this.radioButtonCheBien.TabIndex = 1;
            this.radioButtonCheBien.Text = "Đang chế biến";
            this.radioButtonCheBien.UseVisualStyleBackColor = true;
            this.radioButtonCheBien.CheckedChanged += new System.EventHandler(this.radioButtonCheBien_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(18, 20);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(88, 29);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Tất cả";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1077, 108);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(48, 25);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "time";
            // 
            // pictureBoxMinForm
            // 
            this.pictureBoxMinForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMinForm.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_26;
            this.pictureBoxMinForm.Location = new System.Drawing.Point(1268, 9);
            this.pictureBoxMinForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMinForm.Name = "pictureBoxMinForm";
            this.pictureBoxMinForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMinForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinForm.TabIndex = 15;
            this.pictureBoxMinForm.TabStop = false;
            this.pictureBoxMinForm.Click += new System.EventHandler(this.pictureBoxMin_Click);
            // 
            // pictureBoxMaxForm
            // 
            this.pictureBoxMaxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaxForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxMaxForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMaxForm.Image = global::PresentationLayer.Properties.Resources.icons8_maximize_window_26;
            this.pictureBoxMaxForm.Location = new System.Drawing.Point(1315, 9);
            this.pictureBoxMaxForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMaxForm.Name = "pictureBoxMaxForm";
            this.pictureBoxMaxForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMaxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaxForm.TabIndex = 14;
            this.pictureBoxMaxForm.TabStop = false;
            this.pictureBoxMaxForm.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxClose.Image = global::PresentationLayer.Properties.Resources.icons8_close_window_26;
            this.pictureBoxClose.Location = new System.Drawing.Point(1363, 9);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            // 
            // frmKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 769);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanelOrders);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKitchen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKitchen_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCheBien;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxMinForm;
        private System.Windows.Forms.PictureBox pictureBoxMaxForm;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}