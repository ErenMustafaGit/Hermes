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
    public partial class Accueil : UserControl
    {
        Database base_de_donnee = new Database();

        Panel ecran;
        public Accueil()
        {
            InitializeComponent();
            lbliconeEvenement.Text = Hermes.UI.Icons.CALENDAR_2;
            lbliconeParticipants.Text = Hermes.UI.Icons.GROUP;
        }

        public Panel setPanel
        {
            set{ this.ecran = value; }
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            ajoutRapideBouton1.setPanel = this.ecran;
            List<Participant> participants = base_de_donnee.FetchParticipant();
            List<PartyEvent> evenements = base_de_donnee.FetchEvents();
            this.lblInformationParticipants.Text = String.Format("Il y a {0} participants inscrits.", participants.Count);
            this.lblevenementEnregistres.Text = String.Format("Il y a {0} évènements enregistrés.", evenements.Count);

        }

        private void AppFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
