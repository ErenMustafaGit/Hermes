namespace Hermes
{
    partial class BulleAjoutBeneficiaire
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.pnlParticipants = new System.Windows.Forms.Panel();
            this.chkEveryOne = new System.Windows.Forms.CheckBox();
            this.cboEventCreator = new System.Windows.Forms.ComboBox();
            this.lblBeneficiaire = new Hermes.UI.AppFontLabel();
            this.pnlParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(79, 338);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(278, 30);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuer.Location = new System.Drawing.Point(363, 338);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(269, 30);
            this.btnContinuer.TabIndex = 38;
            this.btnContinuer.Text = "Ajouter";
            this.btnContinuer.UseVisualStyleBackColor = false;
            // 
            // pnlParticipants
            // 
            this.pnlParticipants.Controls.Add(this.chkEveryOne);
            this.pnlParticipants.Location = new System.Drawing.Point(79, 85);
            this.pnlParticipants.Name = "pnlParticipants";
            this.pnlParticipants.Size = new System.Drawing.Size(553, 226);
            this.pnlParticipants.TabIndex = 36;
            // 
            // chkEveryOne
            // 
            this.chkEveryOne.AutoSize = true;
            this.chkEveryOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEveryOne.Location = new System.Drawing.Point(15, 12);
            this.chkEveryOne.Name = "chkEveryOne";
            this.chkEveryOne.Size = new System.Drawing.Size(135, 22);
            this.chkEveryOne.TabIndex = 0;
            this.chkEveryOne.Text = "Tout le monde";
            this.chkEveryOne.UseVisualStyleBackColor = true;
            // 
            // cboEventCreator
            // 
            this.cboEventCreator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEventCreator.FormattingEnabled = true;
            this.cboEventCreator.Location = new System.Drawing.Point(388, 48);
            this.cboEventCreator.Name = "cboEventCreator";
            this.cboEventCreator.Size = new System.Drawing.Size(244, 28);
            this.cboEventCreator.TabIndex = 39;
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblBeneficiaire.AppFontHeight = 20F;
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(50, 42);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(324, 34);
            this.lblBeneficiaire.TabIndex = 35;
            this.lblBeneficiaire.Text = "Ajout d\'un bénéficaire à ";
            this.lblBeneficiaire.Click += new System.EventHandler(this.lblBeneficiaire_Click);
            // 
            // BulleAjoutBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboEventCreator);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.pnlParticipants);
            this.Controls.Add(this.lblBeneficiaire);
            this.Name = "BulleAjoutBeneficiaire";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjoutBeneficiaire_Load);
            this.pnlParticipants.ResumeLayout(false);
            this.pnlParticipants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.Panel pnlParticipants;
        private System.Windows.Forms.CheckBox chkEveryOne;
        private UI.AppFontLabel lblBeneficiaire;
        private System.Windows.Forms.ComboBox cboEventCreator;
    }
}
