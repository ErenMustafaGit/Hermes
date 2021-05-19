namespace Hermes
{
    partial class AjoutNouvelleDepense2
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
            this.chkEveryone = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlBeneficiary = new System.Windows.Forms.Panel();
            this.lblComment = new Hermes.UI.AppFontLabel();
            this.lblBeneficiary = new Hermes.UI.AppFontLabel();
            this.pnlBeneficiary.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEveryone
            // 
            this.chkEveryone.AutoSize = true;
            this.chkEveryone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEveryone.Location = new System.Drawing.Point(13, 16);
            this.chkEveryone.Name = "chkEveryone";
            this.chkEveryone.Size = new System.Drawing.Size(122, 22);
            this.chkEveryone.TabIndex = 27;
            this.chkEveryone.Text = "Tout le monde";
            this.chkEveryone.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(512, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 211);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // pnlBeneficiary
            // 
            this.pnlBeneficiary.Controls.Add(this.chkEveryone);
            this.pnlBeneficiary.Location = new System.Drawing.Point(99, 131);
            this.pnlBeneficiary.Name = "pnlBeneficiary";
            this.pnlBeneficiary.Size = new System.Drawing.Size(386, 382);
            this.pnlBeneficiary.TabIndex = 25;
            // 
            // lblComment
            // 
            this.lblComment.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblComment.AppFontHeight = 14F;
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(509, 153);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(94, 16);
            this.lblComment.TabIndex = 23;
            this.lblComment.Text = "Commentaire";
            // 
            // lblBeneficiary
            // 
            this.lblBeneficiary.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblBeneficiary.AppFontHeight = 30F;
            this.lblBeneficiary.AutoSize = true;
            this.lblBeneficiary.Location = new System.Drawing.Point(71, 78);
            this.lblBeneficiary.Name = "lblBeneficiary";
            this.lblBeneficiary.Size = new System.Drawing.Size(261, 50);
            this.lblBeneficiary.TabIndex = 24;
            this.lblBeneficiary.Text = "Bénéficiaires";
            // 
            // AjoutNouvelleDepense2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlBeneficiary);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblBeneficiary);
            this.Name = "AjoutNouvelleDepense2";
            this.Size = new System.Drawing.Size(1064, 640);
            this.pnlBeneficiary.ResumeLayout(false);
            this.pnlBeneficiary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEveryone;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlBeneficiary;
        private UI.AppFontLabel lblComment;
        private UI.AppFontLabel lblBeneficiary;
    }
}
