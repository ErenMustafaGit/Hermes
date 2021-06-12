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
using System.IO;
using Hermes.UI;

namespace Hermes
{
    public partial class BilanGlobal : UserControl
    {
        private PartyEvent currentEvent;
        private List<PartyEvent> allEvent;
        public Panel ecran;
        public int index;


        //pour fix le double actualisation de la page
        //Bricolage, mais efficace 
        private int start = -2;
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        public BilanGlobal(PartyEvent partyEvent, int index)
        {
            this.index = index;
            this.currentEvent = partyEvent;
            InitializeComponent();
            lblGoBaaack.Text = Hermes.UI.Icons.LEFT;
        }

        private void BilanGlobal_Load(object sender, EventArgs e)
        {
            pnlBilanCasParCas.HorizontalScroll.Enabled = false;
            pnlBilanCasParCas.HorizontalScroll.Visible = false;
            pnlBilanCasParCas.HorizontalScroll.Maximum = 0;
            pnlBilanCasParCas.AutoScroll = true;

          
            allEvent = Database.FetchEvents();
            DataTable table = Database.FetchEvents().ToDataTable();
            cboEvenements.DataSource = table;
            cboEvenements.DisplayMember = "Name";
            cboEvenements.ValueMember = "Id";
            cboEvenements.SelectedIndex = index;
            Actualisation();

            exportPdf.Font = new Font(FontManager.GetFontFamily(AppFont.Icons), 24f);
            exportPdf.Text = Icons.PDF_FILE;
        }

        private void cboEvenements_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBilanGlobal.Visible = true;
            //Bricolage, mais efficace
            start++;
            if(start >= 1)
            {
                this.index = cboEvenements.SelectedIndex; this.index = cboEvenements.SelectedIndex;
                Actualisation();
            }

            if (currentEvent.Completed)
            {
                btnBilanGlobal.Visible = false;
                exportPdf.Location = new Point(794,95);
            }
            else
            {
                exportPdf.Location = new Point(799, 63);
            }
        }

        private void DataGridViewCustom1_Load(object sender, EventArgs e)
        {

        }

        public void Actualisation()
        {
            pnlBilanToutePersonnes.Controls.Clear();
            pnlBilanCasParCas.Controls.Clear();

            PartyEvent partyEventRefreshed = allEvent[cboEvenements.SelectedIndex];
            currentEvent = partyEventRefreshed;

            DataGridViewCustom dataGridViewCustom = new DataGridViewCustom(partyEventRefreshed, this.ecran, this.index);
            pnlBilanToutePersonnes.Controls.Add(dataGridViewCustom);


            List<Participant> listeParticipant = partyEventRefreshed.GetGuests();
            List<PartyEvent.Due> remboursement = partyEventRefreshed.CalculateDues();

            int modulo = 2;
            int compteur = 0;
            for (int i = 0; i < listeParticipant.Count(); i++)
            {
                List<PartyEvent.Due> dueParticipant = new List<PartyEvent.Due>();
                foreach (PartyEvent.Due due in remboursement)
                {
                    if (due.FromId == listeParticipant[i].CodeParticipant)
                    {
                        dueParticipant.Add(due);
                    }
                }
                if(dueParticipant.Count != 0)
                {
                    UserBilanCasParCas user = new UserBilanCasParCas(listeParticipant[i].FirstName + " " + listeParticipant[i].LastName, dueParticipant, partyEventRefreshed);
                    user.Top = 0 + 245 * (compteur / modulo);
                    user.Left = 0 + 400 * (compteur % modulo);
                    compteur++;
                    pnlBilanCasParCas.Controls.Add(user);
                }
               
            }
        }

        private bool ExportToPdf()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.ShowNewFolderButton = true;
            browser.Description = "Choisissez un chemin dans lequel exporter les PDFs individuels.";

            if (browser.ShowDialog() != DialogResult.OK)
                return false;

            string path = browser.SelectedPath;
            if (Directory.Exists(path))
            {
                try { Directory.CreateDirectory(path); }
                catch { return false; }
            }

            PdfExporter.ExportEventSummaries(path, this.currentEvent);

            MessageBox.Show("PDF exporté"); // TODO: use toast
            return true;
        }

        private void BtnBilanGlobal_Click(object sender, EventArgs e)
        {
            if (currentEvent.Completed)
                return;

            DialogResult dialogResult = MessageBox.Show(
                "Vous voulez vraiment solder\nl'évènement "
                + this.currentEvent.Name + " ?",
                "Hermès", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {

                currentEvent.CloseEvent();

                MessageBox.Show("Evenement bien soldé ! "); // TODO: use toast

                //Refresh
                this.ecran.Controls.Clear();
                BilanGlobal refreshed = new BilanGlobal(this.currentEvent, this.index);
                refreshed.setPanel = this.ecran;
                this.ecran.Controls.Add(refreshed);
            }
        }

        private void exportPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }

        private void lblGoBaaack_Click(object sender, EventArgs e)
        {
            Bilan bilan = new Bilan();
            bilan.setPanel = this.ecran;
            this.ecran.Controls.Clear();
            this.ecran.Controls.Add(bilan);
        }

        private void lblGoBaaack_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblGoBaaack_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void exportPdf_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnBilanGlobal_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnBilanGlobal_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void exportPdf_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
