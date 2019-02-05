//
// CTA Ridership Analysis.
//
// Alex Viznytsya
// Fall 2017
//

using System;
using System.Windows.Forms;

namespace CTA_Analysis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
