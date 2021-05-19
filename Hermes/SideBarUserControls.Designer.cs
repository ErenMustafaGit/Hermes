namespace Hermes
{
    partial class SideBarUserControls
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBar = new System.Windows.Forms.Panel();
            this.lblIconeBilan = new Hermes.UI.AppFontLabel();
            this.lblIconeDepense = new Hermes.UI.AppFontLabel();
            this.lblIconeParticipant = new Hermes.UI.AppFontLabel();
            this.lblIconeEvenement = new Hermes.UI.AppFontLabel();
            this.lblIconeAccueil = new Hermes.UI.AppFontLabel();
            this.lblBilan = new Hermes.UI.AppFontLabel();
            this.lblDepenses = new Hermes.UI.AppFontLabel();
            this.lblParticipants = new Hermes.UI.AppFontLabel();
            this.lblEvenements = new Hermes.UI.AppFontLabel();
            this.lblAccueil = new Hermes.UI.AppFontLabel();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.sideBar.Controls.Add(this.lblIconeBilan);
            this.sideBar.Controls.Add(this.lblIconeDepense);
            this.sideBar.Controls.Add(this.lblIconeParticipant);
            this.sideBar.Controls.Add(this.lblIconeEvenement);
            this.sideBar.Controls.Add(this.lblIconeAccueil);
            this.sideBar.Controls.Add(this.lblBilan);
            this.sideBar.Controls.Add(this.lblDepenses);
            this.sideBar.Controls.Add(this.lblParticipants);
            this.sideBar.Controls.Add(this.lblEvenements);
            this.sideBar.Controls.Add(this.lblAccueil);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sideBar.Size = new System.Drawing.Size(421, 640);
            this.sideBar.TabIndex = 0;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar_Paint);
            // 
            // lblIconeBilan
            // 
            this.lblIconeBilan.AppFont = Hermes.AppFont.Icons;
            this.lblIconeBilan.AppFontHeight = 20F;
            this.lblIconeBilan.AutoSize = true;
            this.lblIconeBilan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeBilan.Location = new System.Drawing.Point(39, 514);
            this.lblIconeBilan.Name = "lblIconeBilan";
            this.lblIconeBilan.Size = new System.Drawing.Size(29, 27);
            this.lblIconeBilan.TabIndex = 17;
            this.lblIconeBilan.Text = "O";
            // 
            // lblIconeDepense
            // 
            this.lblIconeDepense.AppFont = Hermes.AppFont.Icons;
            this.lblIconeDepense.AppFontHeight = 20F;
            this.lblIconeDepense.AutoSize = true;
            this.lblIconeDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeDepense.Location = new System.Drawing.Point(39, 411);
            this.lblIconeDepense.Name = "lblIconeDepense";
            this.lblIconeDepense.Size = new System.Drawing.Size(29, 27);
            this.lblIconeDepense.TabIndex = 15;
            this.lblIconeDepense.Text = "O";
            // 
            // lblIconeParticipant
            // 
            this.lblIconeParticipant.AppFont = Hermes.AppFont.Icons;
            this.lblIconeParticipant.AppFontHeight = 20F;
            this.lblIconeParticipant.AutoSize = true;
            this.lblIconeParticipant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeParticipant.Location = new System.Drawing.Point(39, 312);
            this.lblIconeParticipant.Name = "lblIconeParticipant";
            this.lblIconeParticipant.Size = new System.Drawing.Size(29, 27);
            this.lblIconeParticipant.TabIndex = 13;
            this.lblIconeParticipant.Text = "O";
            // 
            // lblIconeEvenement
            // 
            this.lblIconeEvenement.AppFont = Hermes.AppFont.Icons;
            this.lblIconeEvenement.AppFontHeight = 20F;
            this.lblIconeEvenement.AutoSize = true;
            this.lblIconeEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeEvenement.Location = new System.Drawing.Point(39, 210);
            this.lblIconeEvenement.Name = "lblIconeEvenement";
            this.lblIconeEvenement.Size = new System.Drawing.Size(29, 27);
            this.lblIconeEvenement.TabIndex = 12;
            this.lblIconeEvenement.Text = "O";
            this.lblIconeEvenement.Click += new System.EventHandler(this.LblIconeEvenement_Click);
            // 
            // lblIconeAccueil
            // 
            this.lblIconeAccueil.AppFont = Hermes.AppFont.Icons;
            this.lblIconeAccueil.AppFontHeight = 20F;
            this.lblIconeAccueil.AutoSize = true;
            this.lblIconeAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblIconeAccueil.Location = new System.Drawing.Point(39, 113);
            this.lblIconeAccueil.Name = "lblIconeAccueil";
            this.lblIconeAccueil.Size = new System.Drawing.Size(29, 27);
            this.lblIconeAccueil.TabIndex = 11;
            this.lblIconeAccueil.Text = "O";
            this.lblIconeAccueil.Click += new System.EventHandler(this.LblIconeAccueil_Click);
            // 
            // lblBilan
            // 
            this.lblBilan.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblBilan.AppFontHeight = 12F;
            this.lblBilan.AutoSize = true;
            this.lblBilan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblBilan.Location = new System.Drawing.Point(113, 522);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(46, 19);
            this.lblBilan.TabIndex = 10;
            this.lblBilan.Text = "Bilan";
            this.lblBilan.Click += new System.EventHandler(this.LblBilan_Click);
            // 
            // lblDepenses
            // 
            this.lblDepenses.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDepenses.AppFontHeight = 12F;
            this.lblDepenses.AutoSize = true;
            this.lblDepenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDepenses.Location = new System.Drawing.Point(113, 418);
            this.lblDepenses.Name = "lblDepenses";
            this.lblDepenses.Size = new System.Drawing.Size(81, 19);
            this.lblDepenses.TabIndex = 9;
            this.lblDepenses.Text = "Dépenses";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblParticipants.AppFontHeight = 12F;
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblParticipants.Location = new System.Drawing.Point(113, 319);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(95, 19);
            this.lblParticipants.TabIndex = 8;
            this.lblParticipants.Text = "Participants";
            // 
            // lblEvenements
            // 
            this.lblEvenements.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEvenements.AppFontHeight = 12F;
            this.lblEvenements.AutoSize = true;
            this.lblEvenements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblEvenements.Location = new System.Drawing.Point(113, 217);
            this.lblEvenements.Name = "lblEvenements";
            this.lblEvenements.Size = new System.Drawing.Size(99, 19);
            this.lblEvenements.TabIndex = 7;
            this.lblEvenements.Text = "Évènements";
            // 
            // lblAccueil
            // 
            this.lblAccueil.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblAccueil.AppFontHeight = 12F;
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblAccueil.Location = new System.Drawing.Point(113, 120);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(63, 19);
            this.lblAccueil.TabIndex = 6;
            this.lblAccueil.Text = "Accueil";
            this.lblAccueil.Click += new System.EventHandler(this.LblAccueil_Click);
            // 
            // SideBarUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sideBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SideBarUserControls";
            this.Size = new System.Drawing.Size(424, 640);
            this.Load += new System.EventHandler(this.SideBarUserControls_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private UI.AppFontLabel lblAccueil;
        private UI.AppFontLabel lblEvenements;
        private UI.AppFontLabel lblBilan;
        private UI.AppFontLabel lblDepenses;
        private UI.AppFontLabel lblParticipants;
        private UI.AppFontLabel lblIconeAccueil;
        private UI.AppFontLabel lblIconeEvenement;
        private UI.AppFontLabel lblIconeParticipant;
        private UI.AppFontLabel lblIconeDepense;
        private UI.AppFontLabel lblIconeBilan;
    }
}
