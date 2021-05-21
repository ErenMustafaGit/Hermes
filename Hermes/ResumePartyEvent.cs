using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes
{
    public partial class ResumePartyEvent : UserControl
    {
        public int codeEvent;
        public int index;
        public Panel ecran;
        public ResumePartyEvent()
        {
            InitializeComponent();
            InitializeIcon();
        }

        public int setIndex
        {
            set { this.index = value; }
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public ResumePartyEvent(string titre, string description, int nbPart, DateTime beginDate, DateTime endDate, int codeCreator)
        {
            InitializeComponent();
            InitializeIcon();


            //Limite de caractère du titre et des textes, après cette limite on met "..."
            int titreLength = 20;
            int textLength = 40;


            if(titre.Length > titreLength)
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
            lblDate.Text = beginDate.ToString("dd/MM/yyyy")+ " - " + endDate.ToString("dd/MM/yyyy") ;

            Participant creator = Participant.GetParticipant(codeCreator);
            lblCreator.Text = creator.FirstName + " " + creator.LastName;
        }

        public void InitializeIcon()
        {
            lblIconDescription.Text = Hermes.UI.Icons.HOME;
            lblIconNbPart.Text = Hermes.UI.Icons.USER_GROUP;
            lblIconDate.Text = Hermes.UI.Icons.CLOCK;
            lblIconCreator.Text = Hermes.UI.Icons.CROWN;
        }
        private void ResumePartyEvent_Load(object sender, EventArgs e)
        {

        }

        private void BtnMoreInfo_Click(object sender, EventArgs e)
        {
            CompleteInfoEvenement CIE = new CompleteInfoEvenement();
            CIE.setIndex = index;
            CIE.setPanel = ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(CIE);

        }
    }
}
