using System;
using System.Windows.Forms;

namespace BudgetManagementApp.App
{
    public partial class FrmMain : Form
    {
        private readonly FrmTest frmTest;

        public FrmMain(FrmTest frmTest)
        {
            InitializeComponent();
            this.frmTest = frmTest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTest.ShowDialog();
        }
    }
}
