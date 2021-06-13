namespace Hermes
{
    partial class AjNouvelleDepense
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
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cboPayePar = new System.Windows.Forms.ComboBox();
            this.appFontLabel8 = new Hermes.UI.AppFontLabel();
            this.lblAnnuler = new Hermes.UI.AppFontLabel();
            this.appFontLabel6 = new Hermes.UI.AppFontLabel();
            this.lblDate = new Hermes.UI.AppFontLabel();
            this.lblAmount = new Hermes.UI.AppFontLabel();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblNouvelleDepense = new Hermes.UI.AppFontLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEvenements
            // 
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(171, 259);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(249, 28);
            this.cboEvenements.TabIndex = 1;
            this.cboEvenements.SelectionChangeCommitted += new System.EventHandler(this.cboEvenements_SelectionChangeCommitted);
            // 
            // txtWhere
            // 
            this.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtWhere.Location = new System.Drawing.Point(171, 341);
            this.txtWhere.MaxLength = 30;
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(249, 27);
            this.txtWhere.TabIndex = 2;
            this.txtWhere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWhere_KeyPress);
            // 
            // numAmount
            // 
            this.numAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numAmount.Location = new System.Drawing.Point(171, 415);
            this.numAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(249, 27);
            this.numAmount.TabIndex = 3;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            this.numAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAmount_KeyPress);
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtp.Location = new System.Drawing.Point(479, 261);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(263, 27);
            this.dtp.TabIndex = 4;
            this.dtp.Value = new System.DateTime(2021, 5, 18, 18, 23, 0, 0);
            // 
            // cboPayePar
            // 
            this.cboPayePar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(479, 340);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(263, 28);
            this.cboPayePar.TabIndex = 5;
            // 
            // appFontLabel8
            // 
            this.appFontLabel8.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel8.AppFontHeight = 12F;
            this.appFontLabel8.AutoSize = true;
            this.appFontLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.appFontLabel8.Location = new System.Drawing.Point(783, 579);
            this.appFontLabel8.Name = "appFontLabel8";
            this.appFontLabel8.Size = new System.Drawing.Size(81, 19);
            this.appFontLabel8.TabIndex = 6;
            this.appFontLabel8.Text = "Continuer";
            this.appFontLabel8.Click += new System.EventHandler(this.AppFontLabel8_Click);
            this.appFontLabel8.MouseLeave += new System.EventHandler(this.AppFontLabel8_MouseLeave);
            this.appFontLabel8.MouseHover += new System.EventHandler(this.AppFontLabel8_MouseHover);
            // 
            // lblAnnuler
            // 
            this.lblAnnuler.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblAnnuler.AppFontHeight = 12F;
            this.lblAnnuler.AutoSize = true;
            this.lblAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblAnnuler.Location = new System.Drawing.Point(702, 579);
            this.lblAnnuler.Name = "lblAnnuler";
            this.lblAnnuler.Size = new System.Drawing.Size(66, 19);
            this.lblAnnuler.TabIndex = 7;
            this.lblAnnuler.Text = "Annuler";
            this.lblAnnuler.Click += new System.EventHandler(this.appFontLabel7_Click);
            this.lblAnnuler.MouseLeave += new System.EventHandler(this.lblAnnuler_MouseLeave);
            this.lblAnnuler.MouseHover += new System.EventHandler(this.appFontLabel7_MouseHover);
            // 
            // appFontLabel6
            // 
            this.appFontLabel6.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel6.AppFontHeight = 10F;
            this.appFontLabel6.AutoSize = true;
            this.appFontLabel6.Location = new System.Drawing.Point(476, 312);
            this.appFontLabel6.Name = "appFontLabel6";
            this.appFontLabel6.Size = new System.Drawing.Size(86, 16);
            this.appFontLabel6.TabIndex = 16;
            this.appFontLabel6.Text = "Payée par ?";
            // 
            // lblDate
            // 
            this.lblDate.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDate.AppFontHeight = 10F;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(476, 236);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(136, 16);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date de la dépense";
            // 
            // lblAmount
            // 
            this.lblAmount.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblAmount.AppFontHeight = 10F;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(168, 385);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(159, 16);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Montant de la dépense";
            // 
            // appFontLabel2
            // 
            this.appFontLabel2.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel2.AppFontHeight = 10F;
            this.appFontLabel2.AutoSize = true;
            this.appFontLabel2.Location = new System.Drawing.Point(168, 312);
            this.appFontLabel2.Name = "appFontLabel2";
            this.appFontLabel2.Size = new System.Drawing.Size(179, 16);
            this.appFontLabel2.TabIndex = 6;
            this.appFontLabel2.Text = "Description de la dépense";
            // 
            // appFontLabel1
            // 
            this.appFontLabel1.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel1.AppFontHeight = 10F;
            this.appFontLabel1.AutoSize = true;
            this.appFontLabel1.Location = new System.Drawing.Point(168, 231);
            this.appFontLabel1.Name = "appFontLabel1";
            this.appFontLabel1.Size = new System.Drawing.Size(158, 16);
            this.appFontLabel1.TabIndex = 4;
            this.appFontLabel1.Text = "Pour quel évènement ?";
            // 
            // lblNouvelleDepense
            // 
            this.lblNouvelleDepense.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblNouvelleDepense.AppFontHeight = 35F;
            this.lblNouvelleDepense.AutoSize = true;
            this.lblNouvelleDepense.IsBold = true;
            this.lblNouvelleDepense.Location = new System.Drawing.Point(161, 133);
            this.lblNouvelleDepense.Name = "lblNouvelleDepense";
            this.lblNouvelleDepense.Size = new System.Drawing.Size(411, 59);
            this.lblNouvelleDepense.TabIndex = 2;
            this.lblNouvelleDepense.Text = "Nouvelle dépense";
            // 
            // AjNouvelleDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appFontLabel8);
            this.Controls.Add(this.lblAnnuler);
            this.Controls.Add(this.appFontLabel6);
            this.Controls.Add(this.cboPayePar);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.appFontLabel2);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.lblNouvelleDepense);
            this.Name = "AjNouvelleDepense";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.AjNouvelleDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblNouvelleDepense;
        private System.Windows.Forms.ComboBox cboEvenements;
        private UI.AppFontLabel appFontLabel1;
        private UI.AppFontLabel appFontLabel2;
        private UI.AppFontLabel lblAmount;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.DateTimePicker dtp;
        private UI.AppFontLabel lblDate;
        private UI.AppFontLabel appFontLabel6;
        private System.Windows.Forms.ComboBox cboPayePar;
        private UI.AppFontLabel lblAnnuler;
        private UI.AppFontLabel appFontLabel8;
    }
}
