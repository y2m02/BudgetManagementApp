using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetManagementApp.Services.Services;

namespace BudgetManagementApp.Test
{
    public partial class FrmTest : Form
    {
        private readonly ITestService testService;

        public FrmTest(ITestService testService)
        {
            InitializeComponent();
            this.testService = testService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var a = await testService.GetMessage();
            MessageBox.Show(a);
        }
    }
}
