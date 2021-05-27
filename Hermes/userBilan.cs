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
    public partial class UserBilan : UserControl
    {
        private PartyEvent currentEvent;
        public Panel ecran;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public UserBilan(PartyEvent currentEvent)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
        }


        private void Bilan_Load(object sender, EventArgs e)
        {
            List<Participant> listeParticipants = currentEvent.GetGuests();
            DataTable dataTableParticipants = Participant.toConcatenateDataTable(listeParticipants);
            cboParticipant.DataSource = dataTableParticipants;
            cboParticipant.DisplayMember = "Name";
            cboParticipant.ValueMember = "CodeParticipant";
            lblEvent.Text = currentEvent.Name;
        }

        private void depenseUser1_Load(object sender, EventArgs e)
        {

        }

        private void CboParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
