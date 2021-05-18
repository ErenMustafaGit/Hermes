namespace Hermes
{
    partial class AjNouvelleDepense
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
            this.lblNouvelleDepense = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblNouvelleDepense
            // 
            this.lblNouvelleDepense.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNouvelleDepense.AppFontHeight = 20F;
            this.lblNouvelleDepense.AutoSize = true;
            this.lblNouvelleDepense.IsBold = true;
            this.lblNouvelleDepense.Location = new System.Drawing.Point(180, 192);
            this.lblNouvelleDepense.Name = "lblNouvelleDepense";
            this.lblNouvelleDepense.Size = new System.Drawing.Size(228, 31);
            this.lblNouvelleDepense.TabIndex = 0;
            this.lblNouvelleDepense.Text = "Nouvelle dépense";
            // 
            // AjNouvelleDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNouvelleDepense);
            this.Name = "AjNouvelleDepense";
            this.Size = new System.Drawing.Size(1064, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblNouvelleDepense;
    }
}
