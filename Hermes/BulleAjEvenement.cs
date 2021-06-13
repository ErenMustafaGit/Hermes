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
    public partial class BulleAjEvenement : UserControl
    {
        private Panel ecran;
        private Delegate annuler;
        private Panel pnlPrincipal;
        private bool wentBack;
        private PartyEvent currentEvent;
        private int index;
        
        public BulleAjEvenement()
        {
            InitializeComponent();
            this.wentBack = false;
        }

        public BulleAjEvenement(bool wentBack, PartyEvent currentEvent, int index, Panel pnlPrincipal, Panel ecran)
        {
            InitializeComponent();
            this.wentBack = wentBack;
            this.currentEvent = currentEvent;
            this.index = index;
            this.pnlPrincipal = pnlPrincipal;
            this.ecran = ecran;
        }

        public Panel setPanelPrincipal
        {
            set { pnlPrincipal = value; }
        }


        public Delegate Annuler
        {
            set { this.annuler = value; }
        }
        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        private void DtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.MinDate = dtpDateDebut.Value;
        }

        private void DtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.MinDate = dtpDateDebut.Value;
        }

        private void BulleAjEvenement_Load(object sender, EventArgs e)
        {
            FontFamily helvetica = FontManager.GetFontFamily(AppFont.HelveticaNeue);
            txtNomEvenement.Font = new Font(helvetica, txtNomEvenement.Font.Size);
            dtpDateDebut.Font = new Font(helvetica, dtpDateDebut.Font.Size);
            dtpDateFin.Font = new Font(helvetica, dtpDateFin.Font.Size);
            cboEventCreator.Font = new Font(helvetica, cboEventCreator.Font.Size);
            btnAnnuler.Font = new Font(helvetica, btnAnnuler.Font.Size);
            btnContinuer.Font = new Font(helvetica, btnContinuer.Font.Size);

            cboEventCreator.DataSource = Participant.toConcatenateDataTable(Database.FetchParticipant());
            cboEventCreator.DisplayMember = "Name";
            cboEventCreator.ValueMember = "CodeParticipant";

            dtpDateDebut.Text = DateTime.Now.ToShortTimeString();

            if (wentBack)
            {
                cboEventCreator.SelectedIndex = index;
                txtNomEvenement.Text = currentEvent.Name;
                dtpDateDebut.Value = currentEvent.StartDate;
                dtpDateFin.Value = currentEvent.EndDate;
            }
        }

        //btnAnnuler_Click
        private void Button1_Click(object sender, EventArgs e)
        {
            this.ecran.Controls.Clear();
            this.ecran.Visible = false;
            //annuler.DynamicInvoke();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if(txtNomEvenement.Text.Length == 0)
            {
                txtNomEvenement.BackColor = Color.LightPink;
                txtNomEvenement.Focus();
            }
            else
            {
                PartyEvent newEvent = new PartyEvent()
                {
                    Id = PartyEvent.GetMaxCode() + 1,
                    Name = txtNomEvenement.Text.Replace('\'', ' '),
                    StartDate = dtpDateDebut.Value,
                    EndDate = dtpDateFin.Value,
                    Description = null,
                    Completed = false,
                    AuthorId = (int)cboEventCreator.SelectedValue
                };
                BulleAjEvenement2 suite = new BulleAjEvenement2(newEvent, cboEventCreator.SelectedIndex);
                this.ecran.Controls.Clear();
                suite.setPanel = this.ecran;
                suite.setPanelPrincipal = pnlPrincipal;
                suite.Annuler = annuler;
                this.ecran.Controls.Add(suite);
            }
            
        }

        private void txtNomEvenement_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNomEvenement.BackColor = Color.White;

        }
    }
}
