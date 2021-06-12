using Hermes.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // High-DPI support for modern Windows versions.
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Preload required resources for the application.
            FontManager.PreloadFontFamilies();

            // Setup database location.
            if (args.Length == 2)
            {
                // If passed as an argument (for example, on a drag-and-drop or by passing manually), use it.
                if (!File.Exists(args[1]))
                {
                    MessageBox.Show(
                        "Impossible d'accéder à la base de données donnée !\n"
                        + "Veuillez vérifier qu'une base de données existe et qu'elle soit bien accessible.",
                        "Hermès", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Database.SetDatabasePath(args[1]);
            }
            else
            {
                const string defaultName = "bdEvents.mdb";

                // Try using the one in the current directory.
                string path = Path.Combine(Directory.GetCurrentDirectory(), defaultName);

                // Otherwise, try using the one in the application folder.
                if (!File.Exists(path))
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, defaultName);

#if DEBUG
                // If we compile as Debug, we can also look a bit upwards based on our project structure.
                if (!File.Exists(path))
                    path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..", defaultName);
#endif

                // Can't really do much here !
                if (!File.Exists(path))
                {
                    MessageBox.Show(
                        "Impossible d'accéder à la base de données !\n"
                        + "Veuillez vérifier qu'une base de données existe et soit accessible depuis le dossier de l'application.\n"
                        + "Vous pouvez aussi en glisser-déposer une sur l'application.", "Hermès", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Database.SetDatabasePath(path);
            }

            Application.Run(new MainForm());
        }
    }
}
