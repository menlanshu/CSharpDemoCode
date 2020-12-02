using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSelfDemo
{
    static class Program
    {
        // Design
        // Form - Front
        // Main Form
        // Left part - Current count remain amount
        // Right part - All transaction for two account with listbox
        // Consum Form
        // Add a box for amount key in
        // Add a button for consum
        // Add a label for Overdraft showing
        // Model - Design - End
        // Two model
        // Account Model
        // Transaction Model
        // How to update model?

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainDashboardForm());
        }
    }
}
