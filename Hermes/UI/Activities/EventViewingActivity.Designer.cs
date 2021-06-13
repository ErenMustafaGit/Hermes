﻿
namespace Hermes.UI.Activities
{
    partial class EventViewingActivity
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEvenementInfo = new System.Windows.Forms.Panel();
            this.invitedPanel = new System.Windows.Forms.Panel();
            this.backTextLabel = new Hermes.UI.AppFontLabel();
            this.backArrowLabel = new Hermes.UI.AppFontLabel();
            this.previousItemLabel = new Hermes.UI.AppFontLabel();
            this.firstItemLabel = new Hermes.UI.AppFontLabel();
            this.lastItemLabel = new Hermes.UI.AppFontLabel();
            this.appFontLabel1 = new Hermes.UI.AppFontLabel();
            this.lblMax = new Hermes.UI.AppFontLabel();
            this.lblCurrentPosition = new Hermes.UI.AppFontLabel();
            this.nextItemLabel = new Hermes.UI.AppFontLabel();
            this.completedIconLabel = new Hermes.UI.AppFontLabel();
            this.completedTextLabel = new Hermes.UI.AppFontLabel();
            this.dateEndLabel = new Hermes.UI.AppFontLabel();
            this.dateToLabel = new Hermes.UI.AppFontLabel();
            this.dateBeginLabel = new Hermes.UI.AppFontLabel();
            this.calendarIconLabel = new Hermes.UI.AppFontLabel();
            this.descriptionLabel = new Hermes.UI.AppFontLabel();
            this.eventNameLabel = new Hermes.UI.AppFontLabel();
            this.pnlEvenementInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEvenementInfo
            // 
            this.pnlEvenementInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.pnlEvenementInfo.Controls.Add(this.descriptionLabel);
            this.pnlEvenementInfo.Controls.Add(this.eventNameLabel);
            this.pnlEvenementInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlEvenementInfo.Name = "pnlEvenementInfo";
            this.pnlEvenementInfo.Size = new System.Drawing.Size(1064, 270);
            this.pnlEvenementInfo.TabIndex = 3;
            // 
            // invitedPanel
            // 
            this.invitedPanel.Location = new System.Drawing.Point(586, 276);
            this.invitedPanel.Name = "invitedPanel";
            this.invitedPanel.Size = new System.Drawing.Size(369, 364);
            this.invitedPanel.TabIndex = 12;
            // 
            // backTextLabel
            // 
            this.backTextLabel.AppFont = Hermes.AppFont.HelveticaNeue;
            this.backTextLabel.AppFontHeight = 9F;
            this.backTextLabel.AutoSize = true;
            this.backTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.backTextLabel.Location = new System.Drawing.Point(49, 597);
            this.backTextLabel.Name = "backTextLabel";
            this.backTextLabel.Size = new System.Drawing.Size(72, 14);
            this.backTextLabel.TabIndex = 22;
            this.backTextLabel.Text = "Vue globale";
            this.backTextLabel.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.backTextLabel.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.backTextLabel.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // backArrowLabel
            // 
            this.backArrowLabel.AppFont = Hermes.AppFont.Icons;
            this.backArrowLabel.AppFontHeight = 20F;
            this.backArrowLabel.AutoSize = true;
            this.backArrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(248)))));
            this.backArrowLabel.Location = new System.Drawing.Point(24, 589);
            this.backArrowLabel.Name = "backArrowLabel";
            this.backArrowLabel.Size = new System.Drawing.Size(29, 27);
            this.backArrowLabel.TabIndex = 20;
            this.backArrowLabel.Text = "O";
            this.backArrowLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backArrowLabel.Click += new System.EventHandler(this.lblGoBaaack_Click);
            this.backArrowLabel.MouseEnter += new System.EventHandler(this.lblGoBaaack_MouseEnter);
            this.backArrowLabel.MouseLeave += new System.EventHandler(this.lblGoBaaack_MouseLeave);
            // 
            // previousItemLabel
            // 
            this.previousItemLabel.AppFont = Hermes.AppFont.Icons;
            this.previousItemLabel.AppFontHeight = 22F;
            this.previousItemLabel.AutoSize = true;
            this.previousItemLabel.Location = new System.Drawing.Point(392, 588);
            this.previousItemLabel.Name = "previousItemLabel";
            this.previousItemLabel.Size = new System.Drawing.Size(26, 31);
            this.previousItemLabel.TabIndex = 19;
            this.previousItemLabel.Text = "x";
            this.previousItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.previousItemLabel.Click += new System.EventHandler(this.LblGauche_Click);
            this.previousItemLabel.MouseLeave += new System.EventHandler(this.LblGauche_MouseLeave);
            this.previousItemLabel.MouseHover += new System.EventHandler(this.LblGauche_MouseHover);
            // 
            // firstItemLabel
            // 
            this.firstItemLabel.AppFont = Hermes.AppFont.Icons;
            this.firstItemLabel.AppFontHeight = 22F;
            this.firstItemLabel.AutoSize = true;
            this.firstItemLabel.Location = new System.Drawing.Point(366, 588);
            this.firstItemLabel.Name = "firstItemLabel";
            this.firstItemLabel.Size = new System.Drawing.Size(26, 31);
            this.firstItemLabel.TabIndex = 18;
            this.firstItemLabel.Text = "x";
            this.firstItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.firstItemLabel.Click += new System.EventHandler(this.LblGaucheGauche_Click);
            this.firstItemLabel.MouseLeave += new System.EventHandler(this.LblGaucheGauche_MouseLeave);
            this.firstItemLabel.MouseHover += new System.EventHandler(this.LblGaucheGauche_MouseHover);
            // 
            // lastItemLabel
            // 
            this.lastItemLabel.AppFont = Hermes.AppFont.Icons;
            this.lastItemLabel.AppFontHeight = 22F;
            this.lastItemLabel.AutoSize = true;
            this.lastItemLabel.Location = new System.Drawing.Point(525, 588);
            this.lastItemLabel.Name = "lastItemLabel";
            this.lastItemLabel.Size = new System.Drawing.Size(26, 31);
            this.lastItemLabel.TabIndex = 17;
            this.lastItemLabel.Text = "x";
            this.lastItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lastItemLabel.Click += new System.EventHandler(this.LblIconeDroiteDroite_Click);
            this.lastItemLabel.MouseLeave += new System.EventHandler(this.LblIconeDroiteDroite_MouseLeave);
            this.lastItemLabel.MouseHover += new System.EventHandler(this.LblIconeDroiteDroite_MouseHover);
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
            // nextItemLabel
            // 
            this.nextItemLabel.AppFont = Hermes.AppFont.Icons;
            this.nextItemLabel.AppFontHeight = 22F;
            this.nextItemLabel.AutoSize = true;
            this.nextItemLabel.Location = new System.Drawing.Point(501, 588);
            this.nextItemLabel.Name = "nextItemLabel";
            this.nextItemLabel.Size = new System.Drawing.Size(26, 31);
            this.nextItemLabel.TabIndex = 13;
            this.nextItemLabel.Text = "x";
            this.nextItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextItemLabel.Click += new System.EventHandler(this.LblIconeDroite_Click);
            this.nextItemLabel.MouseLeave += new System.EventHandler(this.LblIconeDroite_MouseLeave);
            this.nextItemLabel.MouseHover += new System.EventHandler(this.LblIconeDroite_MouseHover);
            // 
            // completedIconLabel
            // 
            this.completedIconLabel.AppFont = Hermes.AppFont.Icons;
            this.completedIconLabel.AppFontHeight = 37F;
            this.completedIconLabel.AutoSize = true;
            this.completedIconLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.completedIconLabel.Location = new System.Drawing.Point(94, 460);
            this.completedIconLabel.Name = "completedIconLabel";
            this.completedIconLabel.Size = new System.Drawing.Size(43, 51);
            this.completedIconLabel.TabIndex = 11;
            this.completedIconLabel.Text = "x";
            this.completedIconLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // completedTextLabel
            // 
            this.completedTextLabel.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.completedTextLabel.AppFontHeight = 37F;
            this.completedTextLabel.AutoSize = true;
            this.completedTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.completedTextLabel.Location = new System.Drawing.Point(168, 454);
            this.completedTextLabel.Name = "completedTextLabel";
            this.completedTextLabel.Size = new System.Drawing.Size(159, 62);
            this.completedTextLabel.TabIndex = 5;
            this.completedTextLabel.Text = "Soldé";
            // 
            // dateEndLabel
            // 
            this.dateEndLabel.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.dateEndLabel.AppFontHeight = 18F;
            this.dateEndLabel.AutoSize = true;
            this.dateEndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dateEndLabel.Location = new System.Drawing.Point(208, 376);
            this.dateEndLabel.Name = "dateEndLabel";
            this.dateEndLabel.Size = new System.Drawing.Size(222, 30);
            this.dateEndLabel.TabIndex = 10;
            this.dateEndLabel.Text = "31 décembre 2020";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AppFont = Hermes.AppFont.HelveticaNeue;
            this.dateToLabel.AppFontHeight = 18F;
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dateToLabel.Location = new System.Drawing.Point(174, 377);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(53, 28);
            this.dateToLabel.TabIndex = 9;
            this.dateToLabel.Text = "au :";
            // 
            // dateBeginLabel
            // 
            this.dateBeginLabel.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.dateBeginLabel.AppFontHeight = 18F;
            this.dateBeginLabel.AutoSize = true;
            this.dateBeginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dateBeginLabel.Location = new System.Drawing.Point(174, 350);
            this.dateBeginLabel.Name = "dateBeginLabel";
            this.dateBeginLabel.Size = new System.Drawing.Size(44, 30);
            this.dateBeginLabel.TabIndex = 8;
            this.dateBeginLabel.Text = "Du";
            // 
            // calendarIconLabel
            // 
            this.calendarIconLabel.AppFont = Hermes.AppFont.Icons;
            this.calendarIconLabel.AppFontHeight = 39F;
            this.calendarIconLabel.AutoSize = true;
            this.calendarIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.calendarIconLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.calendarIconLabel.Location = new System.Drawing.Point(95, 350);
            this.calendarIconLabel.Name = "calendarIconLabel";
            this.calendarIconLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calendarIconLabel.Size = new System.Drawing.Size(56, 52);
            this.calendarIconLabel.TabIndex = 6;
            this.calendarIconLabel.Text = "O";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AppFont = Hermes.AppFont.HelveticaNeue;
            this.descriptionLabel.AppFontHeight = 13F;
            this.descriptionLabel.AutoEllipsis = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.descriptionLabel.Location = new System.Drawing.Point(77, 184);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(609, 86);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Nom";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AppFont = Hermes.AppFont.HelveticaNeue_Bold;
            this.eventNameLabel.AppFontHeight = 40F;
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.eventNameLabel.Location = new System.Drawing.Point(70, 97);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(146, 67);
            this.eventNameLabel.TabIndex = 2;
            this.eventNameLabel.Text = "Nom";
            // 
            // EventViewingActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backTextLabel);
            this.Controls.Add(this.backArrowLabel);
            this.Controls.Add(this.previousItemLabel);
            this.Controls.Add(this.firstItemLabel);
            this.Controls.Add(this.lastItemLabel);
            this.Controls.Add(this.appFontLabel1);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblCurrentPosition);
            this.Controls.Add(this.nextItemLabel);
            this.Controls.Add(this.invitedPanel);
            this.Controls.Add(this.completedIconLabel);
            this.Controls.Add(this.completedTextLabel);
            this.Controls.Add(this.dateEndLabel);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.dateBeginLabel);
            this.Controls.Add(this.calendarIconLabel);
            this.Controls.Add(this.pnlEvenementInfo);
            this.Name = "EventViewingActivity";
            this.Size = new System.Drawing.Size(965, 640);
            this.Load += new System.EventHandler(this.EventViewingActivity_Load);
            this.pnlEvenementInfo.ResumeLayout(false);
            this.pnlEvenementInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.AppFontLabel eventNameLabel;
        private System.Windows.Forms.Panel pnlEvenementInfo;
        private UI.AppFontLabel descriptionLabel;
        private UI.AppFontLabel calendarIconLabel;
        private UI.AppFontLabel dateBeginLabel;
        private UI.AppFontLabel dateEndLabel;
        private UI.AppFontLabel dateToLabel;
        private UI.AppFontLabel completedTextLabel;
        private UI.AppFontLabel completedIconLabel;
        private System.Windows.Forms.Panel invitedPanel;
        private UI.AppFontLabel nextItemLabel;
        private UI.AppFontLabel lblCurrentPosition;
        private UI.AppFontLabel lblMax;
        private UI.AppFontLabel appFontLabel1;
        private UI.AppFontLabel lastItemLabel;
        private UI.AppFontLabel previousItemLabel;
        private UI.AppFontLabel firstItemLabel;
        private UI.AppFontLabel backArrowLabel;
        private UI.AppFontLabel backTextLabel;
    }
}
