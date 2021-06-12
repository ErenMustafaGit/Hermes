namespace Hermes
{
    partial class RemboursementUser
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
            this.lblAmountDepense = new Hermes.UI.AppFontLabel();
            this.lblNbrPart = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblAmountDepense
            // 
            this.lblAmountDepense.AppFont = Hermes.AppFont.HelveticaNeue_Medium;
            this.lblAmountDepense.AppFontHeight = 20F;
            this.lblAmountDepense.AutoSize = true;
            this.lblAmountDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblAmountDepense.Location = new System.Drawing.Point(23, 68);
            this.lblAmountDepense.Name = "lblAmountDepense";
            this.lblAmountDepense.Size = new System.Drawing.Size(113, 32);
            this.lblAmountDepense.TabIndex = 6;
            this.lblAmountDepense.Text = "120,00€";
            // 
            // lblNbrPart
            // 
            this.lblNbrPart.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNbrPart.AppFontHeight = 17F;
            this.lblNbrPart.AutoSize = true;
            this.lblNbrPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNbrPart.Location = new System.Drawing.Point(24, 23);
            this.lblNbrPart.Name = "lblNbrPart";
            this.lblNbrPart.Size = new System.Drawing.Size(218, 29);
            this.lblNbrPart.TabIndex = 4;
            this.lblNbrPart.Text = "Nombre de part : 9";
            // 
            // RemboursementUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblAmountDepense);
            this.Controls.Add(this.lblNbrPart);
            this.Name = "RemboursementUser";
            this.Size = new System.Drawing.Size(386, 120);
            this.Load += new System.EventHandler(this.RemboursementUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblAmountDepense;
        private UI.AppFontLabel lblNbrPart;
    }
}
