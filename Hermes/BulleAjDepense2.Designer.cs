namespace Hermes
{
    partial class BulleAjDepense2
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.rtxtCommentaire = new System.Windows.Forms.RichTextBox();
            this.pnlBeneficiaire = new System.Windows.Forms.Panel();
            this.chkEveryOne = new System.Windows.Forms.CheckBox();
            this.lblCommentaire = new Hermes.UI.AppFontLabel();
            this.lblBeneficiaire = new Hermes.UI.AppFontLabel();
            this.lblEnArriere = new Hermes.UI.AppFontLabel();
            this.lblGoBaaack = new Hermes.UI.AppFontLabel();
            this.pnlBeneficiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(77, 319);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(278, 30);
            this.btnAnnuler.TabIndex = 33;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuer.Location = new System.Drawing.Point(361, 319);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(269, 30);
            this.btnContinuer.TabIndex = 34;
            this.btnContinuer.Text = "Ajouter";
            this.btnContinuer.UseVisualStyleBackColor = false;
            this.btnContinuer.Click += new System.EventHandler(this.BtnContinuer_Click);
            // 
            // rtxtCommentaire
            // 
            this.rtxtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCommentaire.Location = new System.Drawing.Point(361, 103);
            this.rtxtCommentaire.MaxLength = 50;
            this.rtxtCommentaire.Name = "rtxtCommentaire";
            this.rtxtCommentaire.Size = new System.Drawing.Size(269, 210);
            this.rtxtCommentaire.TabIndex = 37;
            this.rtxtCommentaire.Text = "";
            this.rtxtCommentaire.TextChanged += new System.EventHandler(this.RtxtCommentaire_TextChanged);
            // 
            // pnlBeneficiaire
            // 
            this.pnlBeneficiaire.Controls.Add(this.chkEveryOne);
            this.pnlBeneficiaire.Location = new System.Drawing.Point(77, 103);
            this.pnlBeneficiaire.Name = "pnlBeneficiaire";
            this.pnlBeneficiaire.Size = new System.Drawing.Size(278, 210);
            this.pnlBeneficiaire.TabIndex = 36;
            // 
            // chkEveryOne
            // 
            this.chkEveryOne.AutoSize = true;
            this.chkEveryOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEveryOne.Location = new System.Drawing.Point(21, 14);
            this.chkEveryOne.Name = "chkEveryOne";
            this.chkEveryOne.Size = new System.Drawing.Size(165, 28);
            this.chkEveryOne.TabIndex = 0;
            this.chkEveryOne.Text = "Tout le monde";
            this.chkEveryOne.UseVisualStyleBackColor = true;
            this.chkEveryOne.CheckedChanged += new System.EventHandler(this.ChkEveryOne_CheckedChanged);
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblCommentaire.AppFontHeight = 14F;
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(357, 66);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(124, 22);
            this.lblCommentaire.TabIndex = 38;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblBeneficiaire.AppFontHeight = 28F;
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(69, 41);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(249, 47);
            this.lblBeneficiaire.TabIndex = 35;
            this.lblBeneficiaire.Text = "Bénéficiaires";
            // 
            // lblEnArriere
            // 
            this.lblEnArriere.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblEnArriere.AppFontHeight = 9F;
            this.lblEnArriere.AutoSize = true;
            this.lblEnArriere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblEnArriere.Location = new System.Drawing.Point(50, 370);
            this.lblEnArriere.Name = "lblEnArriere";
            this.lblEnArriere.Size = new System.Drawing.Size(95, 14);
            this.lblEnArriere.TabIndex = 46;
            this.lblEnArriere.Text = "Retour en arrière";
            this.lblEnArriere.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblEnArriere.MouseEnter += new System.EventHandler(this.ClickableMouseEnter);
            this.lblEnArriere.MouseLeave += new System.EventHandler(this.ClickableMouseLeave);
            // 
            // lblGoBaaack
            // 
            this.lblGoBaaack.AppFont = Hermes.AppFont.Icons;
            this.lblGoBaaack.AppFontHeight = 20F;
            this.lblGoBaaack.AutoSize = true;
            this.lblGoBaaack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblGoBaaack.Location = new System.Drawing.Point(25, 362);
            this.lblGoBaaack.Name = "lblGoBaaack";
            this.lblGoBaaack.Size = new System.Drawing.Size(29, 27);
            this.lblGoBaaack.TabIndex = 45;
            this.lblGoBaaack.Text = "O";
            this.lblGoBaaack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGoBaaack.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblGoBaaack.MouseEnter += new System.EventHandler(this.ClickableMouseEnter);
            this.lblGoBaaack.MouseLeave += new System.EventHandler(this.ClickableMouseLeave);
            // 
            // BulleAjDepense2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEnArriere);
            this.Controls.Add(this.lblGoBaaack);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.rtxtCommentaire);
            this.Controls.Add(this.pnlBeneficiaire);
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContinuer);
            this.Name = "BulleAjDepense2";
            this.Size = new System.Drawing.Size(705, 405);
            this.Load += new System.EventHandler(this.BulleAjDepense2_Load);
            this.pnlBeneficiaire.ResumeLayout(false);
            this.pnlBeneficiaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnContinuer;
        private UI.AppFontLabel lblCommentaire;
        private System.Windows.Forms.RichTextBox rtxtCommentaire;
        private System.Windows.Forms.Panel pnlBeneficiaire;
        private System.Windows.Forms.CheckBox chkEveryOne;
        private UI.AppFontLabel lblBeneficiaire;
        private UI.AppFontLabel lblEnArriere;
        private UI.AppFontLabel lblGoBaaack;
    }
}
