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
        //Variable utilisé pour déplacer la fênetre, en effet FormBorderStle = none ne permet pas de déplacer
        // la formulaire.
        private Point movementPoint;
        private Panel sideBar;

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            sideBarUserControls1.BringToFront();
            sideBarUserControls1.setPanel = pnlEcran;
            this.sideBar = sideBarUserControls1.getSideBar;
            Accueil a1 = new Accueil();
            a1.setPanel = pnlEcran;
            this.pnlEcran.Controls.Add(a1);
           // this.sideBar.MouseEnter += new EventHandler(sideBar_enter);
           // this.sideBar.MouseLeave += new EventHandler(sideBar_leave);
        }
        

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

        private void sideBar_enter(object sender, EventArgs e)
        {
            this.sideBar.Size = new Size(424, this.sideBar.Height);
        }

        private void sideBar_leave(object sender, EventArgs e)
        {
            this.sideBar.Size = new Size(134, this.sideBar.Height);
        }

        private void SideBarUserControls1_Load(object sender, EventArgs e)
        {
          
        }

        /*
        private void sideBarUserControls1_MouseEnter(object sender, EventArgs e)
        {
            sideBarUserControls1.Size = new Size(424, this.sideBarUserControls1.Size.Height);
            MessageBox.Show("ok");
        }

        private void sideBarUserControls1_MouseLeave(object sender, EventArgs e)
        {
            sideBarUserControls1.Size = new Size(116, this.sideBarUserControls1.Size.Height);
            MessageBox.Show("ko");
        }
        */
    }
}
