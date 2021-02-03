using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Services.Services.AccountingMovements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManagementApp.Forms.Projects
{
    public partial class FrmBudgetManagement : BaseForm
    {
        private readonly IAccountingMovementService accountingMovementService;

        public FrmBudgetManagement(IAccountingMovementService accountingMovementService)
        {
            InitializeComponent();

            this.accountingMovementService = accountingMovementService;
        }

        private List<AccountingMovementViewModel> Incomes { get; set; }

        private List<AccountingMovementViewModel> Expenses { get; set; }

        public void SetupData(IEnumerable<AccountingMovementViewModel> model)
        {
            SetupIncomes(model);
        }

        protected override void SetLabels()
        {
            LoopControlsToSetLabels(Controls);
        }

        private void FrmBudgetManagement_Load(object sender, EventArgs e)
        {
            SetLabels();

            SetColumnNames(DgvIncomes, new Dictionary<string, string>
            {
                [FieldNames.CategoryDescription] = StringResourcesHandler.GetString(FieldNames.Category),
                [FieldNames.TypeDescription] = StringResourcesHandler.GetString(FieldNames.Type),
                [FieldNames.SubTypeDescription] = StringResourcesHandler.GetString(FieldNames.SubType),
                [FieldNames.Date] = StringResourcesHandler.GetString(FieldNames.Date),
                [FieldNames.Amount] = StringResourcesHandler.GetString(FieldNames.Amount),
                [FieldNames.Comment] = StringResourcesHandler.GetString(FieldNames.Comment),
            });
        }

        #region Incomes

        private void SetupIncomes(IEnumerable<AccountingMovementViewModel> model)
        {
            Incomes = model.GetIncomes();

            PopulateGrid(
                DgvIncomes,
                Incomes,
                FormatGrid,
                new List<string>
                {
                    FieldNames.AccountingMovementId,
                    FieldNames.CategoryId,
                    FieldNames.TypeId,
                    FieldNames.SubTypeId,
                    FieldNames.ProjectId,
                    FieldNames.ProjectName,
                    FieldNames.IsAnIncome,
                }
            );
        }

        //private void FillIncomeFields(DataGridViewRow row)
        //{
        //    TxtIncomeId.Text = row.Value<int>(FieldNames.AccountingMovementId).ToString();
        //}

        private void HandleIncomeMaintenance(MaintenanceType type)
        {
            InitializeCategoryMaintenanceControls(type);

            //if (!categoryMaintenance.ShowDialog().IsOkResponse())
            //    return;

            TxtIncomeFilter.Clear();

            HandleEntity<AccountingMovementViewModel>(
                accountingMovementService.GetIncomes(),
                SetupIncomes
            );
        }

        private void InitializeCategoryMaintenanceControls(MaintenanceType type)
        {
            //switch (type)
            //{
            //    case MaintenanceType.CreateNew:
            //        categoryMaintenance.Text = StringResources.Add.Format(StringResources.Category);
            //        categoryMaintenance.TxtCategoryId.Clear();
            //        categoryMaintenance.TxtDescription.Clear();
            //        break;

            //    case MaintenanceType.Modify:
            //        categoryMaintenance.Text = StringResources.Modify.Format(StringResources.Category);
            //        categoryMaintenance.TxtCategoryId.Text = TxtCategoryId.Text;
            //        categoryMaintenance.TxtDescription.Text = TxtCategoryDescription.Text;
            //        break;
            //}
        }

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
            SetDetailsData(
                DgvIncomes,
                BtnModifyIncome,
                BtnDeleteIncome,
                row => TxtIncomeId.Text = row.Value<int>(FieldNames.AccountingMovementId).ToString()
            );
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