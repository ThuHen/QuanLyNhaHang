using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public static class FormHelper
    {
        /// <summary>
        /// Hiển thị một form dạng popup với overlay tối phía sau.
        /// </summary>
        public static DialogResult ShowDialogWithOverlay(Form parent, Form popup)
        {
            // Tạo overlay
            Form overlay = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5, // Độ mờ (0 = trong suốt, 1 = đen đặc)
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                ShowInTaskbar = false,
                Owner = parent
            };

            try
            {
                overlay.Show();
                return popup.ShowDialog(overlay);
            }
            finally
            {
                overlay.Close();
            }
        }
    }
}
