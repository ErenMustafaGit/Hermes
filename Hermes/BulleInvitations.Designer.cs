namespace Hermes
{
    partial class BulleInvitations
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblInvitations = new Hermes.UI.AppFontLabel();
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.pnlParticipant = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(66, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(354, 324);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(269, 30);
            this.btnValider.TabIndex = 32;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // lblInvitations
            // 
            this.lblInvitations.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblInvitations.AppFontHeight = 24F;
            this.lblInvitations.AutoSize = true;
            this.lblInvitations.Location = new System.Drawing.Point(59, 57);
            this.lblInvitations.Name = "lblInvitations";
            this.lblInvitations.Size = new System.Drawing.Size(327, 40);
            this.lblInvitations.TabIndex = 30;
            this.lblInvitations.Text = "Inviter à l\'évènement\r\n";
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(402, 69);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(221, 28);
            this.cboEvenements.TabIndex = 28;
            this.cboEvenements.SelectionChangeCommitted += new System.EventHandler(this.CboEvenements_SelectionChangeCommitted);
            // 
            // pnlParticipant
            // 
            this.pnlParticipant.Location = new System.Drawing.Point(66, 122);
            this.pnlParticipant.Name = "pnlParticipant";
            this.pnlParticipant.Size = new System.Drawing.Size(557, 187);
            this.pnlParticipant.TabIndex = 33;
            // 
            // BulleInvitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlParticipant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblInvitations);
            this.Controls.Add(this.cboEvenements);
            this.Name = "BulleInvitations";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleInvitations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValider;
        private UI.AppFontLabel lblInvitations;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Panel pnlParticipant;
    }
}
