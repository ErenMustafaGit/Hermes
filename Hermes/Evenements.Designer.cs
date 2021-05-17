namespace Hermes
{
    partial class Evenements
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
            this.lblEvenement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.lblEvenement.Location = new System.Drawing.Point(130, 131);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(336, 62);
            this.lblEvenement.TabIndex = 1;
            this.lblEvenement.Text = "Evenements";
            // 
            // Evenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEvenement);
            this.Name = "Evenements";
            this.Size = new System.Drawing.Size(1064, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvenement;
    }
}
