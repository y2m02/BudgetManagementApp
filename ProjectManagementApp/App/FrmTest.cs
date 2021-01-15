using System;
using System.Windows.Forms;
using ProjectManagementApp.Services.Services;

namespace ProjectManagementApp.App
{
    public partial class FrmTest : Form
    {
        private readonly ITestService testService;

        public FrmTest(ITestService testService)
        {
            InitializeComponent();
            this.testService = testService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(testService.GetMessage());
        }
    }
}
