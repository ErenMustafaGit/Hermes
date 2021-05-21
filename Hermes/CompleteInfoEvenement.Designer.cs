namespace Hermes
{
    partial class CompleteInfoEvenement
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
            this.pnlEvenementInfo = new System.Windows.Forms.Panel();
            this.lblDescEvenement = new Hermes.UI.AppFontLabel();
            this.lblNomEvenement = new Hermes.UI.AppFontLabel();
            this.lblTrueFalse = new Hermes.UI.AppFontLabel();
            this.lblSoldé = new Hermes.UI.AppFontLabel();
            this.lblDateEnd = new Hermes.UI.AppFontLabel();
            this.lblDateEvenementAu = new Hermes.UI.AppFontLabel();
            this.lblDateStart = new Hermes.UI.AppFontLabel();
            this.lblIconeDate = new Hermes.UI.AppFontLabel();
            this.pnlParticipant = new System.Windows.Forms.Panel();
            this.pnlEvenementInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEvenementInfo
            // 
            this.pnlEvenementInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.pnlEvenementInfo.Controls.Add(this.lblDescEvenement);
            this.pnlEvenementInfo.Controls.Add(this.lblNomEvenement);
            this.pnlEvenementInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlEvenementInfo.Name = "pnlEvenementInfo";
            this.pnlEvenementInfo.Size = new System.Drawing.Size(1064, 270);
            this.pnlEvenementInfo.TabIndex = 3;
            // 
            // lblDescEvenement
            // 
            this.lblDescEvenement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDescEvenement.AppFontHeight = 13F;
            this.lblDescEvenement.AutoEllipsis = true;
            this.lblDescEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDescEvenement.Location = new System.Drawing.Point(101, 184);
            this.lblDescEvenement.Name = "lblDescEvenement";
            this.lblDescEvenement.Size = new System.Drawing.Size(609, 86);
            this.lblDescEvenement.TabIndex = 4;
            this.lblDescEvenement.Text = "Nom";
            this.lblDescEvenement.Click += new System.EventHandler(this.appFontLabel1_Click);
            // 
            // lblNomEvenement
            // 
            this.lblNomEvenement.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNomEvenement.AppFontHeight = 37F;
            this.lblNomEvenement.AutoSize = true;
            this.lblNomEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNomEvenement.Location = new System.Drawing.Point(94, 97);
            this.lblNomEvenement.Name = "lblNomEvenement";
            this.lblNomEvenement.Size = new System.Drawing.Size(136, 62);
            this.lblNomEvenement.TabIndex = 2;
            this.lblNomEvenement.Text = "Nom";
            // 
            // lblTrueFalse
            // 
            this.lblTrueFalse.AppFont = Hermes.AppFont.Icons;
            this.lblTrueFalse.AppFontHeight = 37F;
            this.lblTrueFalse.AutoSize = true;
            this.lblTrueFalse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblTrueFalse.Location = new System.Drawing.Point(275, 473);
            this.lblTrueFalse.Name = "lblTrueFalse";
            this.lblTrueFalse.Size = new System.Drawing.Size(43, 51);
            this.lblTrueFalse.TabIndex = 11;
            this.lblTrueFalse.Text = "x";
            this.lblTrueFalse.Click += new System.EventHandler(this.LblTrueFalse_Click);
            // 
            // lblSoldé
            // 
            this.lblSoldé.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblSoldé.AppFontHeight = 37F;
            this.lblSoldé.AutoSize = true;
            this.lblSoldé.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblSoldé.Location = new System.Drawing.Point(104, 467);
            this.lblSoldé.Name = "lblSoldé";
            this.lblSoldé.Size = new System.Drawing.Size(174, 62);
            this.lblSoldé.TabIndex = 5;
            this.lblSoldé.Text = "Soldé ";
            this.lblSoldé.Click += new System.EventHandler(this.LblSoldé_Click);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblDateEnd.AppFontHeight = 18F;
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblDateEnd.Location = new System.Drawing.Point(222, 390);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(44, 30);
            this.lblDateEnd.TabIndex = 10;
            this.lblDateEnd.Text = "Du";
            this.lblDateEnd.Click += new System.EventHandler(this.LblDateEnd_Click);
            // 
            // lblDateEvenementAu
            // 
            this.lblDateEvenementAu.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDateEvenementAu.AppFontHeight = 18F;
            this.lblDateEvenementAu.AutoSize = true;
            this.lblDateEvenementAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblDateEvenementAu.Location = new System.Drawing.Point(184, 390);
            this.lblDateEvenementAu.Name = "lblDateEvenementAu";
            this.lblDateEvenementAu.Size = new System.Drawing.Size(52, 28);
            this.lblDateEvenementAu.TabIndex = 9;
            this.lblDateEvenementAu.Text = "au :";
            this.lblDateEvenementAu.Click += new System.EventHandler(this.LblDateEvenementAu_Click);
            // 
            // lblDateStart
            // 
            this.lblDateStart.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblDateStart.AppFontHeight = 18F;
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblDateStart.Location = new System.Drawing.Point(184, 362);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(44, 30);
            this.lblDateStart.TabIndex = 8;
            this.lblDateStart.Text = "Du";
            this.lblDateStart.Click += new System.EventHandler(this.LblDateStart_Click);
            // 
            // lblIconeDate
            // 
            this.lblIconeDate.AppFont = Hermes.AppFont.Icons;
            this.lblIconeDate.AppFontHeight = 39F;
            this.lblIconeDate.AutoSize = true;
            this.lblIconeDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIconeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblIconeDate.Location = new System.Drawing.Point(105, 363);
            this.lblIconeDate.Name = "lblIconeDate";
            this.lblIconeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIconeDate.Size = new System.Drawing.Size(56, 52);
            this.lblIconeDate.TabIndex = 6;
            this.lblIconeDate.Text = "O";
            this.lblIconeDate.Click += new System.EventHandler(this.LblIconeDate_Click);
            // 
            // pnlParticipant
            // 
            this.pnlParticipant.Location = new System.Drawing.Point(586, 276);
            this.pnlParticipant.Name = "pnlParticipant";
            this.pnlParticipant.Size = new System.Drawing.Size(369, 364);
            this.pnlParticipant.TabIndex = 12;
            // 
            // CompleteInfoEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlParticipant);
            this.Controls.Add(this.lblTrueFalse);
            this.Controls.Add(this.lblSoldé);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateEvenementAu);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.lblIconeDate);
            this.Controls.Add(this.pnlEvenementInfo);
            this.Name = "CompleteInfoEvenement";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.CompleteInfoEvenement_Load);
            this.pnlEvenementInfo.ResumeLayout(false);
            this.pnlEvenementInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblNomEvenement;
        private System.Windows.Forms.Panel pnlEvenementInfo;
        private UI.AppFontLabel lblDescEvenement;
        private UI.AppFontLabel lblIconeDate;
        private UI.AppFontLabel lblDateStart;
        private UI.AppFontLabel lblDateEnd;
        private UI.AppFontLabel lblDateEvenementAu;
        private UI.AppFontLabel lblSoldé;
        private UI.AppFontLabel lblTrueFalse;
        private System.Windows.Forms.Panel pnlParticipant;
    }
}
