using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace TaskByte
{
    public partial class MainFrm : KryptonForm
    {
        public MainFrm()
        {
            InitializeComponent();
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
           
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void Close_MouseHover(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void Maximize_MouseHover(object sender, EventArgs e)
        {
            button2.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
        }

        private void Maximize_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Transparent;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    }
}
