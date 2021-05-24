namespace Hermes
{
    partial class BulleAjDepense2
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
            this.pnlParticipants = new System.Windows.Forms.Panel();
            this.chkEveryOne = new System.Windows.Forms.CheckBox();
            this.lblBeneficiaire = new Hermes.UI.AppFontLabel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.pnlParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParticipants
            // 
            this.pnlParticipants.Controls.Add(this.chkEveryOne);
            this.pnlParticipants.Location = new System.Drawing.Point(77, 83);
            this.pnlParticipants.Name = "pnlParticipants";
            this.pnlParticipants.Size = new System.Drawing.Size(553, 226);
            this.pnlParticipants.TabIndex = 3;
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
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblBeneficiaire.AppFontHeight = 20F;
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(48, 34);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(157, 34);
            this.lblBeneficiaire.TabIndex = 2;
            this.lblBeneficiaire.Text = "Bénéficaire";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(77, 336);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(278, 30);
            this.btnAnnuler.TabIndex = 33;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuer.Location = new System.Drawing.Point(361, 336);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(269, 30);
            this.btnContinuer.TabIndex = 34;
            this.btnContinuer.Text = "Ajouter";
            this.btnContinuer.UseVisualStyleBackColor = false;
            // 
            // BulleAjDepense2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.pnlParticipants);
            this.Controls.Add(this.lblBeneficiaire);
            this.Name = "BulleAjDepense2";
            this.Size = new System.Drawing.Size(705, 405);
            this.pnlParticipants.ResumeLayout(false);
            this.pnlParticipants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlParticipants;
        private System.Windows.Forms.CheckBox chkEveryOne;
        private UI.AppFontLabel lblBeneficiaire;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnContinuer;
    }
}
