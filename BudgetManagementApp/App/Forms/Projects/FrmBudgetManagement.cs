using System;
using BudgetManagementApp.Forms.Base;

namespace BudgetManagementApp.Forms.Projects
{
    public partial class FrmBudgetManagement : BaseForm
    {
        public FrmBudgetManagement()
        {
            InitializeComponent();
        }

        private void FrmBudgetManagement_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        protected override void SetLabels()
        {
            LoopControlsToSetLabels(Controls);
        }
    }
}