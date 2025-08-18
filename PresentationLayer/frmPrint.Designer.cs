namespace PresentationLayer
{
    partial class frmPrint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMinForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaxForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxMinForm);
            this.panel1.Controls.Add(this.pictureBoxMaxForm);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxMinForm
            // 
            this.pictureBoxMinForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMinForm.Image = global::PresentationLayer.Properties.Resources.icons8_minimize_window_26;
            this.pictureBoxMinForm.Location = new System.Drawing.Point(961, 4);
            this.pictureBoxMinForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMinForm.Name = "pictureBoxMinForm";
            this.pictureBoxMinForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMinForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinForm.TabIndex = 15;
            this.pictureBoxMinForm.TabStop = false;
            this.pictureBoxMinForm.Click += new System.EventHandler(this.pictureBoxMinForm_Click);
            // 
            // pictureBoxMaxForm
            // 
            this.pictureBoxMaxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMaxForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMaxForm.Image = global::PresentationLayer.Properties.Resources.icons8_maximize_window_26;
            this.pictureBoxMaxForm.Location = new System.Drawing.Point(1008, 4);
            this.pictureBoxMaxForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxMaxForm.Name = "pictureBoxMaxForm";
            this.pictureBoxMaxForm.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxMaxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaxForm.TabIndex = 14;
            this.pictureBoxMaxForm.TabStop = false;
            this.pictureBoxMaxForm.Click += new System.EventHandler(this.pictureBoxMaxForm_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxClose.Image = global::PresentationLayer.Properties.Resources.icons8_close_window_26;
            this.pictureBoxClose.Location = new System.Drawing.Point(1056, 4);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxCloseForm_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 50);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1100, 604);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 654);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBoxMinForm;
        private System.Windows.Forms.PictureBox pictureBoxMaxForm;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}