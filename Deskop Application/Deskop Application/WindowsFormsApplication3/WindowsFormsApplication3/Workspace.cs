using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ShootingRange
{

    public partial class Workspace : Form
    {
        Panel pnl;
        Size tmpMaxSizeForm;
        public Workspace()
        {
            InitializeComponent();
            HideSubMenu();
            btnExpand.Text = "\uD83D\uDDD6";
            btnMinimize.Text = "\uD83D\uDDD5";
            btnClose.Text = "\u2715";
            pnl = pnlDBSubmenu;
            tmpMaxSizeForm = this.Size;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void HideSubMenu()
        {
            pnlModesSubmenu.Size= new Size(pnlModesSubmenu.Width, pnlModesSubmenu.MinimumSize.Height);
            pnlDBSubmenu.Size = new Size(pnlDBSubmenu.Width, pnlDBSubmenu.MinimumSize.Height);
            pnlToolsSubmenu.Size = new Size(pnlToolsSubmenu.Width, pnlToolsSubmenu.MinimumSize.Height);
            pnlHelpSubmenu.Size = new Size(pnlHelpSubmenu.Width, pnlHelpSubmenu.MinimumSize.Height);
        }
        private void Login_Click(object sender, EventArgs e)
        {
            ModesView open_edycja = new ModesView();
            open_edycja.Show();
        }
        private void menu_Load(object sender, EventArgs e)
        {

        }
        #region ButtonsSubmenu
        private void btnModesSubMenu_Click(object sender, EventArgs e)
        {
            pnl = pnlModesSubmenu;
            if (pnlModesSubmenu.Size.Height == pnlModesSubmenu.MaximumSize.Height)
                isCollapsed = false;
            else isCollapsed = true;
            timer1.Start();
        }
        private void btnDBSubMenu_Click(object sender, EventArgs e)
        {
            pnl = pnlDBSubmenu;
            if (pnlDBSubmenu.Size.Height == pnlDBSubmenu.MaximumSize.Height)
                isCollapsed = false;
            else isCollapsed = true;
            timer1.Start();
        }
        private void btnToolsSubMenu_Click(object sender, EventArgs e)
        {
            pnl = pnlToolsSubmenu;
            if (pnlToolsSubmenu.Size.Height == pnlToolsSubmenu.MaximumSize.Height)
                isCollapsed = false;
            else isCollapsed = true;
            timer1.Start();
        }
        private void btnHelpSubMenu_Click(object sender, EventArgs e)
        {
            pnl = pnlHelpSubmenu;
            if (pnlHelpSubmenu.Size.Height == pnlHelpSubmenu.MaximumSize.Height)
                isCollapsed = false;
            else isCollapsed = true;
            timer1.Start();
        }
#endregion
        #region ButtonsMenu
        private void btnMenuSlowFiring_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuRapidFire_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuCowboy_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuReflex_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuModifyGun_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuModifyUser_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnImportDB_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuModifyTabels_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuConfigure_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuChangePass_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuRaport_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuTutorial_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnMenuContact_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized && tmpMaxSizeForm == this.Size)
            {
                this.WindowState = FormWindowState.Normal;
                btnExpand.Text = "\uD83D\uDDD6";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnExpand.Text = "\uD83D\uDDD7";
                tmpMaxSizeForm = this.Size;
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnExpand.Text = "\uD83D\uDDD6";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnExpand.Text = "\uD83D\uDDD7";
            }
        }
        private int tolerance = 16;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlMain.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private bool isCollapsed;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ExpandMenu(pnl, isCollapsed);
        }

        private void ExpandMenu(Panel pnl, bool isCollapsed)
        {
            if (isCollapsed)
            {
                pnl.Height += 10;
                if (pnl.Size.Height == pnl.MaximumSize.Height)
                {
                    timer1.Stop();
                }
            }
            else
            {
                pnl.Height -= 10;
                if (pnl.Size.Height == pnl.MinimumSize.Height)
                {
                    timer1.Stop();
                }
            }
        }

        private void Workspace_Resize(object sender, EventArgs e)
        {
            if(this.Size.Width< tmpMaxSizeForm.Width || this.Size.Height < tmpMaxSizeForm.Height)
            {           
                btnExpand.Text = "\uD83D\uDDD6";
            }
        }
    }
}
