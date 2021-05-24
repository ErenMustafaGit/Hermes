namespace Hermes
{
    partial class AjNouvelleDepense2
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
            this.pnlBeneficiaire = new System.Windows.Forms.Panel();
            this.chkEveryOne = new System.Windows.Forms.CheckBox();
            this.rtxtCommentaire = new System.Windows.Forms.RichTextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCommentaire = new Hermes.UI.AppFontLabel();
            this.lblBeneficiaire = new Hermes.UI.AppFontLabel();
            this.pnlBeneficiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBeneficiaire
            // 
            this.pnlBeneficiaire.Controls.Add(this.chkEveryOne);
            this.pnlBeneficiaire.Location = new System.Drawing.Point(130, 160);
            this.pnlBeneficiaire.Name = "pnlBeneficiaire";
            this.pnlBeneficiaire.Size = new System.Drawing.Size(357, 297);
            this.pnlBeneficiaire.TabIndex = 1;
            // 
            // chkEveryOne
            // 
            this.chkEveryOne.AutoSize = true;
            this.chkEveryOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEveryOne.Location = new System.Drawing.Point(21, 14);
            this.chkEveryOne.Name = "chkEveryOne";
            this.chkEveryOne.Size = new System.Drawing.Size(135, 22);
            this.chkEveryOne.TabIndex = 0;
            this.chkEveryOne.Text = "Tout le monde";
            this.chkEveryOne.UseVisualStyleBackColor = true;
            this.chkEveryOne.CheckedChanged += new System.EventHandler(this.ChkEveryOne_CheckedChanged);
            // 
            // rtxtCommentaire
            // 
            this.rtxtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtCommentaire.Location = new System.Drawing.Point(550, 174);
            this.rtxtCommentaire.Name = "rtxtCommentaire";
            this.rtxtCommentaire.Size = new System.Drawing.Size(336, 283);
            this.rtxtCommentaire.TabIndex = 2;
            this.rtxtCommentaire.Text = "";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(781, 556);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(105, 30);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(658, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblCommentaire.AppFontHeight = 14F;
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(546, 138);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(124, 22);
            this.lblCommentaire.TabIndex = 3;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblBeneficiaire.AppFontHeight = 28F;
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(89, 94);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(249, 47);
            this.lblBeneficiaire.TabIndex = 0;
            this.lblBeneficiaire.Text = "Bénéficiaires";
            // 
            // AjNouvelleDepense2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.rtxtCommentaire);
            this.Controls.Add(this.pnlBeneficiaire);
            this.Controls.Add(this.lblBeneficiaire);
            this.Name = "AjNouvelleDepense2";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.AjNouvelleDepense2_Load);
            this.pnlBeneficiaire.ResumeLayout(false);
            this.pnlBeneficiaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblBeneficiaire;
        private System.Windows.Forms.Panel pnlBeneficiaire;
        private System.Windows.Forms.CheckBox chkEveryOne;
        private System.Windows.Forms.RichTextBox rtxtCommentaire;
        private UI.AppFontLabel lblCommentaire;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button1;
    }
}
