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
    public partial class Bilan : UserControl
    {
        public Panel ecran;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }
        public Bilan()
        {
            InitializeComponent();
        }

        private void Bilan_Load(object sender, EventArgs e)
        {
            List<Participant> listeParticipants = Database.FetchParticipant();
            DataTable dataTableParticipants = Participant.toConcatenateDataTable(listeParticipants);
            cboParticipant.DataSource = dataTableParticipants;
            cboParticipant.DisplayMember = "Name";
            cboParticipant.ValueMember = "CodeParticipant";

            DataTable dataTableEvent = Database.FetchEvents().ToDataTable();
            cboEvent.DataSource = dataTableEvent;
            cboEvent.DisplayMember = "Name";
            cboEvent.ValueMember = "Id";
        }

        private void depenseUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
