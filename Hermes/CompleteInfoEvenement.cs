using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hermes
{
    public partial class CompleteInfoEvenement : UserControl
    {
        public int index;
        public Panel ecran;
        public CompleteInfoEvenement()
        {
            InitializeComponent();
            lblIconeDate.Text = Hermes.UI.Icons.CALENDAR_1;
        }

        public int setIndex
        {
            set { this.index = value; }
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void CompleteInfoEvenement_Load(object sender, EventArgs e)
        {
            pnlParticipant.AutoScroll = false;
            pnlParticipant.HorizontalScroll.Enabled = false;
            pnlParticipant.HorizontalScroll.Visible = false;
            pnlParticipant.HorizontalScroll.Maximum = 0;
            pnlParticipant.AutoScroll = true;
            /*
            string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../bdEvents.mdb'";
            OleDbConnection connection = new OleDbConnection(chcon);
            connection.Open();
            try
            {
                DataSet setBase = new DataSet();
                DataTable tout = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                new object[] { null, null, null, "TABLE" });

                for (int i = 0; i < tout.Rows.Count; i++)
                {
                    string sql = "SELECT * FROM " + tout.Rows[i][2].ToString();
                    //MessageBox.Show(sql);
                    OleDbCommand cd = new OleDbCommand(sql, connection);
                    OleDbDataAdapter ca = new OleDbDataAdapter(cd);
                    ca.Fill(setBase, tout.Rows[i][2].ToString());
                }
                BindingSource testB = new BindingSource();
                DataTable tB = setBase.Tables["Evenements"];
                testB.DataSource = tB;
                DataRowView dr = (DataRowView)testB.Current;
                MessageBox.Show(dr.Row[1].ToString());
                testB.MoveLast();
                dr = (DataRowView)testB.Current;
                MessageBox.Show(dr.Row[1].ToString());
                MessageBox.Show(testB.Position.ToString());
                testB.Position = this.index;
                dr = (DataRowView)testB.Current;
                MessageBox.Show(dr.Row[1].ToString());

            }
            finally
            {
                connection.Close();
            }
            */

            Database base_de_donnee = new Database();

            List<PartyEvent> evenement = base_de_donnee.FetchEvents();
            PartyEvent evenement_concerné = evenement[index];

            lblNomEvenement.Text = evenement_concerné.TitleEvent;
            lblDescEvenement.Text = evenement_concerné.Description;
            lblDateStart.Text = evenement_concerné.BeginDate.ToLongDateString();
            lblDateEnd.Text = evenement_concerné.EndDate.ToLongDateString();
            bool solde_y_n = evenement_concerné.BalanceYN;
            if (solde_y_n)
                lblTrueFalse.Text = Hermes.UI.Icons.EMOTE_THUMBS_UP;
            else
                lblTrueFalse.Text = Hermes.UI.Icons.GEAR;

            List<Participant> participant = evenement_concerné.GetGuests();

            for (int i = 0; i < participant.Count; i++)
            {
                UserEvenement user = new UserEvenement();
                user.recupParticipant = participant[i];
                user.Top = 20 + 80 * i;
                pnlParticipant.Controls.Add(user);

            }

        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LblSoldé_Click(object sender, EventArgs e)
        {

        }

        private void LblTrueFalse_Click(object sender, EventArgs e)
        {

        }

        private void LblDateEnd_Click(object sender, EventArgs e)
        {

        }

        private void LblDateEvenementAu_Click(object sender, EventArgs e)
        {

        }

        private void LblDateStart_Click(object sender, EventArgs e)
        {

        }

        private void LblIconeDate_Click(object sender, EventArgs e)
        {

        }
    }
}
