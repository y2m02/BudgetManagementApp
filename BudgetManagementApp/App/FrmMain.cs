using System;
using System.Globalization;
using System.Windows.Forms;
using BudgetManagementApp.Properties;
using BudgetManagementApp.Test;

namespace BudgetManagementApp
{
    public partial class FrmMain : BaseForm
    {
        private readonly FrmTest frmTest;

        public FrmMain(FrmTest frmTest)
        {
            InitializeComponent();
            this.frmTest = frmTest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringResources.Culture = CultureInfo.CurrentCulture;

            DisplayInformationMessage("wawawa");

            //frmTest.ShowDialog();
        }
    }
}
