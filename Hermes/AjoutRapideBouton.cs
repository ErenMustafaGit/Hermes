﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hermes
{
    public partial class AjoutRapideBouton : UserControl
    {
        Panel ecran;

        public AjoutRapideBouton()
        {
            InitializeComponent();
        }

        public Panel setPanel
        {
            set { this.ecran = value; }
        }

        //public string setEvenement

        private void AjoutRapideBouton_Load(object sender, EventArgs e)
        {
            
            DataTable events = PartyEvent.toDataTable(Database.FetchEvents());
            cboEvenements.DataSource = events;
            cboEvenements.DisplayMember = "TitleEvent";
            cboEvenements.ValueMember = "CodeEvent";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if(cboEvenements.SelectedIndex != -1)
            {
                this.ecran.Controls.Clear();
                AjNouvelleDepense aj = new AjNouvelleDepense(int.Parse(cboEvenements.SelectedValue.ToString()));
                aj.setPanel = this.ecran;
                this.ecran.Controls.Add(aj);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un évènement !");
            }
            
           
        }

        private void appFontLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
