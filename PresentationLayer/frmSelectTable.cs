using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class frmSelectTable : Form

    {
        private TableBL tableBL;
        public frmSelectTable()
        {
            InitializeComponent();
            tableBL = new TableBL();
        }

        private void frmSelectTable_Load(object sender, EventArgs e)
        {
            LoadTable();

        }
        private void LoadTable()
        {
            List<Table> tables = tableBL.GetAllTables();
            foreach (Table table in tables)
            {
                
                Button button = new Button();
                button.Text = table.TenBan;

                button.Height = 60;
                button.Width = 100;
                button.Margin = new Padding(10);



                button.Click += new EventHandler(buttonTable_Click);

                // Thiết lập màu sắc theo trạng thái bàn
                switch (table.MaTrangThai)
                {
                    case 0:
                        button.BackColor = Color.FromArgb(225, 225, 225); // Available - white
                        break;
                    case 1:
                        button.BackColor = Color.FromArgb(255, 128, 0); // Reserved - cam
                        break;
                    case 2:
                        button.BackColor = Color.FromArgb(255, 0, 0); // Occupied - red
                        break;
                    default:
                        button.BackColor = Color.FromArgb(225, 225, 225); // Default color
                        break;
                }
                
                flowLayoutPanelTable.Controls.Add(button);
            }
        }
        private void buttonTable_Click(object sender, EventArgs e)
        {
            //TableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            //this.Close();
        }

        private void panelChuThich_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
