using Hermes.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes
{
    public partial class MainForm : Form
    {
        private static MainForm Singleton;

        private List<AppToast> m_Toasts = new List<AppToast>();

        //Variable utilisé pour déplacer la fênetre, en effet FormBorderStle = none ne permet pas de déplacer
        // la formulaire.
        private Point movementPoint;

        public MainForm()
        {
            Singleton = this;
            InitializeComponent();
        }

        public static MainForm GetSingleton() => Singleton;

        void sideBarUserControls1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("hover");
            this.sideBarUserControls1.Size = new Size(424, this.sideBarUserControls1.Size.Height);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            sideBarUserControls1.BringToFront();
            sideBarUserControls1.setPanel = pnlEcran;
            Accueil a1 = new Accueil();
            a1.setPanel = pnlEcran;
            this.pnlEcran.Controls.Add(a1);
        }

        public delegate void MouseMoveFenetre();
        public delegate void MouseDownFenetre();

        // L'évenement MouseMove et MouseDown sont utilisé pour 
        // permette de faire la translation de la fênetre
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movementPoint.X;
                this.Top += e.Y - movementPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            movementPoint = new Point(e.X, e.Y);
        }


        private void SideBarUserControls1_Load(object sender, EventArgs e)
        {
            this.sideBarUserControls1.MouseHover += new System.EventHandler(sideBarUserControls1_MouseHover);
        }

        private void RelocateToasts()
        {
            int i = 0;
            const int padding = 10;
            foreach (AppToast toast in m_Toasts)
            {
                int x = (this.Size.Width - toast.Size.Width) / 2;
                int y = this.Size.Height - (toast.Size.Height + padding) * ++i;
                toast.Location = new Point(x, y);
                toast.BringToFront();
            }
        }

        private void OnToastClosed(object sender, EventArgs e)
        {
            AppToast toast = (AppToast)sender;

            this.m_Toasts.Remove(toast);
            this.Controls.Remove(toast);
            this.RelocateToasts();
        }

        public static void ShowToast(AppToast toast)
        {
            toast.OnClosed += Singleton.OnToastClosed;

            Singleton.m_Toasts.Add(toast);
            Singleton.Controls.Add(toast);
            toast.OnAdded();

            Singleton.RelocateToasts();
        }

        private void AppFontLabel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment\nquittez l'application ?", "Hermès", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            */
            Application.Exit();

        }

        private void LblExit_MouseHover(object sender, EventArgs e)
        {
            //
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblMinimise_MouseHover(object sender, EventArgs e)
        {
            //
        }

        private void LblMinimise_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblMinimise_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
