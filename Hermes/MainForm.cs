using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

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


    }
}
