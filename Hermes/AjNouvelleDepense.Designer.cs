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
            this.appFontLabel6 = new Hermes.UI.AppFontLabel();
            this.lblDate = new Hermes.UI.AppFontLabel();
            this.lblAmount = new Hermes.UI.AppFontLabel();
            this.appFontLabel2 = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblNouvelleDepense = new Hermes.UI.AppFontLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
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
            // appFontLabel6
            // 
            this.appFontLabel6.AppFont = Hermes.AppFont.HelveticaNeue;
            this.appFontLabel6.AppFontHeight = 10F;
            this.appFontLabel6.AutoSize = true;
            this.appFontLabel6.Location = new System.Drawing.Point(476, 312);
            this.appFontLabel6.Name = "appFontLabel6";
            this.appFontLabel6.Size = new System.Drawing.Size(85, 16);
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
            this.lblDate.Size = new System.Drawing.Size(132, 16);
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
            this.lblAmount.Size = new System.Drawing.Size(154, 16);
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
            this.appFontLabel2.Size = new System.Drawing.Size(174, 16);
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
            this.appFontLabel1.Size = new System.Drawing.Size(156, 16);
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(670, 556);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinue.Location = new System.Drawing.Point(781, 556);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(105, 30);
            this.btnContinue.TabIndex = 17;
            this.btnContinue.Text = "Continuer";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // AjNouvelleDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCancel);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
    }
}
