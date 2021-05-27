﻿namespace Hermes
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
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.cboParticipant = new System.Windows.Forms.ComboBox();
            this.pnlDepense = new System.Windows.Forms.Panel();
            this.pnlRemboursement = new System.Windows.Forms.Panel();
            this.depenseUser1 = new Hermes.DepenseUser();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.lblTextRemboursement = new Hermes.UI.AppFontLabel();
            this.appFontLabel4 = new Hermes.UI.AppFontLabel();
            this.appFontLabel3 = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.cboCreateur = new Hermes.UI.AppFontLabel();
            this.pnlDepense.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEvent
            // 
            this.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(88, 101);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(230, 28);
            this.cboEvent.TabIndex = 19;
            // 
            // cboParticipant
            // 
            this.cboParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboParticipant.FormattingEnabled = true;
            this.cboParticipant.Location = new System.Drawing.Point(344, 101);
            this.cboParticipant.Name = "cboParticipant";
            this.cboParticipant.Size = new System.Drawing.Size(230, 28);
            this.cboParticipant.TabIndex = 21;
            // 
            // pnlDepense
            // 
            this.pnlDepense.Controls.Add(this.depenseUser1);
            this.pnlDepense.Location = new System.Drawing.Point(74, 331);
            this.pnlDepense.Name = "pnlDepense";
            this.pnlDepense.Size = new System.Drawing.Size(388, 264);
            this.pnlDepense.TabIndex = 33;
            // 
            // pnlRemboursement
            // 
            this.pnlRemboursement.Location = new System.Drawing.Point(515, 331);
            this.pnlRemboursement.Name = "pnlRemboursement";
            this.pnlRemboursement.Size = new System.Drawing.Size(387, 264);
            this.pnlRemboursement.TabIndex = 34;
            // 
            // depenseUser1
            // 
            this.depenseUser1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.depenseUser1.Location = new System.Drawing.Point(0, 0);
            this.depenseUser1.Name = "depenseUser1";
            this.depenseUser1.Size = new System.Drawing.Size(386, 120);
            this.depenseUser1.TabIndex = 0;
            this.depenseUser1.Load += new System.EventHandler(this.depenseUser1_Load);
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel2.AppFontHeight = 60F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(498, 208);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(345, 100);
            this.appFontLabel2.TabIndex = 32;
            this.appFontLabel2.Text = "147,20€";
            // 
            // lblTextRemboursement
            // 
            this.lblTextRemboursement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblTextRemboursement.AppFontHeight = 18F;
            this.lblTextRemboursement.AutoSize = true;
            this.lblTextRemboursement.Location = new System.Drawing.Point(510, 180);
            this.lblTextRemboursement.Name = "lblTextRemboursement";
            this.lblTextRemboursement.Size = new System.Drawing.Size(253, 28);
            this.lblTextRemboursement.TabIndex = 31;
            this.lblTextRemboursement.Text = "Total remboursement :";
            // 
            // appFontLabel4
            // 
            this.appFontLabel4.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.appFontLabel4.AppFontHeight = 60F;
            this.appFontLabel4.AutoSize = true;
            this.appFontLabel4.Location = new System.Drawing.Point(71, 208);
            this.appFontLabel4.Name = "appFontLabel4";
            this.appFontLabel4.Size = new System.Drawing.Size(345, 100);
            this.appFontLabel4.TabIndex = 30;
            this.appFontLabel4.Text = "278,00€";
            // 
            // appFontLabel3
            // 
            this.appFontLabel3.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel3.AppFontHeight = 18F;
            this.appFontLabel3.AutoSize = true;
            this.appFontLabel3.Location = new System.Drawing.Point(83, 180);
            this.appFontLabel3.Name = "appFontLabel3";
            this.appFontLabel3.Size = new System.Drawing.Size(176, 28);
            this.appFontLabel3.TabIndex = 25;
            this.appFontLabel3.Text = "Total dépense :";
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 10F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(341, 73);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(121, 16);
            this.appFontLabel1.TabIndex = 22;
            this.appFontLabel1.Text = "Quel participant ?";
            // 
            // cboCreateur
            // 
            this.cboCreateur.AppFont = Hermes.AppFont.HelveticaNeue;
            this.cboCreateur.AppFontHeight = 10F;
            this.cboCreateur.AutoSize = true;
            this.cboCreateur.Location = new System.Drawing.Point(85, 73);
            this.cboCreateur.Name = "cboCreateur";
            this.cboCreateur.Size = new System.Drawing.Size(125, 16);
            this.cboCreateur.TabIndex = 20;
            this.cboCreateur.Text = "Quel évènement ?";
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRemboursement);
            this.Controls.Add(this.pnlDepense);
            this.Controls.Add(this.appFontLabel2);
            this.Controls.Add(this.lblTextRemboursement);
            this.Controls.Add(this.appFontLabel4);
            this.Controls.Add(this.appFontLabel3);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.cboParticipant);
            this.Controls.Add(this.cboCreateur);
            this.Controls.Add(this.cboEvent);
            this.Name = "Bilan";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Bilan_Load);
            this.pnlDepense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel cboCreateur;
        private System.Windows.Forms.ComboBox cboEvent;
        private UI.AppFontLabel appFontLabel1;
        private System.Windows.Forms.ComboBox cboParticipant;
        private UI.AppFontLabel appFontLabel3;
        private UI.AppFontLabel appFontLabel4;
        private UI.AppFontLabel appFontLabel2;
        private UI.AppFontLabel lblTextRemboursement;
        private System.Windows.Forms.Panel pnlDepense;
        private System.Windows.Forms.Panel pnlRemboursement;
        private DepenseUser depenseUser1;
    }
}
