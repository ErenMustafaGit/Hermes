namespace Hermes
{
    partial class Accueil
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
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.lblCree = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbliconeParticipants = new System.Windows.Forms.Label();
            this.lblInformationParticipants = new System.Windows.Forms.Label();
            this.lblevenementEnregistres = new System.Windows.Forms.Label();
            this.lbliconeEvenement = new System.Windows.Forms.Label();
            this.ajoutRapideBouton1 = new Hermes.AjoutRapideBouton();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblBienvenue.Location = new System.Drawing.Point(119, 125);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(349, 124);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue\r\nsur Hermès !\r\n";
            // 
            // lblCree
            // 
            this.lblCree.AutoSize = true;
            this.lblCree.BackColor = System.Drawing.Color.Transparent;
            this.lblCree.Font = new System.Drawing.Font("Arial", 13F);
            this.lblCree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblCree.Location = new System.Drawing.Point(127, 292);
            this.lblCree.Name = "lblCree";
            this.lblCree.Size = new System.Drawing.Size(336, 42);
            this.lblCree.TabIndex = 1;
            this.lblCree.Text = "Créez des évènements, invitez des gens,\r\npartagez l\'addition.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(126, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Créez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.label2.Location = new System.Drawing.Point(318, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "invitez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.label3.Location = new System.Drawing.Point(127, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "partagez";
            // 
            // lbliconeParticipants
            // 
            this.lbliconeParticipants.AutoSize = true;
            this.lbliconeParticipants.Font = new System.Drawing.Font("Webdings", 45F);
            this.lbliconeParticipants.Location = new System.Drawing.Point(122, 366);
            this.lbliconeParticipants.Name = "lbliconeParticipants";
            this.lbliconeParticipants.Size = new System.Drawing.Size(87, 61);
            this.lbliconeParticipants.TabIndex = 5;
            this.lbliconeParticipants.Text = "a";
            // 
            // lblInformationParticipants
            // 
            this.lblInformationParticipants.AutoSize = true;
            this.lblInformationParticipants.Font = new System.Drawing.Font("Arial", 10F);
            this.lblInformationParticipants.Location = new System.Drawing.Point(215, 393);
            this.lblInformationParticipants.Name = "lblInformationParticipants";
            this.lblInformationParticipants.Size = new System.Drawing.Size(178, 16);
            this.lblInformationParticipants.TabIndex = 6;
            this.lblInformationParticipants.Text = "Il y a X participants inscrits.";
            // 
            // lblevenementEnregistres
            // 
            this.lblevenementEnregistres.AutoSize = true;
            this.lblevenementEnregistres.Font = new System.Drawing.Font("Arial", 10F);
            this.lblevenementEnregistres.Location = new System.Drawing.Point(215, 462);
            this.lblevenementEnregistres.Name = "lblevenementEnregistres";
            this.lblevenementEnregistres.Size = new System.Drawing.Size(209, 16);
            this.lblevenementEnregistres.TabIndex = 8;
            this.lblevenementEnregistres.Text = "Il y a X évènements enregistrés.";
            // 
            // lbliconeEvenement
            // 
            this.lbliconeEvenement.AutoSize = true;
            this.lbliconeEvenement.Font = new System.Drawing.Font("Webdings", 45F);
            this.lbliconeEvenement.Location = new System.Drawing.Point(122, 442);
            this.lbliconeEvenement.Name = "lbliconeEvenement";
            this.lbliconeEvenement.Size = new System.Drawing.Size(87, 61);
            this.lbliconeEvenement.TabIndex = 7;
            this.lbliconeEvenement.Text = "e";
            // 
            // ajoutRapideBouton1
            // 
            this.ajoutRapideBouton1.Location = new System.Drawing.Point(582, 136);
            this.ajoutRapideBouton1.Name = "ajoutRapideBouton1";
            this.ajoutRapideBouton1.Size = new System.Drawing.Size(425, 376);
            this.ajoutRapideBouton1.TabIndex = 9;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ajoutRapideBouton1);
            this.Controls.Add(this.lblevenementEnregistres);
            this.Controls.Add(this.lbliconeEvenement);
            this.Controls.Add(this.lblInformationParticipants);
            this.Controls.Add(this.lbliconeParticipants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCree);
            this.Controls.Add(this.lblBienvenue);
            this.Name = "Accueil";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label lblCree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbliconeParticipants;
        private System.Windows.Forms.Label lblInformationParticipants;
        private System.Windows.Forms.Label lblevenementEnregistres;
        private System.Windows.Forms.Label lbliconeEvenement;
        private AjoutRapideBouton ajoutRapideBouton1;
    }
}
