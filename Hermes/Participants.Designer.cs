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
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(113, 114);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(249, 28);
            this.cboEvenements.TabIndex = 5;
            // 
            // pnlParticipants
            // 
            this.pnlParticipants.Location = new System.Drawing.Point(0, 177);
            this.pnlParticipants.Name = "pnlParticipants";
            this.pnlParticipants.Size = new System.Drawing.Size(942, 406);
            this.pnlParticipants.TabIndex = 7;
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 10F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(110, 86);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(175, 16);
            this.appFontLabel1.TabIndex = 6;
            this.appFontLabel1.Text = "Dans quel évènements ? *";
            // 
            // Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlParticipants);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.cboEvenements);
            this.Name = "Participants";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Participants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel appFontLabel1;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.Panel pnlParticipants;
    }
}
