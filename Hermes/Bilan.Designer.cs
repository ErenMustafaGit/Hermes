namespace Hermes
{
    partial class Bilan
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
            this.pnlEvenement = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlEvenement
            // 
            this.pnlEvenement.Location = new System.Drawing.Point(39, 76);
            this.pnlEvenement.Name = "pnlEvenement";
            this.pnlEvenement.Size = new System.Drawing.Size(909, 494);
            this.pnlEvenement.TabIndex = 3;
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEvenement);
            this.Name = "Bilan";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Bilan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEvenement;
    }
}
