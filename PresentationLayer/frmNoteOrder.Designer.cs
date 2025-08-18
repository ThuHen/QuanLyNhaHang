namespace PresentationLayer.Resources
{
    partial class frmNoteOrder
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
            this.labelNote = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelTop2 = new System.Windows.Forms.Panel();
            this.textBoxNoteOrder = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Controls.Add(this.labelNote);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(650, 50);
            this.panelTop.TabIndex = 3;
            // 
            // labelNote
            // 
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(230, 9);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(180, 36);
            this.labelNote.TabIndex = 1;
            this.labelNote.Text = "GHI CHÚ";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 370);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(650, 80);
            this.panelBottom.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(255, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 49);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(40, 320);
            this.panelLeft.TabIndex = 5;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(610, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(40, 320);
            this.panelRight.TabIndex = 6;
            // 
            // panelTop2
            // 
            this.panelTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2.Location = new System.Drawing.Point(40, 50);
            this.panelTop2.Name = "panelTop2";
            this.panelTop2.Size = new System.Drawing.Size(570, 40);
            this.panelTop2.TabIndex = 7;
            // 
            // textBoxNoteOrder
            // 
            this.textBoxNoteOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNoteOrder.Location = new System.Drawing.Point(40, 90);
            this.textBoxNoteOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNoteOrder.Multiline = true;
            this.textBoxNoteOrder.Name = "textBoxNoteOrder";
            this.textBoxNoteOrder.Size = new System.Drawing.Size(570, 280);
            this.textBoxNoteOrder.TabIndex = 8;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxClose.Image = global::PresentationLayer.Properties.Resources.icons8_close_window_26;
            this.pictureBoxClose.Location = new System.Drawing.Point(599, 6);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 15;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // frmNoteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.textBoxNoteOrder);
            this.Controls.Add(this.panelTop2);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNoteOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNoteOrder";
            this.Load += new System.EventHandler(this.frmNoteOrder_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTop2;
        private System.Windows.Forms.TextBox textBoxNoteOrder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}