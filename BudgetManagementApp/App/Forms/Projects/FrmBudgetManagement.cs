using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Projects;
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

namespace BudgetManagementApp.Forms.Projects
{
    public partial class FrmBudgetManagement : BaseForm
    {
        private readonly IAccountingMovementService accountingMovementService;
        private readonly FrmAccountingMovementMaintenance accountingMovementMaintenance;

        public FrmBudgetManagement(
            IAccountingMovementService accountingMovementService,
            FrmAccountingMovementMaintenance accountMovementMaintenance
        )
        {
            InitializeComponent();

            this.accountingMovementService = accountingMovementService;
            accountingMovementMaintenance = accountMovementMaintenance;
        }

        public ProjectViewModel Project { get; set; }

        public List<CategoryViewModel> Categories { get; set; }

        public List<TypeViewModel> Types { get; set; }

        public List<SubTypeViewModel> SubTypes { get; set; }

        private List<AccountingMovementViewModel> Incomes { get; set; }

        private List<AccountingMovementViewModel> Expenses { get; set; }

        public void SetupData(IEnumerable<AccountingMovementViewModel> model)
        {
            SetupIncomes(model);
        }

        private void FrmBudgetManagement_Load(object sender, EventArgs e)
        {
            SetLabels();

            TxtProjectId.SetText(Project.ProjectId.ToString());

            TxtProjectName.SetText(Project.Name);

            TxtStartDate.SetText(Project.StartDate.ToShortDateString());

            TxtEndDate.SetText(Project.EndDate.ToShortDateString());

            TxtConstruction.SetText(
                Project.Construction.ToStringWithDecimals()
            );

            TxtCost.SetText(
                Project.Cost.ToStringWithDecimals()
            );

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

            if (!accountingMovementMaintenance.ShowDialog().IsOkResponse())
                return;

            TxtIncomeFilter.Clear();

            HandleEntity<AccountingMovementViewModel>(
                accountingMovementService.GetIncomesByProjectId(Project.ProjectId),
                SetupIncomes
            );

            GlobalProperties.ProjectsNeedToBeUpdated = true;
        }

        private void InitializeMaintenanceControls(
            MaintenanceType maintenanceType,
            AccountingMovementType movementType
        )
        {
            accountingMovementMaintenance.Categories = Categories;
            accountingMovementMaintenance.Types = Types;
            accountingMovementMaintenance.SubTypes = SubTypes;


            var isAnIncome = movementType == AccountingMovementType.Income;


            switch (maintenanceType)
            {
                case MaintenanceType.CreateNew:
                    accountingMovementMaintenance.Text = StringResources.Add.Format(
                        isAnIncome ? StringResources.Income : StringResources.Expense
                    );

                    accountingMovementMaintenance.AccountingMovement = new()
                    {
                        ProjectId = TxtProjectId.Text.ToInt(),
                        IsAnIncome = isAnIncome
                    };
                    break;

                case MaintenanceType.Modify:
                    accountingMovementMaintenance.Text = StringResources.Modify.Format(
                        isAnIncome ? StringResources.Income : StringResources.Expense
                    );

                    accountingMovementMaintenance.AccountingMovement = isAnIncome
                        ? Incomes.Single(w => w.Id == TxtIncomeId.Text.ToInt())
                        : Expenses.Single(w => w.Id == TxtExpenseId.Text.ToInt());
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