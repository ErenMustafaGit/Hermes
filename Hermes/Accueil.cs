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
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            List<Participant> participants = base_de_donnee.FetchParticipant();
            List<PartyEvent> evenements = base_de_donnee.FetchEvents();
            this.lblInformationParticipants.Text = String.Format("Il y a {0} participants inscrits.", evenements.Count);
            this.lblevenementEnregistres.Text = String.Format("Il y a {0} évènements enregistrés.", participants.Count);
        }
    }
}
