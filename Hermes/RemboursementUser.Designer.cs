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
            this.lblNom = new Hermes.UI.AppFontLabel();
            this.lblAmountDepense = new Hermes.UI.AppFontLabel();
            this.lblNbrPart = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNom.AppFontHeight = 17F;
            this.lblNom.AutoEllipsis = true;
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNom.Location = new System.Drawing.Point(23, 23);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(342, 32);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom de la dépense";
            // 
            // lblAmountDepense
            // 
            this.lblAmountDepense.AppFont = Hermes.AppFont.HelveticaNeue_Medium;
            this.lblAmountDepense.AppFontHeight = 20F;
            this.lblAmountDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblAmountDepense.Location = new System.Drawing.Point(185, 70);
            this.lblAmountDepense.Name = "lblAmountDepense";
            this.lblAmountDepense.Size = new System.Drawing.Size(180, 35);
            this.lblAmountDepense.TabIndex = 6;
            this.lblAmountDepense.Text = "120,00 €";
            this.lblAmountDepense.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNbrPart
            // 
            this.lblNbrPart.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblNbrPart.AppFontHeight = 10F;
            this.lblNbrPart.AutoSize = true;
            this.lblNbrPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNbrPart.Location = new System.Drawing.Point(25, 70);
            this.lblNbrPart.Name = "lblNbrPart";
            this.lblNbrPart.Size = new System.Drawing.Size(161, 23);
            this.lblNbrPart.TabIndex = 4;
            this.lblNbrPart.Text = "100 % des parts";
            // 
            // RemboursementUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblNom);
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
        private UI.AppFontLabel lblNom;
    }
}
