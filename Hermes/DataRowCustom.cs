using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hermes.DataModel;

namespace Hermes
{
    public partial class DataRowCustom : UserControl
    {
        private string name;
        private double plus;
        private double moins;
        private PartyEvent currentEvent;
        private Panel ecran;
        private int index;
        private Color currentColor;
        private int currentIndexPage;
        public DataRowCustom(string name, double plus, double moins, PartyEvent partyEvent, Panel ecran, int index, int currentIndexPage)
        {
            InitializeComponent();
            this.name = name;
            this.plus = plus;
            this.moins = moins;
            this.currentEvent = partyEvent;
            this.ecran = ecran;
            this.index = index;
            this.currentIndexPage = currentIndexPage;
        }

        public void ChangeColor()
        {
            this.BackColor = Color.FromArgb(238, 250, 255);
        }

        private void DataRowCustom_Load(object sender, EventArgs e)
        {
            currentColor = this.BackColor;
            lblPersonnes.Text = name;
            lblPlus.Text = plus.ToString("0.00");
            lblMoins.Text = moins.ToString("0.00");
            lblSolde.Text = (plus - moins).ToString("0.00");
        }

        private void DataRowCustom_Click(object sender, EventArgs e)
        {
            UserBilan userBilan = new UserBilan(currentEvent, index, currentIndexPage);
           userBilan.setPanel = ecran; 
           this.ecran.Controls.Clear();
           this.ecran.Controls.Add(userBilan);
        }

        private void DataRowCustom_Enter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void DataRowCustom_Leave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (this.currentColor == Color.FromArgb(238, 250, 255))
            {
                this.BackColor = Color.FromArgb(238, 250, 255);
            }
            else
            {
                this.BackColor = Color.FromArgb(249, 252, 255);
            }
        }
    }
}
