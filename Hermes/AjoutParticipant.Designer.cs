namespace Hermes
{
    partial class AjoutParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutParticipant));
            this.lblIconeAjoutParticipant = new Hermes.UI.AppFontLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIconeAjoutParticipant
            // 
            this.lblIconeAjoutParticipant.AppFont = Hermes.AppFont.Icons;
            this.lblIconeAjoutParticipant.AppFontHeight = 40F;
            this.lblIconeAjoutParticipant.AutoSize = true;
            this.lblIconeAjoutParticipant.Location = new System.Drawing.Point(162, 62);
            this.lblIconeAjoutParticipant.Name = "lblIconeAjoutParticipant";
            this.lblIconeAjoutParticipant.Size = new System.Drawing.Size(58, 55);
            this.lblIconeAjoutParticipant.TabIndex = 1;
            this.lblIconeAjoutParticipant.Text = "O";
            this.lblIconeAjoutParticipant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblIconeAjoutParticipant_MouseClick);
            this.lblIconeAjoutParticipant.MouseEnter += new System.EventHandler(this.lblIconeAjoutParticipant_MouseEnter);
            this.lblIconeAjoutParticipant.MouseLeave += new System.EventHandler(this.LblIconeAjoutParticipant_MouseLeave);
            this.lblIconeAjoutParticipant.MouseHover += new System.EventHandler(this.LblIconeAjoutParticipant_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 177);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AjoutParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIconeAjoutParticipant);
            this.Name = "AjoutParticipant";
            this.Size = new System.Drawing.Size(378, 177);
            this.Load += new System.EventHandler(this.AjoutParticipant_Load);
            this.MouseEnter += new System.EventHandler(this.AjoutParticipant_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AjoutParticipant_MouseLeave);
            this.MouseHover += new System.EventHandler(this.AjoutParticipant_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel lblIconeAjoutParticipant;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
