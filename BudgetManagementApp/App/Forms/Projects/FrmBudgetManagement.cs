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

        #region Incomes
        

        private void BtnNewIncome_Click(object sender, EventArgs e)
        {

        }

        private void BtnModifyIncome_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteIncome_Click(object sender, EventArgs e)
        {

        }

        private void TxtIncomeFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvIncomes_SelectionChanged(object sender, EventArgs e)
        {

        }
        

        #endregion

        #region Expenses

        private void BtnNewExpense_Click(object sender, EventArgs e)
        {

        }

        private void BtnModifyExpense_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteExpense_Click(object sender, EventArgs e)
        {

        }

        private void TxtExpenseFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvExpenses_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}