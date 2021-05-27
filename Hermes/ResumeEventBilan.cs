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
    public partial class ResumeEventBilan : UserControl
    {
        private PartyEvent currentEvent;
        private Panel ecran;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public PartyEvent setEvent
        {
            set { this.currentEvent = value; }
        }
        public ResumeEventBilan(string titre, string description, int nbPart, DateTime beginDate, DateTime endDate, int codeCreator)
        {
            InitializeComponent();
            lblIconDescription.Text = Hermes.UI.Icons.HOME;
            lblIconNbPart.Text = Hermes.UI.Icons.USER_GROUP;
            lblIconDate.Text = Hermes.UI.Icons.CLOCK;
            lblIconCreator.Text = Hermes.UI.Icons.CROWN;


            //Limite de caractère du titre et des textes, après cette limite on met "..."
            int titreLength = 20;
            int textLength = 40;


            if (titre.Length > titreLength)
            {
                titre = titre.Substring(0, titreLength) + "...";
            }
            lblTitre.Text = titre;

            if (description.Length > textLength)
            {
                description = description.Substring(0, textLength) + "...";
            }
            lblDescription.Text = description;


            lblNbPart.Text = nbPart.ToString();
            lblDate.Text = beginDate.ToString("dd/MM/yyyy") + " - " + endDate.ToString("dd/MM/yyyy");

            Participant creator = Participant.GetParticipant(codeCreator);
            lblCreator.Text = creator.FirstName + " " + creator.LastName;
        }

        private void ResumeEventBilan_Load(object sender, EventArgs e)
        {

        }

        private void BtnMoreInfo_Click(object sender, EventArgs e)
        {
            UserBilan userBilan = new UserBilan(currentEvent);
            userBilan.setPanel = ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(userBilan);
        }
    }
}
