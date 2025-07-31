namespace PresentationLayer
{
    partial class UserControlOneTable
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
            this.panel = new System.Windows.Forms.Panel();
            this.labelSoChoNgoi = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelSoChoNgoi);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(0, 40);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(123, 33);
            this.panel.TabIndex = 0;
            // 
            // labelSoChoNgoi
            // 
            this.labelSoChoNgoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSoChoNgoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoChoNgoi.Location = new System.Drawing.Point(0, 0);
            this.labelSoChoNgoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoChoNgoi.Name = "labelSoChoNgoi";
            this.labelSoChoNgoi.Size = new System.Drawing.Size(123, 33);
            this.labelSoChoNgoi.TabIndex = 1;
            this.labelSoChoNgoi.Text = "cho ngoi";
            this.labelSoChoNgoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSoChoNgoi.Click += new System.EventHandler(this.labelSoChoNgoi_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(123, 40);
            this.panelTop.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(123, 40);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "labelName";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // UserControlOneTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlOneTable";
            this.Size = new System.Drawing.Size(123, 73);
            this.panel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelSoChoNgoi;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelName;
    }
}
