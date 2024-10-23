using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheSampleGuessingGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the analyzer selection form first
            using (var analyzerForm = new AnalyzerSelectionGUI())
            {
                if (analyzerForm.ShowDialog() == DialogResult.OK)
                {
                    // Create and run the main game GUI with the selected analyzer type
                    Application.Run(new GameGUI(analyzerForm.SelectedAnalyzerType));
                }
            }

        }
    }
}
