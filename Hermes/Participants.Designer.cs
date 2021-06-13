namespace Hermes
{
    partial class Participants
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
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.pnlParticipants = new System.Windows.Forms.Panel();
            this.btnInviter = new System.Windows.Forms.Button();
            this.lblEvenement = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(76, 113);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(281, 28);
            this.cboEvenements.TabIndex = 5;
            this.cboEvenements.SelectedIndexChanged += new System.EventHandler(this.CboEvenements_SelectedIndexChanged_1);
            // 
            // pnlParticipants
            // 
            this.pnlParticipants.Location = new System.Drawing.Point(76, 156);
            this.pnlParticipants.Name = "pnlParticipants";
            this.pnlParticipants.Size = new System.Drawing.Size(806, 462);
            this.pnlParticipants.TabIndex = 7;
            // 
            // btnInviter
            // 
            this.btnInviter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnInviter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInviter.Location = new System.Drawing.Point(661, 113);
            this.btnInviter.Name = "btnInviter";
            this.btnInviter.Size = new System.Drawing.Size(194, 37);
            this.btnInviter.TabIndex = 8;
            this.btnInviter.Text = "Inviter à un évènement";
            this.btnInviter.UseVisualStyleBackColor = false;
            this.btnInviter.Click += new System.EventHandler(this.btnInviter_Click);
            // 
            // lblEvenement
            // 
            this.lblEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEvenement.AppFontHeight = 12F;
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Location = new System.Drawing.Point(72, 81);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(219, 19);
            this.lblEvenement.TabIndex = 6;
            this.lblEvenement.Text = "Chercher dans l\'évènement :";
            // 
            // Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInviter);
            this.Controls.Add(this.pnlParticipants);
            this.Controls.Add(this.lblEvenement);
            this.Controls.Add(this.cboEvenements);
            this.Name = "Participants";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Participants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblEvenement;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Panel pnlParticipants;
        private System.Windows.Forms.Button btnInviter;
    }
}
