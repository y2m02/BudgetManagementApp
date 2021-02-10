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
        private readonly FrmAccountingMovementMaintenance accountingMovementMaintenance;
        private readonly IAccountingMovementService accountingMovementService;

        public FrmBudgetManagement(
            IAccountingMovementService accountingMovementService,
            FrmAccountingMovementMaintenance accountingMovementMaintenance
        )
        {
            InitializeComponent();

            this.accountingMovementService = accountingMovementService;
            this.accountingMovementMaintenance = accountingMovementMaintenance;
        }

        public ProjectViewModel Project { get; set; }

        public List<CategoryViewModel> Categories { get; set; }

        public List<TypeViewModel> Types { get; set; }

        public List<SubTypeViewModel> SubTypes { get; set; }

        public List<AccountingMovementViewModel> Incomes { get; set; }

        public List<AccountingMovementViewModel> Expenses { get; set; }

        private void FrmBudgetManagement_Load(object sender, EventArgs e)
        {
            SetLabels();

            SetupIncomes(Incomes);
            SetupExpenses(Expenses);

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

            SetColumnNames(DgvIncomesByTypes, new Dictionary<string, string>
            {
                [FieldNames.CategoryDescription] = StringResourcesHandler.GetString(FieldNames.Category),
                [FieldNames.TypeDescription] = StringResourcesHandler.GetString(FieldNames.Type),
                [FieldNames.Amount] = StringResourcesHandler.GetString(FieldNames.Amount),
            });

            SetColumnNames(DgvIncomesByCategories, new Dictionary<string, string>
            {
                [FieldNames.CategoryDescription] = StringResourcesHandler.GetString(FieldNames.Category),
                [FieldNames.Amount] = StringResourcesHandler.GetString(FieldNames.Amount),
            });

            SetColumnNames(DgvExpenses, new Dictionary<string, string>
            {
                [FieldNames.CategoryDescription] = StringResourcesHandler.GetString(FieldNames.Category),
                [FieldNames.TypeDescription] = StringResourcesHandler.GetString(FieldNames.Type),
                [FieldNames.SubTypeDescription] = StringResourcesHandler.GetString(FieldNames.SubType),
                [FieldNames.Date] = StringResourcesHandler.GetString(FieldNames.Date),
                [FieldNames.Amount] = StringResourcesHandler.GetString(FieldNames.Amount),
                [FieldNames.Comment] = StringResourcesHandler.GetString(FieldNames.Comment),
            });
        }

        protected override void SetLabels()
        {
            LoopControlsToSetLabels(PnlBySubTypes.Controls);
            LoopControlsToSetLabels(PnlByTypes.Controls);
            LoopControlsToSetLabels(PnlByCategories.Controls);

            base.SetLabels();
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
                        IsAnIncome = isAnIncome,
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

        #region Incomes

        private void SetupIncomes(IEnumerable<AccountingMovementViewModel> model)
        {
            Incomes = model.ToList();

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

            LblTotalIncomes.SetText(
                StringResources.Total.Format(
                    StringResourcesHandler.GetString(FieldNames.Incomes),
                    Incomes.Sum(w => w.Amount).ToStringWithDecimals()
                )
            );

            SetupIncomesByTypes();
            SetupIncomesByCategories();
        }
        private void SetupIncomesByTypes()
        {
            var incomesGroupedByTypes = Incomes.GroupBy(w => w.TypeId)
                .EagerSelect(group =>
                {
                    var movement = group.FirstOrDefault();

                    return new AccountingMovementViewModel
                    {
                        CategoryDescription = movement?.CategoryDescription,
                        TypeDescription = movement?.TypeDescription,
                        Amount = group.Sum(w => w.Amount),
                    };
                });

            PopulateGrid(
                DgvIncomesByTypes,
                incomesGroupedByTypes,
                FormatGrid,
                new List<string>
                {
                    FieldNames.AccountingMovementId,
                    FieldNames.CategoryId,
                    FieldNames.TypeId,
                    FieldNames.SubTypeId,
                    FieldNames.SubTypeDescription,
                    FieldNames.ProjectId,
                    FieldNames.ProjectName,
                    FieldNames.IsAnIncome,
                    FieldNames.Comment,
                    FieldNames.Date,
                }
            );
        }

        private void SetupIncomesByCategories()
        {
            var incomesGroupedByCategories = Incomes.GroupBy(w => w.CategoryId)
                .EagerSelect(group => new AccountingMovementViewModel
                {
                    CategoryDescription = group.FirstOrDefault()?.CategoryDescription,
                    Amount = group.Sum(w => w.Amount),
                });

            PopulateGrid(
                DgvIncomesByCategories,
                incomesGroupedByCategories,
                FormatGrid,
                new List<string>
                {
                    FieldNames.AccountingMovementId,
                    FieldNames.CategoryId,
                    FieldNames.TypeId,
                    FieldNames.TypeDescription,
                    FieldNames.SubTypeId,
                    FieldNames.SubTypeDescription,
                    FieldNames.ProjectId,
                    FieldNames.ProjectName,
                    FieldNames.IsAnIncome,
                    FieldNames.Comment,
                    FieldNames.Date,
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
            Delete(
                accountingMovementService,
                Incomes.Single(w => w.AccountingMovementId == TxtIncomeId.Text.ToInt()),
                TxtIncomeFilter,
                () =>
                {
                    GlobalProperties.ProjectsNeedToBeUpdated = true;

                    HandleEntity<AccountingMovementViewModel>(
                        accountingMovementService.GetIncomesByProjectId(Project.ProjectId),
                        SetupIncomes
                    );
                }
            );
        }

        private void TxtIncomeFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtIncomeFilter.Text;

            PopulateGrid(
                DgvIncomes,
                GetFilteredData(
                    text,
                    Incomes,
                    c => c.CategoryDescription.ToLower().Contains(text.ToLower()) ||
                         c.TypeDescription.ToLower().Contains(text.ToLower()) ||
                         c.SubTypeDescription.ToLower().Contains(text.ToLower()) ||
                         c.Comment.ToLower().Contains(text.ToLower())
                ),
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

        private void DgvIncomes_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailsData(
                DgvIncomes,
                BtnModifyIncome,
                BtnDeleteIncome,
                row => TxtIncomeId.SetText(row.Value<int>(FieldNames.AccountingMovementId).ToString())
            );
        }

        #endregion

        #region Expenses

        private void SetupExpenses(IEnumerable<AccountingMovementViewModel> model)
        {
            Expenses = model.ToList();

            PopulateGrid(
                DgvExpenses,
                Expenses,
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

            LblTotalExpenses.SetText(
                StringResources.Total.Format(
                    StringResourcesHandler.GetString(FieldNames.Expenses),
                    Expenses.Sum(w => w.Amount).ToStringWithDecimals()
                )
            );
        }

        private void HandleExpenseMaintenance(MaintenanceType type)
        {
            InitializeMaintenanceControls(type, AccountingMovementType.Expense);

            if (!accountingMovementMaintenance.ShowDialog().IsOkResponse())
                return;

            TxtExpenseFilter.Clear();

            HandleEntity<AccountingMovementViewModel>(
                accountingMovementService.GetExpensesByProjectId(Project.ProjectId),
                SetupExpenses
            );

            GlobalProperties.ProjectsNeedToBeUpdated = true;
        }

        private void BtnNewExpense_Click(object sender, EventArgs e)
        {
            HandleExpenseMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnModifyExpense_Click(object sender, EventArgs e)
        {
            HandleExpenseMaintenance(MaintenanceType.Modify);
        }

        private void BtnDeleteExpense_Click(object sender, EventArgs e)
        {
            Delete(
                accountingMovementService,
                Expenses.Single(w => w.AccountingMovementId == TxtExpenseId.Text.ToInt()),
                TxtExpenseFilter,
                () =>
                {
                    GlobalProperties.ProjectsNeedToBeUpdated = true;

                    HandleEntity<AccountingMovementViewModel>(
                        accountingMovementService.GetExpensesByProjectId(Project.ProjectId),
                        SetupExpenses
                    );
                }
            );
        }

        private void TxtExpenseFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtExpenseFilter.Text;

            PopulateGrid(
                DgvExpenses,
                GetFilteredData(
                    text,
                    Expenses,
                    c => c.CategoryDescription.ToLower().Contains(text.ToLower()) ||
                         c.TypeDescription.ToLower().Contains(text.ToLower()) ||
                         c.SubTypeDescription.ToLower().Contains(text.ToLower()) ||
                         c.Comment.ToLower().Contains(text.ToLower())
                ),
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

        private void DgvExpenses_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailsData(
                DgvExpenses,
                BtnModifyExpense,
                BtnDeleteExpense,
                row => TxtExpenseId.SetText(row.Value<int>(FieldNames.AccountingMovementId).ToString())
            );
        }

        #endregion
    }
}