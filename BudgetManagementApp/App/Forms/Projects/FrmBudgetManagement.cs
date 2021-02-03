using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.AccountingMovements;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
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
        private readonly FrmAccountingMovementMaintenance accountMovementMaintenance;

        public FrmBudgetManagement(
            IAccountingMovementService accountingMovementService,
            FrmAccountingMovementMaintenance accountMovementMaintenance
        )
        {
            InitializeComponent();

            this.accountingMovementService = accountingMovementService;
            this.accountMovementMaintenance = accountMovementMaintenance;
        }

        private List<AccountingMovementViewModel> Incomes { get; set; }

        private List<AccountingMovementViewModel> Expenses { get; set; }

        public List<TypeViewModel> Types { get; set; }

        public List<SubTypeViewModel> SubTypes { get; set; }

        public void SetupData(IEnumerable<AccountingMovementViewModel> model)
        {
            SetupIncomes(model);
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

        private void HandleIncomeMaintenance(MaintenanceType type)
        {
            InitializeMaintenanceControls(type, AccountingMovementType.Income);

            if (!accountMovementMaintenance.ShowDialog().IsOkResponse())
                return;

            TxtIncomeFilter.Clear();

            HandleEntity<AccountingMovementViewModel>(
                accountingMovementService.GetIncomes(),
                SetupIncomes
            );

            GlobalProperties.ProjectsNeedToBeUpdated = true;
        }

        private void InitializeMaintenanceControls(
            MaintenanceType maintenanceType,
            AccountingMovementType movementType
        )
        {
            var isAnIncome = movementType == AccountingMovementType.Income;

            accountMovementMaintenance.IsAnIncome = isAnIncome;

            switch (maintenanceType)
            {
                case MaintenanceType.CreateNew:
                    accountMovementMaintenance.Text = StringResources.Add.Format(
                        isAnIncome ? StringResources.Income : StringResources.Expense
                    );
                    //accountMovementMaintenance.TxtCategoryId.Clear();
                    //accountMovementMaintenance.TxtDescription.Clear();
                    break;

                case MaintenanceType.Modify:
                    accountMovementMaintenance.Text = StringResources.Modify.Format(
                        isAnIncome ? StringResources.Income : StringResources.Expense
                    );
                    //accountMovementMaintenance.TxtCategoryId.Text = TxtCategoryId.Text;
                    //accountMovementMaintenance.TxtDescription.Text = TxtCategoryDescription.Text;
                    break;
            }
        }

        private void BtnNewIncome_Click(object sender, EventArgs e)
        {
            HandleIncomeMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnModifyIncome_Click(object sender, EventArgs e)
        {
            HandleIncomeMaintenance(MaintenanceType.Modify);
        }

        private void BtnDeleteIncome_Click(object sender, EventArgs e)
        {


            GlobalProperties.ProjectsNeedToBeUpdated = true;
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