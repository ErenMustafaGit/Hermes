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

        public MainForm()
        {
            InitializeComponent();
        }

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

        private void pnlEcran_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PnlEcran_Paint_1(object sender, PaintEventArgs e)
        {

        }


    }
}
