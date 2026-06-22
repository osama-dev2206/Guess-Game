using System;
using System.Windows.Forms;

namespace Guess_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppContext.SetSwitch("Switch.System.Windows.Forms.UseLegacyAccessibilityFeatures.3", true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGameSettings());
        }
    }
}
