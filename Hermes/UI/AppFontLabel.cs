using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Hermes.UI
{
    public class AppFontLabel : Label
    {
        private Font m_Font = new Font("Helvetica Neue", 7);

        private AppFont m_AppFont = AppFont.HelveticaNeue;
        private float m_AppFontHeight = 12f;
        private bool m_IsBold = false, m_IsItalic = false,
            m_IsUnderline = false, m_IsStrikeout = false;

        [Browsable(true)]
        [Category("Hermes"), Description("Police interne à l'application qui doit être utilisée")]
        [DefaultValue(AppFont.Invalid)]
        public AppFont AppFont
        {
            get => this.m_AppFont;
            set
            {
                this.m_AppFont = value;
                this.UpdateFont();
            }
        }

        [Browsable(true)]
        [Category("Hermes"), Description("Taille de la police (em)")]
        [DefaultValue(7)]
        public float AppFontHeight
        {
            get => this.m_AppFontHeight;
            set
            {
                this.m_AppFontHeight = value;
                this.UpdateFont();
            }
        }

        [Browsable(true)]
        [Category("Hermes"), Description("Utiliser une police en gras")]
        [DefaultValue(false)]
        public bool IsBold
        {
            get => this.m_IsBold;
            set
            {
                this.m_IsBold = value;
                this.UpdateFont();
            }
        }

        [Browsable(true)]
        [Category("Hermes"), Description("Utiliser une police en italique")]
        [DefaultValue(false)]
        public bool IsItalic
        {
            get => this.m_IsItalic;
            set
            {
                this.m_IsItalic = value;
                this.UpdateFont();
            }
        }

        [Browsable(true)]
        [Category("Hermes"), Description("Utiliser une police soulignée")]
        [DefaultValue(false)]
        public bool IsUnderline
        {
            get => this.m_IsUnderline;
            set
            {
                this.m_IsUnderline = value;
                this.UpdateFont();
            }
        }

        [Browsable(true)]
        [Category("Hermes"), Description("Utiliser une police barrée")]
        [DefaultValue(false)]
        public bool IsStrikeout
        {
            get => this.m_IsStrikeout;
            set
            {
                this.m_IsStrikeout = value;
                this.UpdateFont();
            }
        }

        public override Font Font
        {
            get => m_Font;
        }

        private void UpdateFont()
        {
            FontStyle style = FontStyle.Regular;
            if (this.IsBold) style |= FontStyle.Bold;
            if (this.IsItalic) style |= FontStyle.Italic;
            if (this.IsUnderline) style |= FontStyle.Underline;
            if (this.IsStrikeout) style |= FontStyle.Strikeout;

            this.m_Font = new Font(
                FontManager.GetFontFamily(this.AppFont),
                this.AppFontHeight, style);

            // Required to render non-system fonts. Breaks ClearType, though...
            //this.UseCompatibleTextRendering = true;
        }
    }
}
