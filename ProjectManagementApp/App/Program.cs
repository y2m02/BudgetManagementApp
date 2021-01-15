using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagementApp.App.CompositionRoot;

namespace ProjectManagementApp.App
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
