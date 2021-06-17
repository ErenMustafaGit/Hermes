namespace Hermes
{
    partial class DepenseUser
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
            this.lblDateDepense = new Hermes.UI.AppFontLabel();
            this.lblNomDepense = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // lblAmountDepense
            // 
            this.lblAmountDepense.AppFont = Hermes.AppFont.HelveticaNeue_Medium;
            this.lblAmountDepense.AppFontHeight = 20F;
            this.lblAmountDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblAmountDepense.Location = new System.Drawing.Point(228, 70);
            this.lblAmountDepense.Name = "lblAmountDepense";
            this.lblAmountDepense.Size = new System.Drawing.Size(137, 35);
            this.lblAmountDepense.TabIndex = 3;
            this.lblAmountDepense.Text = "120,00 €";
            this.lblAmountDepense.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDateDepense.AppFontHeight = 10F;
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDateDepense.Location = new System.Drawing.Point(25, 70);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(136, 16);
            this.lblDateDepense.TabIndex = 2;
            this.lblDateDepense.Text = "Mardi 28 décembre";
            // 
            // lblNomDepense
            // 
            this.lblNomDepense.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNomDepense.AppFontHeight = 17F;
            this.lblNomDepense.AutoSize = true;
            this.lblNomDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNomDepense.Location = new System.Drawing.Point(23, 23);
            this.lblNomDepense.Name = "lblNomDepense";
            this.lblNomDepense.Size = new System.Drawing.Size(229, 29);
            this.lblNomDepense.TabIndex = 1;
            this.lblNomDepense.Text = "Courses alimentaire";
            // 
            // DepenseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblAmountDepense);
            this.Controls.Add(this.lblDateDepense);
            this.Controls.Add(this.lblNomDepense);
            this.Name = "DepenseUser";
            this.Size = new System.Drawing.Size(386, 120);
            this.Load += new System.EventHandler(this.DepenseUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblNomDepense;
        private UI.AppFontLabel lblDateDepense;
        private UI.AppFontLabel lblAmountDepense;
    }
}
