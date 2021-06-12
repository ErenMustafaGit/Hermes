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
            this.pnlParticipant = new System.Windows.Forms.Panel();
            this.lblGoBaaack = new Hermes.UI.AppFontLabel();
            this.lblGauche = new Hermes.UI.AppFontLabel();
            this.lblGaucheGauche = new Hermes.UI.AppFontLabel();
            this.lblIconeDroiteDroite = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblMax = new Hermes.UI.AppFontLabel();
            this.lblCurrentPosition = new Hermes.UI.AppFontLabel();
            this.lblIconeDroite = new Hermes.UI.AppFontLabel();
            this.lblTrueFalse = new Hermes.UI.AppFontLabel();
            this.lblSoldé = new Hermes.UI.AppFontLabel();
            this.lblDateEnd = new Hermes.UI.AppFontLabel();
            this.lblDateEvenementAu = new Hermes.UI.AppFontLabel();
            this.lblDateStart = new Hermes.UI.AppFontLabel();
            this.lblIconeDate = new Hermes.UI.AppFontLabel();
            this.lblVueGlobale = new Hermes.UI.AppFontLabel();
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
            this.lblDescEvenement.Location = new System.Drawing.Point(77, 184);
            this.lblDescEvenement.Name = "lblDescEvenement";
            this.lblDescEvenement.Size = new System.Drawing.Size(609, 86);
            this.lblDescEvenement.TabIndex = 4;
            this.lblDescEvenement.Text = "Nom";
            // 
            // lblNomEvenement
            // 
            this.lblNomEvenement.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNomEvenement.AppFontHeight = 40F;
            this.lblNomEvenement.AutoSize = true;
            this.lblNomEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNomEvenement.Location = new System.Drawing.Point(70, 97);
            this.lblNomEvenement.Name = "lblNomEvenement";
            this.lblNomEvenement.Size = new System.Drawing.Size(146, 67);
            this.lblNomEvenement.TabIndex = 2;
            this.lblNomEvenement.Text = "Nom";
            // 
            // pnlParticipant
            // 
            this.pnlParticipant.Location = new System.Drawing.Point(586, 276);
            this.pnlParticipant.Name = "pnlParticipant";
            this.pnlParticipant.Size = new System.Drawing.Size(369, 364);
            this.pnlParticipant.TabIndex = 12;
            // 
            // lblGoBaaack
            // 
            this.lblGoBaaack.AppFont = Hermes.AppFont.Icons;
            this.lblGoBaaack.AppFontHeight = 20F;
            this.lblGoBaaack.AutoSize = true;
            this.lblGoBaaack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblGoBaaack.Location = new System.Drawing.Point(24, 589);
            this.lblGoBaaack.Name = "lblGoBaaack";
            this.lblGoBaaack.Size = new System.Drawing.Size(29, 27);
            this.lblGoBaaack.TabIndex = 20;
            this.lblGoBaaack.Text = "O";
            this.lblGoBaaack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGoBaaack.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblGoBaaack.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.lblGoBaaack.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // lblGauche
            // 
            this.lblGauche.AppFont = Hermes.AppFont.Icons;
            this.lblGauche.AppFontHeight = 22F;
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(392, 588);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(26, 31);
            this.lblGauche.TabIndex = 19;
            this.lblGauche.Text = "x";
            this.lblGauche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGauche.Click += new System.EventHandler(this.LblGauche_Click);
            this.lblGauche.MouseLeave += new System.EventHandler(this.LblGauche_MouseLeave);
            this.lblGauche.MouseHover += new System.EventHandler(this.LblGauche_MouseHover);
            // 
            // lblGaucheGauche
            // 
            this.lblGaucheGauche.AppFont = Hermes.AppFont.Icons;
            this.lblGaucheGauche.AppFontHeight = 22F;
            this.lblGaucheGauche.AutoSize = true;
            this.lblGaucheGauche.Location = new System.Drawing.Point(366, 588);
            this.lblGaucheGauche.Name = "lblGaucheGauche";
            this.lblGaucheGauche.Size = new System.Drawing.Size(26, 31);
            this.lblGaucheGauche.TabIndex = 18;
            this.lblGaucheGauche.Text = "x";
            this.lblGaucheGauche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGaucheGauche.Click += new System.EventHandler(this.LblGaucheGauche_Click);
            this.lblGaucheGauche.MouseLeave += new System.EventHandler(this.LblGaucheGauche_MouseLeave);
            this.lblGaucheGauche.MouseHover += new System.EventHandler(this.LblGaucheGauche_MouseHover);
            // 
            // lblIconeDroiteDroite
            // 
            this.lblIconeDroiteDroite.AppFont = Hermes.AppFont.Icons;
            this.lblIconeDroiteDroite.AppFontHeight = 22F;
            this.lblIconeDroiteDroite.AutoSize = true;
            this.lblIconeDroiteDroite.Location = new System.Drawing.Point(525, 588);
            this.lblIconeDroiteDroite.Name = "lblIconeDroiteDroite";
            this.lblIconeDroiteDroite.Size = new System.Drawing.Size(26, 31);
            this.lblIconeDroiteDroite.TabIndex = 17;
            this.lblIconeDroiteDroite.Text = "x";
            this.lblIconeDroiteDroite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIconeDroiteDroite.Click += new System.EventHandler(this.LblIconeDroiteDroite_Click);
            this.lblIconeDroiteDroite.MouseLeave += new System.EventHandler(this.LblIconeDroiteDroite_MouseLeave);
            this.lblIconeDroiteDroite.MouseHover += new System.EventHandler(this.LblIconeDroiteDroite_MouseHover);
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 12F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(441, 597);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(32, 19);
            this.appFontLabel1.TabIndex = 16;
            this.appFontLabel1.Text = "sur";
            // 
            // lblMax
            // 
            this.lblMax.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblMax.AppFontHeight = 12F;
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(478, 597);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 19);
            this.lblMax.TabIndex = 15;
            this.lblMax.Text = "10";
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblCurrentPosition.AppFontHeight = 12F;
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblCurrentPosition.Location = new System.Drawing.Point(417, 597);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(18, 19);
            this.lblCurrentPosition.TabIndex = 14;
            this.lblCurrentPosition.Text = "1";
            // 
            // lblIconeDroite
            // 
            this.lblIconeDroite.AppFont = Hermes.AppFont.Icons;
            this.lblIconeDroite.AppFontHeight = 22F;
            this.lblIconeDroite.AutoSize = true;
            this.lblIconeDroite.Location = new System.Drawing.Point(501, 588);
            this.lblIconeDroite.Name = "lblIconeDroite";
            this.lblIconeDroite.Size = new System.Drawing.Size(26, 31);
            this.lblIconeDroite.TabIndex = 13;
            this.lblIconeDroite.Text = "x";
            this.lblIconeDroite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIconeDroite.Click += new System.EventHandler(this.LblIconeDroite_Click);
            this.lblIconeDroite.MouseLeave += new System.EventHandler(this.LblIconeDroite_MouseLeave);
            this.lblIconeDroite.MouseHover += new System.EventHandler(this.LblIconeDroite_MouseHover);
            // 
            // lblTrueFalse
            // 
            this.lblTrueFalse.AppFont = Hermes.AppFont.Icons;
            this.lblTrueFalse.AppFontHeight = 37F;
            this.lblTrueFalse.AutoSize = true;
            this.lblTrueFalse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblTrueFalse.Location = new System.Drawing.Point(94, 460);
            this.lblTrueFalse.Name = "lblTrueFalse";
            this.lblTrueFalse.Size = new System.Drawing.Size(43, 51);
            this.lblTrueFalse.TabIndex = 11;
            this.lblTrueFalse.Text = "x";
            this.lblTrueFalse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSoldé
            // 
            this.lblSoldé.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblSoldé.AppFontHeight = 37F;
            this.lblSoldé.AutoSize = true;
            this.lblSoldé.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblSoldé.Location = new System.Drawing.Point(168, 454);
            this.lblSoldé.Name = "lblSoldé";
            this.lblSoldé.Size = new System.Drawing.Size(159, 62);
            this.lblSoldé.TabIndex = 5;
            this.lblSoldé.Text = "Soldé";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblDateEnd.AppFontHeight = 18F;
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblDateEnd.Location = new System.Drawing.Point(208, 376);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(222, 30);
            this.lblDateEnd.TabIndex = 10;
            this.lblDateEnd.Text = "31 décembre 2020";
            // 
            // lblDateEvenementAu
            // 
            this.lblDateEvenementAu.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDateEvenementAu.AppFontHeight = 18F;
            this.lblDateEvenementAu.AutoSize = true;
            this.lblDateEvenementAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblDateEvenementAu.Location = new System.Drawing.Point(174, 377);
            this.lblDateEvenementAu.Name = "lblDateEvenementAu";
            this.lblDateEvenementAu.Size = new System.Drawing.Size(53, 28);
            this.lblDateEvenementAu.TabIndex = 9;
            this.lblDateEvenementAu.Text = "au :";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblDateStart.AppFontHeight = 18F;
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblDateStart.Location = new System.Drawing.Point(174, 350);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(44, 30);
            this.lblDateStart.TabIndex = 8;
            this.lblDateStart.Text = "Du";
            // 
            // lblIconeDate
            // 
            this.lblIconeDate.AppFont = Hermes.AppFont.Icons;
            this.lblIconeDate.AppFontHeight = 39F;
            this.lblIconeDate.AutoSize = true;
            this.lblIconeDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIconeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblIconeDate.Location = new System.Drawing.Point(95, 350);
            this.lblIconeDate.Name = "lblIconeDate";
            this.lblIconeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIconeDate.Size = new System.Drawing.Size(56, 52);
            this.lblIconeDate.TabIndex = 6;
            this.lblIconeDate.Text = "O";
            // 
            // lblVueGlobale
            // 
            this.lblVueGlobale.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblVueGlobale.AppFontHeight = 9F;
            this.lblVueGlobale.AutoSize = true;
            this.lblVueGlobale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblVueGlobale.Location = new System.Drawing.Point(49, 597);
            this.lblVueGlobale.Name = "lblVueGlobale";
            this.lblVueGlobale.Size = new System.Drawing.Size(72, 14);
            this.lblVueGlobale.TabIndex = 22;
            this.lblVueGlobale.Text = "Vue globale";
            this.lblVueGlobale.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblVueGlobale.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.lblVueGlobale.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // CompleteInfoEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVueGlobale);
            this.Controls.Add(this.lblGoBaaack);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.lblGaucheGauche);
            this.Controls.Add(this.lblIconeDroiteDroite);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblCurrentPosition);
            this.Controls.Add(this.lblIconeDroite);
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
        private UI.AppFontLabel lblIconeDroite;
        private UI.AppFontLabel lblCurrentPosition;
        private UI.AppFontLabel lblMax;
        private UI.AppFontLabel appFontLabel1;
        private UI.AppFontLabel lblIconeDroiteDroite;
        private UI.AppFontLabel lblGauche;
        private UI.AppFontLabel lblGaucheGauche;
        private UI.AppFontLabel lblGoBaaack;
        private UI.AppFontLabel lblVueGlobale;
    }
}
