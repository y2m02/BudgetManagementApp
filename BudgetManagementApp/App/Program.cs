using System;
using System.Windows.Forms;
using BudgetManagementApp.App.CompositionRoot;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetManagementApp.App
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(
                ServiceResolver
                    .GetServiceProvider()
                    .GetRequiredService<FrmMain>()
            );
        }
    }
}
