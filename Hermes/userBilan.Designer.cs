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
            this.lblVueGlobale = new Hermes.UI.AppFontLabel();
            this.lblGoBaaack = new Hermes.UI.AppFontLabel();
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
            this.cboParticipant.Size = new System.Drawing.Size(260, 28);
            this.cboParticipant.TabIndex = 21;
            this.cboParticipant.SelectedIndexChanged += new System.EventHandler(this.CboParticipant_SelectedIndexChanged);
            // 
            // pnlDepense
            // 
            this.pnlDepense.Location = new System.Drawing.Point(72, 330);
            this.pnlDepense.Name = "pnlDepense";
            this.pnlDepense.Size = new System.Drawing.Size(388, 257);
            this.pnlDepense.TabIndex = 33;
            // 
            // pnlRemboursement
            // 
            this.pnlRemboursement.Location = new System.Drawing.Point(519, 330);
            this.pnlRemboursement.Name = "pnlRemboursement";
            this.pnlRemboursement.Size = new System.Drawing.Size(387, 257);
            this.pnlRemboursement.TabIndex = 34;
            // 
            // lblVueGlobale
            // 
            this.lblVueGlobale.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblVueGlobale.AppFontHeight = 9F;
            this.lblVueGlobale.AutoSize = true;
            this.lblVueGlobale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblVueGlobale.Location = new System.Drawing.Point(48, 607);
            this.lblVueGlobale.Name = "lblVueGlobale";
            this.lblVueGlobale.Size = new System.Drawing.Size(72, 14);
            this.lblVueGlobale.TabIndex = 41;
            this.lblVueGlobale.Text = "Bilan global";
            this.lblVueGlobale.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblVueGlobale.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.lblVueGlobale.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // lblGoBaaack
            // 
            this.lblGoBaaack.AppFont = Hermes.AppFont.Icons;
            this.lblGoBaaack.AppFontHeight = 20F;
            this.lblGoBaaack.AutoSize = true;
            this.lblGoBaaack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.lblGoBaaack.Location = new System.Drawing.Point(23, 599);
            this.lblGoBaaack.Name = "lblGoBaaack";
            this.lblGoBaaack.Size = new System.Drawing.Size(29, 27);
            this.lblGoBaaack.TabIndex = 40;
            this.lblGoBaaack.Text = "O";
            this.lblGoBaaack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGoBaaack.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.lblGoBaaack.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.lblGoBaaack.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
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
            this.lblTotalRemboursement.AppFontHeight = 45F;
            this.lblTotalRemboursement.AutoSize = true;
            this.lblTotalRemboursement.Location = new System.Drawing.Point(506, 247);
            this.lblTotalRemboursement.Name = "lblTotalRemboursement";
            this.lblTotalRemboursement.Size = new System.Drawing.Size(276, 75);
            this.lblTotalRemboursement.TabIndex = 32;
            this.lblTotalRemboursement.Text = "147,20 €";
            // 
            // lblTextRemboursement
            // 
            this.lblTextRemboursement.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblTextRemboursement.AppFontHeight = 14F;
            this.lblTextRemboursement.AutoSize = true;
            this.lblTextRemboursement.Location = new System.Drawing.Point(515, 228);
            this.lblTextRemboursement.Name = "lblTextRemboursement";
            this.lblTextRemboursement.Size = new System.Drawing.Size(348, 22);
            this.lblTextRemboursement.TabIndex = 31;
            this.lblTextRemboursement.Text = "Total des remboursements à effectuer";
            // 
            // lblTotalDepnse
            // 
            this.lblTotalDepnse.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblTotalDepnse.AppFontHeight = 45F;
            this.lblTotalDepnse.AutoSize = true;
            this.lblTotalDepnse.Location = new System.Drawing.Point(59, 247);
            this.lblTotalDepnse.Name = "lblTotalDepnse";
            this.lblTotalDepnse.Size = new System.Drawing.Size(276, 75);
            this.lblTotalDepnse.TabIndex = 30;
            this.lblTotalDepnse.Text = "278,00 €";
            // 
            // appFontLabel3
            // 
            this.appFontLabel3.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel3.AppFontHeight = 14F;
            this.appFontLabel3.Location = new System.Drawing.Point(72, 228);
            this.appFontLabel3.Name = "appFontLabel3";
            this.appFontLabel3.Size = new System.Drawing.Size(304, 34);
            this.appFontLabel3.TabIndex = 25;
            this.appFontLabel3.Text = "Total des dépenses effectuées";
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 10F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(69, 129);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(235, 16);
            this.appFontLabel1.TabIndex = 22;
            this.appFontLabel1.Text = "Compte-rendu pour le participant :";
            // 
            // UserBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVueGlobale);
            this.Controls.Add(this.lblGoBaaack);
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
        private UI.AppFontLabel lblVueGlobale;
        private UI.AppFontLabel lblGoBaaack;
    }
}
