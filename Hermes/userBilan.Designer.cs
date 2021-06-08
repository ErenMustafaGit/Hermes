namespace Hermes
{
    partial class UserBilan
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
            this.cboParticipant = new System.Windows.Forms.ComboBox();
            this.pnlDepense = new System.Windows.Forms.Panel();
            this.pnlRemboursement = new System.Windows.Forms.Panel();
            this.btnBilanGlobal = new System.Windows.Forms.Button();
            this.lblEvent = new Hermes.UI.AppFontLabel();
            this.lblTotalRemboursement = new Hermes.UI.AppFontLabel();
            this.lblTextRemboursement = new Hermes.UI.AppFontLabel();
            this.lblTotalDepnse = new Hermes.UI.AppFontLabel();
            this.appFontLabel3 = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.SuspendLayout();
            // 
            // cboParticipant
            // 
            this.cboParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboParticipant.FormattingEnabled = true;
            this.cboParticipant.Location = new System.Drawing.Point(72, 157);
            this.cboParticipant.Name = "cboParticipant";
            this.cboParticipant.Size = new System.Drawing.Size(230, 28);
            this.cboParticipant.TabIndex = 21;
            this.cboParticipant.SelectedIndexChanged += new System.EventHandler(this.CboParticipant_SelectedIndexChanged);
            // 
            // pnlDepense
            // 
            this.pnlDepense.Location = new System.Drawing.Point(70, 350);
            this.pnlDepense.Name = "pnlDepense";
            this.pnlDepense.Size = new System.Drawing.Size(388, 257);
            this.pnlDepense.TabIndex = 33;
            this.pnlDepense.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDepense_Paint);
            // 
            // pnlRemboursement
            // 
            this.pnlRemboursement.Location = new System.Drawing.Point(517, 350);
            this.pnlRemboursement.Name = "pnlRemboursement";
            this.pnlRemboursement.Size = new System.Drawing.Size(387, 257);
            this.pnlRemboursement.TabIndex = 34;
            // 
            // btnBilanGlobal
            // 
            this.btnBilanGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnBilanGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilanGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnBilanGlobal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBilanGlobal.Location = new System.Drawing.Point(338, 157);
            this.btnBilanGlobal.Name = "btnBilanGlobal";
            this.btnBilanGlobal.Size = new System.Drawing.Size(144, 28);
            this.btnBilanGlobal.TabIndex = 39;
            this.btnBilanGlobal.Text = "Bilan global";
            this.btnBilanGlobal.UseVisualStyleBackColor = false;
            this.btnBilanGlobal.Click += new System.EventHandler(this.btnBilanGlobal_Click);
            // 
            // lblEvent
            // 
            this.lblEvent.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblEvent.AppFontHeight = 35F;
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(62, 58);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(525, 59);
            this.lblEvent.TabIndex = 38;
            this.lblEvent.Text = "Week-end dans le Jura";
            // 
            // lblTotalRemboursement
            // 
            this.lblTotalRemboursement.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblTotalRemboursement.AppFontHeight = 60F;
            this.lblTotalRemboursement.AutoSize = true;
            this.lblTotalRemboursement.Location = new System.Drawing.Point(531, 247);
            this.lblTotalRemboursement.Name = "lblTotalRemboursement";
            this.lblTotalRemboursement.Size = new System.Drawing.Size(345, 100);
            this.lblTotalRemboursement.TabIndex = 32;
            this.lblTotalRemboursement.Text = "147,20€";
            // 
            // lblTextRemboursement
            // 
            this.lblTextRemboursement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblTextRemboursement.AppFontHeight = 18F;
            this.lblTextRemboursement.AutoSize = true;
            this.lblTextRemboursement.Location = new System.Drawing.Point(543, 219);
            this.lblTextRemboursement.Name = "lblTextRemboursement";
            this.lblTextRemboursement.Size = new System.Drawing.Size(253, 28);
            this.lblTextRemboursement.TabIndex = 31;
            this.lblTextRemboursement.Text = "Total remboursement :";
            // 
            // lblTotalDepnse
            // 
            this.lblTotalDepnse.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblTotalDepnse.AppFontHeight = 60F;
            this.lblTotalDepnse.AutoSize = true;
            this.lblTotalDepnse.Location = new System.Drawing.Point(98, 247);
            this.lblTotalDepnse.Name = "lblTotalDepnse";
            this.lblTotalDepnse.Size = new System.Drawing.Size(345, 100);
            this.lblTotalDepnse.TabIndex = 30;
            this.lblTotalDepnse.Text = "278,00€";
            // 
            // appFontLabel3
            // 
            this.appFontLabel3.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel3.AppFontHeight = 18F;
            this.appFontLabel3.AutoSize = true;
            this.appFontLabel3.Location = new System.Drawing.Point(110, 219);
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
            this.appFontLabel1.Location = new System.Drawing.Point(69, 129);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(121, 16);
            this.appFontLabel1.TabIndex = 22;
            this.appFontLabel1.Text = "Quel participant ?";
            // 
            // UserBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBilanGlobal);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.pnlRemboursement);
            this.Controls.Add(this.pnlDepense);
            this.Controls.Add(this.lblTotalRemboursement);
            this.Controls.Add(this.lblTextRemboursement);
            this.Controls.Add(this.lblTotalDepnse);
            this.Controls.Add(this.appFontLabel3);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.cboParticipant);
            this.Name = "UserBilan";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.Bilan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI.AppFontLabel appFontLabel1;
        private System.Windows.Forms.ComboBox cboParticipant;
        private UI.AppFontLabel appFontLabel3;
        private UI.AppFontLabel lblTotalDepnse;
        private UI.AppFontLabel lblTotalRemboursement;
        private UI.AppFontLabel lblTextRemboursement;
        private System.Windows.Forms.Panel pnlDepense;
        private System.Windows.Forms.Panel pnlRemboursement;
        private UI.AppFontLabel lblEvent;
        private System.Windows.Forms.Button btnBilanGlobal;
    }
}
