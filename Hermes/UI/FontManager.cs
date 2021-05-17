using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Hermes
{
    public enum AppFont
    {
        Invalid,
        HelveticaNeue,
        HelveticaNeue_Light,
        HelveticaNeue_Medium,
        HelveticaNeue_Bold,
        Icons,
    }

    public static class FontManager
    {
        // Associate each enum element to a file (represented as a byte array here).
        // Used for pre-loading fonts in memory.
        private static Dictionary<AppFont, byte[]> fontDataPairs = new Dictionary<AppFont, byte[]>
        {
            { AppFont.HelveticaNeue, Resources.Fonts.HelveticaNeue },
            { AppFont.HelveticaNeue_Light, Resources.Fonts.HelveticaNeue_Light },
            { AppFont.HelveticaNeue_Medium, Resources.Fonts.HelveticaNeue_Medium },
            { AppFont.HelveticaNeue_Bold, Resources.Fonts.HelveticaNeue_Bold },
            { AppFont.Icons, Resources.Fonts.Icons },
        };

        private static Dictionary<AppFont, FontFamily> fontCache = new Dictionary<AppFont, FontFamily>();

        // Based on the signature declared here https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-addfontmemresourceex
        /// <summary>
        /// Installs a font based on a memory region. Not to be called directly by the rest of the application,
        /// but to be managed from within this class.
        /// </summary>
        /// <param name="pFileView">Pointer to the file data for the font.</param>
        /// <param name="cjSize">Size of the data given.</param>
        /// <param name="pvResrved">Reserved.</param>
        /// <param name="pNumFonts">Number of fonts loaded from the file.</param>
        /// <returns>A font handle for the loaded font.</returns>
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pFileView, uint cjSize,
            IntPtr pvResrved, [In] ref uint pNumFonts);

        private static FontFamily LoadFontFromData(byte[] fontData)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();

            // Allocate memory region to copy the font data into, then copy it.
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            
            // For GDI+ (which Windows.Forms uses in CompatibleTextRendering).
            fontCollection.AddMemoryFont(fontPtr, fontData.Length);

            // Install the font from memory, using the GDI+ API.
            uint ignored = 0; // Ignored, an output of the called method, but we have to pass a pointer.
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref ignored);
            
            // Free the previously allocated memory region.
            Marshal.FreeCoTaskMem(fontPtr);

            // This font can be used for labels that use CompatibleTextRendering,
            // which switches to GDI text rendering instead of GDI+ accelerated text rendering.
            return fontCollection.Families[0];
        }

        /// <summary>
        /// Returns the queried font family. If necessary, loads the font in the 
        /// font cache, and installs it in the GDI+ API for Windows.Forms usage.
        /// </summary>
        /// <param name="font">The wanted font family.</param>
        /// <returns>The queried FontFamily for direct usage.</returns>
        public static FontFamily GetFontFamily(AppFont font)
        {
            if (!fontCache.ContainsKey(font))
            {
                FontFamily f = LoadFontFromData(fontDataPairs[font]);
                fontCache[font] = f;
            }

            return fontCache[font];
        }

        /// <summary>
        /// Preloads all fonts in the font cache. Additionally, loaded fonts are installed in the
        /// GDI+ API, which is used by Windows.Forms.
        /// </summary>
        public static void PreloadFontFamilies()
        {
            foreach (AppFont f in fontDataPairs.Keys)
                GetFontFamily(f);
        }
    }
}
