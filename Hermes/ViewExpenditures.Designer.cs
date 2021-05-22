namespace Hermes
{
    partial class ViewExpenditures
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
            this.pnlListExpenditure = new System.Windows.Forms.Panel();
            this.cboEvenement = new System.Windows.Forms.ComboBox();
            this.pnlDetailExpenditure = new System.Windows.Forms.Panel();
            this.btnAddExpenditure = new System.Windows.Forms.Button();
            this.btnAddBeneficiary = new System.Windows.Forms.Button();
            this.pnlBeneficiary = new System.Windows.Forms.Panel();
            this.lblDepense = new Hermes.UI.AppFontLabel();
            this.lblExpenditureTitle = new Hermes.UI.AppFontLabel();
            this.lblCreator = new Hermes.UI.AppFontLabel();
            this.lblMoney = new Hermes.UI.AppFontLabel();
            this.lblBeneficiary = new Hermes.UI.AppFontLabel();
            this.lblIconCreator = new Hermes.UI.AppFontLabel();
            this.lblIconMoney = new Hermes.UI.AppFontLabel();
            this.pnlDetailExpenditure.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListExpenditure
            // 
            this.pnlListExpenditure.Location = new System.Drawing.Point(118, 135);
            this.pnlListExpenditure.Name = "pnlListExpenditure";
            this.pnlListExpenditure.Size = new System.Drawing.Size(374, 332);
            this.pnlListExpenditure.TabIndex = 0;
            // 
            // cboEvenement
            // 
            this.cboEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenement.FormattingEnabled = true;
            this.cboEvenement.Location = new System.Drawing.Point(164, 78);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.Size = new System.Drawing.Size(186, 21);
            this.cboEvenement.TabIndex = 2;
            // 
            // pnlDetailExpenditure
            // 
            this.pnlDetailExpenditure.Controls.Add(this.lblExpenditureTitle);
            this.pnlDetailExpenditure.Controls.Add(this.pnlBeneficiary);
            this.pnlDetailExpenditure.Controls.Add(this.lblCreator);
            this.pnlDetailExpenditure.Controls.Add(this.lblMoney);
            this.pnlDetailExpenditure.Controls.Add(this.lblBeneficiary);
            this.pnlDetailExpenditure.Controls.Add(this.lblIconCreator);
            this.pnlDetailExpenditure.Controls.Add(this.lblIconMoney);
            this.pnlDetailExpenditure.Location = new System.Drawing.Point(553, 63);
            this.pnlDetailExpenditure.Name = "pnlDetailExpenditure";
            this.pnlDetailExpenditure.Size = new System.Drawing.Size(374, 404);
            this.pnlDetailExpenditure.TabIndex = 0;
            // 
            // btnAddExpenditure
            // 
            this.btnAddExpenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnAddExpenditure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpenditure.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddExpenditure.Location = new System.Drawing.Point(118, 483);
            this.btnAddExpenditure.Name = "btnAddExpenditure";
            this.btnAddExpenditure.Size = new System.Drawing.Size(374, 30);
            this.btnAddExpenditure.TabIndex = 3;
            this.btnAddExpenditure.Text = "Ajouter une dépenses à cet évènement";
            this.btnAddExpenditure.UseVisualStyleBackColor = false;
            // 
            // btnAddBeneficiary
            // 
            this.btnAddBeneficiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.btnAddBeneficiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBeneficiary.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBeneficiary.Location = new System.Drawing.Point(553, 483);
            this.btnAddBeneficiary.Name = "btnAddBeneficiary";
            this.btnAddBeneficiary.Size = new System.Drawing.Size(374, 30);
            this.btnAddBeneficiary.TabIndex = 3;
            this.btnAddBeneficiary.Text = "Ajout d\'un bénéficiaire";
            this.btnAddBeneficiary.UseVisualStyleBackColor = false;
            // 
            // pnlBeneficiary
            // 
            this.pnlBeneficiary.Location = new System.Drawing.Point(40, 261);
            this.pnlBeneficiary.Name = "pnlBeneficiary";
            this.pnlBeneficiary.Size = new System.Drawing.Size(306, 129);
            this.pnlBeneficiary.TabIndex = 2;
            // 
            // lblDepense
            // 
            this.lblDepense.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblDepense.AppFontHeight = 12F;
            this.lblDepense.AutoSize = true;
            this.lblDepense.Location = new System.Drawing.Point(53, 47);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(128, 19);
            this.lblDepense.TabIndex = 1;
            this.lblDepense.Text = "Dépenses dans :";
            // 
            // lblExpenditureTitle
            // 
            this.lblExpenditureTitle.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.lblExpenditureTitle.AppFontHeight = 25F;
            this.lblExpenditureTitle.AutoSize = true;
            this.lblExpenditureTitle.Location = new System.Drawing.Point(18, 15);
            this.lblExpenditureTitle.Name = "lblExpenditureTitle";
            this.lblExpenditureTitle.Size = new System.Drawing.Size(257, 42);
            this.lblExpenditureTitle.TabIndex = 3;
            this.lblExpenditureTitle.Text = "appFontLabel1";
            // 
            // lblCreator
            // 
            this.lblCreator.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblCreator.AppFontHeight = 15F;
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(107, 161);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(130, 23);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "CreatorName";
            // 
            // lblMoney
            // 
            this.lblMoney.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblMoney.AppFontHeight = 15F;
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(107, 104);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(90, 23);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Amount€";
            // 
            // lblBeneficiary
            // 
            this.lblBeneficiary.AppFont = Hermes.AppFont.HelveticaNeue;
            this.lblBeneficiary.AppFontHeight = 15F;
            this.lblBeneficiary.AutoSize = true;
            this.lblBeneficiary.Location = new System.Drawing.Point(21, 224);
            this.lblBeneficiary.Name = "lblBeneficiary";
            this.lblBeneficiary.Size = new System.Drawing.Size(127, 23);
            this.lblBeneficiary.TabIndex = 1;
            this.lblBeneficiary.Text = "Bénéficiaire :";
            // 
            // lblIconCreator
            // 
            this.lblIconCreator.AppFont = Hermes.AppFont.Icons;
            this.lblIconCreator.AppFontHeight = 40F;
            this.lblIconCreator.AutoSize = true;
            this.lblIconCreator.Location = new System.Drawing.Point(30, 145);
            this.lblIconCreator.Name = "lblIconCreator";
            this.lblIconCreator.Size = new System.Drawing.Size(58, 55);
            this.lblIconCreator.TabIndex = 0;
            this.lblIconCreator.Text = "O";
            // 
            // lblIconMoney
            // 
            this.lblIconMoney.AppFont = Hermes.AppFont.Icons;
            this.lblIconMoney.AppFontHeight = 40F;
            this.lblIconMoney.AutoSize = true;
            this.lblIconMoney.Location = new System.Drawing.Point(30, 87);
            this.lblIconMoney.Name = "lblIconMoney";
            this.lblIconMoney.Size = new System.Drawing.Size(58, 55);
            this.lblIconMoney.TabIndex = 0;
            this.lblIconMoney.Text = "O";
            // 
            // ViewExpenditures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddBeneficiary);
            this.Controls.Add(this.btnAddExpenditure);
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.lblDepense);
            this.Controls.Add(this.pnlDetailExpenditure);
            this.Controls.Add(this.pnlListExpenditure);
            this.Name = "ViewExpenditures";
            this.Size = new System.Drawing.Size(1064, 640);
            this.Load += new System.EventHandler(this.ViewExpenditures_Load);
            this.pnlDetailExpenditure.ResumeLayout(false);
            this.pnlDetailExpenditure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlListExpenditure;
        private UI.AppFontLabel lblDepense;
        private System.Windows.Forms.ComboBox cboEvenement;
        private System.Windows.Forms.Panel pnlDetailExpenditure;
        private System.Windows.Forms.Button btnAddExpenditure;
        private System.Windows.Forms.Button btnAddBeneficiary;
        private UI.AppFontLabel lblIconMoney;
        private UI.AppFontLabel lblBeneficiary;
        private UI.AppFontLabel lblIconCreator;
        private System.Windows.Forms.Panel pnlBeneficiary;
        private UI.AppFontLabel lblCreator;
        private UI.AppFontLabel lblMoney;
        private UI.AppFontLabel lblExpenditureTitle;
    }
}
