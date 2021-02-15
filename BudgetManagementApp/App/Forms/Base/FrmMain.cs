using BudgetManagementApp.Entities;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Categories;
using BudgetManagementApp.Forms.Projects;
using BudgetManagementApp.Forms.SubTypes;
using BudgetManagementApp.Forms.Types;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Services;
using BudgetManagementApp.Services.Services.AccountingMovements;
using BudgetManagementApp.Services.Services.Categories;
using BudgetManagementApp.Services.Services.Projects;
using BudgetManagementApp.Services.Services.SubTypes;
using BudgetManagementApp.Services.Services.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManagementApp.Forms.Base
{
    public partial class FrmMain : BaseForm
    {
        private readonly FrmCategoryMaintenance categoryMaintenance;
        private readonly FrmTypeMaintenance typeMaintenance;
        private readonly FrmSubTypeMaintenance subTypeMaintenance;
        private readonly FrmProjectMaintenance projectMaintenance;
        private readonly FrmBudgetManagement budgetManagement;
        private readonly IDataService dataService;
        private readonly ICategoryService categoryService;
        private readonly ITypeService typeService;
        private readonly ISubTypeService subTypeService;
        private readonly IProjectService projectService;
        private readonly IAccountingMovementService accountingMovementService;

        public FrmMain(
            FrmCategoryMaintenance categoryMaintenance,
            FrmTypeMaintenance typeMaintenance,
            FrmSubTypeMaintenance subTypeMaintenance,
            FrmProjectMaintenance projectMaintenance,
            FrmBudgetManagement budgetManagement,
            IDataService dataService,
            ICategoryService categoryService,
            ITypeService typeService,
            ISubTypeService subTypeService,
            IProjectService projectService,
            IAccountingMovementService accountingMovementService
        )
        {
            this.categoryMaintenance = categoryMaintenance;
            this.typeMaintenance = typeMaintenance;
            this.subTypeMaintenance = subTypeMaintenance;
            this.projectMaintenance = projectMaintenance;
            this.budgetManagement = budgetManagement;
            this.dataService = dataService;
            this.categoryService = categoryService;
            this.typeService = typeService;
            this.subTypeService = subTypeService;
            this.projectService = projectService;
            this.accountingMovementService = accountingMovementService;

            InitializeComponent();
        }

        private List<CategoryViewModel> Categories { get; set; }

        private List<TypeViewModel> Types { get; set; }

        private List<SubTypeViewModel> SubTypes { get; set; }

        private List<ProjectViewModel> Projects { get; set; }

        private List<AccountingMovementViewModel> AccountingMovements { get; set; }

        protected sealed override void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            LoopControlsToSetLabels(Controls);
            LoopControlsToSetLabels(TclBudgetManagement.Controls);
            LoopControlsToSetLabels(TabCategories.Controls);
            LoopControlsToSetLabels(TabTypes.Controls);
            LoopControlsToSetLabels(TabSubtypes.Controls);
            LoopControlsToSetLabels(TabProjects.Controls);

            foreach (ToolStripMenuItem menu in MsMainMenu.Items)
            {
                SetMenuLabels(menu);

                foreach (ToolStripMenuItem item in menu.DropDownItems)
                {
                    SetMenuLabels(item);
                }
            }

            SetColumnNames(DgvCategories, new Dictionary<string, string>
            {
                [FieldNames.Description] = StringResourcesHandler.GetString(FieldNames.Description),
            });

            SetColumnNames(DgvTypes, new Dictionary<string, string>
            {
                [FieldNames.Description] = StringResourcesHandler.GetString(FieldNames.Description),
                [FieldNames.CategoryDescription] = StringResourcesHandler.GetString(FieldNames.Category),
            });

            SetColumnNames(DgvSubTypes, new Dictionary<string, string>
            {
                [FieldNames.Description] = StringResourcesHandler.GetString(FieldNames.Description),
                [FieldNames.TypeDescription] = StringResourcesHandler.GetString(FieldNames.Type),
                [FieldNames.CategoryDescription] = StringResourcesHandler.GetString(FieldNames.Category),
            });

            SetColumnNames(DgvProjects, new Dictionary<string, string>
            {
                [FieldNames.Name] = StringResourcesHandler.GetString(FieldNames.Name),
                [FieldNames.StartDate] = StringResourcesHandler.GetString(FieldNames.StartDate),
                [FieldNames.EndDate] = StringResourcesHandler.GetString(FieldNames.EndDate),
                [FieldNames.Construction] = StringResourcesHandler.GetString(FieldNames.Construction),
                [FieldNames.Cost] = StringResourcesHandler.GetString(FieldNames.Cost),
            });

            static void SetMenuLabels(ToolStripMenuItem control)
            {
                var name = control.Name;
                const int prefix = 2;

                control.Text = StringResourcesHandler.GetString(
                    name.Substring(prefix, name.Length - prefix)
                );
            }
        }

        #region Private Methods

        private void ChangeButtonSelectedStatus(Control button)
        {
            button.Font = button.Font = new Font(button.Font, FontStyle.Bold);
            button.BackColor = SystemColors.ActiveCaption;

            foreach (var btn in Controls.OfType<Button>()
                .Where(b => b.Name != button.Name)
            )
            {
                btn.Font = new Font(btn.Font, FontStyle.Regular);
                btn.BackColor = SystemColors.ControlLight;
            }
        }

        private void ChangeLanguage(string language)
        {
            if (Equals(CultureInfo.CurrentCulture, CultureInfo.GetCultureInfo(language)))
            {
                return;
            }

            CultureInfo.CurrentCulture = new CultureInfo(language);
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

            SetAppLabels();
        }

        #endregion

        #region Control Methods

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var data = HandleEntity<DataViewModel>(dataService.GetData());

            SetupCategories(data.Categories);

            SetupTypes(data.Types);

            SetupSubTypes(data.SubTypes);

            SetupProjects(data.Projects);

            AccountingMovements = data.AccountingMovements.ToList();

            SetAppLabels();
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 0;
            ChangeButtonSelectedStatus(BtnProjects);
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 1;
            ChangeButtonSelectedStatus(BtnCategories);
        }

        private void BtnTypes_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 2;
            ChangeButtonSelectedStatus(BtnTypes);
        }

        private void BtnSubtypes_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 3;
            ChangeButtonSelectedStatus(BtnSubtypes);
        }

        private void TclBudgetManagement_Click(object sender, EventArgs e)
        {
            switch (TclBudgetManagement.SelectedIndex)
            {
                case 0:
                    ChangeButtonSelectedStatus(BtnProjects);
                    break;

                case 1:
                    ChangeButtonSelectedStatus(BtnCategories);
                    break;

                case 2:
                    ChangeButtonSelectedStatus(BtnTypes);
                    break;

                case 3:
                    ChangeButtonSelectedStatus(BtnSubtypes);
                    break;
            }
        }

        private void MiSpanish_Click(object sender, EventArgs e)
        {
            ChangeLanguage(CultureData.SpanishCultureName);
        }

        private void MiEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage(CultureData.EnglishCultureName);
        }

        private void MiClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Categories

        private void TxtCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtCategoryFilter.Text;

            PopulateGrid(
                DgvCategories,
                GetFilteredData(
                    text,
                    Categories, c => c.Description.ToLower().Contains(text.ToLower())
                ),
                FormatGrid,
                new List<string> { FieldNames.CategoryId }
            );
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            HandleCategoryMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            Delete(
                categoryService,
                Categories.Single(w => w.CategoryId == TxtCategoryId.Text.ToInt()),
                TxtCategoryFilter,
                () =>
                {
                    HandleEntity<CategoryViewModel>(
                        categoryService.GetAll(),
                        SetupCategories
                    );
                }
            );
        }

        private void BtnModifyCategory_Click(object sender, EventArgs e)
        {
            HandleCategoryMaintenance(MaintenanceType.Modify);
        }

        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailsData(
                DgvCategories,
                BtnModifyCategory,
                BtnDeleteCategory,
                FillCategoryFields
            );
        }

        private void FillCategoryFields(DataGridViewRow row)
        {
            TxtCategoryId.Text = row.Value<int>(FieldNames.CategoryId).ToString();
            TxtCategoryDescription.Text = row.Value<string>(FieldNames.Description);
        }

        private void SetupCategories(IEnumerable<CategoryViewModel> model)
        {
            Categories = model.ToList();

            PopulateGrid(
                DgvCategories,
                Categories,
                FormatGrid,
                new List<string> { FieldNames.CategoryId }
            );
        }

        private void HandleCategoryMaintenance(MaintenanceType type)
        {
            InitializeCategoryMaintenanceControls(type);

            if (!categoryMaintenance.ShowDialog().IsOkResponse())
                return;

            TxtCategoryFilter.Clear();

            HandleEntity<CategoryViewModel>(
                categoryService.GetAll(),
                SetupCategories
            );

            HandleEntity<TypeViewModel>(
                typeService.GetAll(),
                SetupTypes
            );
        }

        private void InitializeCategoryMaintenanceControls(MaintenanceType type)
        {
            switch (type)
            {
                case MaintenanceType.CreateNew:
                    categoryMaintenance.Text = StringResources.Add.Format(StringResources.Category);

                    categoryMaintenance.Category = new CategoryViewModel();
                    break;

                case MaintenanceType.Modify:
                    categoryMaintenance.Text = StringResources.Modify.Format(StringResources.Category);

                    categoryMaintenance.Category = Categories.Single(
                        w => w.CategoryId == TxtCategoryId.Text.ToIntOrDefault()
                    );
                    break;
            }
        }

        #endregion

        #region Types

        private void BtnNewType_Click(object sender, EventArgs e)
        {
            HandleTypeMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnModifyType_Click(object sender, EventArgs e)
        {
            HandleTypeMaintenance(MaintenanceType.Modify);
        }

        private void BtnDeleteType_Click(object sender, EventArgs e)
        {
            Delete(
                typeService,
                Types.Single(w => w.TypeId == TxtTypeId.Text.ToInt()),
                TxtTypeFilter,
                () =>
                {
                    HandleEntity<TypeViewModel>(
                        typeService.GetAll(),
                        SetupTypes
                    );

                    HandleEntity<CategoryViewModel>(
                        categoryService.GetAll(),
                        SetupCategories
                    );
                }
            );
        }

        private void TxtTypeFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtTypeFilter.Text;

            PopulateGrid(
                DgvTypes,
                GetFilteredData(
                    text,
                    Types,
                    t => t.Description.Contains(text) ||
                         t.CategoryDescription.Contains(text)
                ),
                FormatGrid,
                new List<string>
                {
                    FieldNames.TypeId,
                    FieldNames.CategoryId,
                }
            );
        }

        private void DgvTypes_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailsData(
                DgvTypes,
                BtnModifyType,
                BtnDeleteType,
                FillTypeFields
            );
        }

        private void FillTypeFields(DataGridViewRow row)
        {
            TxtTypeId.Text = row.Value<int>(FieldNames.TypeId).ToString();
            TxtTypeDescription.Text = row.Value<string>(FieldNames.Description);
            TxtTypeCategoryId.Text = row.Value<int>(FieldNames.CategoryId).ToString();
            TxtTypeCategory.Text = row.Value<string>(FieldNames.CategoryDescription);
        }

        private void SetupTypes(IEnumerable<TypeViewModel> model)
        {
            Types = model.ToList();

            PopulateGrid(
                DgvTypes,
                Types,
                FormatGrid,
                new List<string>
                {
                    FieldNames.TypeId,
                    FieldNames.CategoryId,
                }
            );
        }

        private void HandleTypeMaintenance(MaintenanceType type)
        {
            InitializeTypeMaintenanceControls(type);

            if (!typeMaintenance.ShowDialog().IsOkResponse())
                return;

            HandleEntity<TypeViewModel>(
                typeService.GetAll(),
                SetupTypes
            );

            TxtTypeFilter.Clear();

            HandleEntity<CategoryViewModel>(
                categoryService.GetAll(),
                SetupCategories
            );

            HandleEntity<SubTypeViewModel>(
                subTypeService.GetAll(),
                SetupSubTypes
            );
        }

        private void InitializeTypeMaintenanceControls(MaintenanceType type)
        {
            typeMaintenance.Categories = Categories;

            switch (type)
            {
                case MaintenanceType.CreateNew:
                    typeMaintenance.Text = StringResources.Add.Format(StringResources.Type);

                    typeMaintenance.Type = new TypeViewModel();
                    break;

                case MaintenanceType.Modify:
                    typeMaintenance.Text = StringResources.Modify.Format(StringResources.Type);

                    typeMaintenance.Type = Types.Single(w => w.TypeId == TxtTypeId.Text.ToInt());
                    break;
            }
        }

        #endregion

        #region SubTypes

        private void BtnNewSubType_Click(object sender, EventArgs e)
        {
            HandleSubTypeMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnModifySubType_Click(object sender, EventArgs e)
        {
            HandleSubTypeMaintenance(MaintenanceType.Modify);
        }

        private void BtnDeleteSubType_Click(object sender, EventArgs e)
        {
            Delete(
                subTypeService,
                SubTypes.Single(w => w.SubTypeId == TxtSubTypeId.Text.ToInt()),
                TxtSubTypeFilter,
                () =>
                {
                    HandleEntity<SubTypeViewModel>(
                        subTypeService.GetAll(),
                        SetupSubTypes
                    );

                    HandleEntity<TypeViewModel>(
                        typeService.GetAll(),
                        SetupTypes
                    );
                }
            );
        }

        private void TxtSubTypeFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtSubTypeFilter.Text;

            PopulateGrid(
                DgvSubTypes,
                GetFilteredData(
                    text,
                    SubTypes,
                    s => s.Description.ToLower().Contains(text.ToLower()) ||
                         s.TypeDescription.ToLower().Contains(text.ToLower()) ||
                         s.CategoryDescription.ToLower().Contains(text.ToLower())
                ),
                FormatGrid,
                new List<string>
                {
                    FieldNames.SubTypeId,
                    FieldNames.CategoryId,
                    FieldNames.TypeId,
                }
            );
        }

        private void DgvSubTypes_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailsData(
                DgvSubTypes,
                BtnModifySubType,
                BtnDeleteSubType,
                FillSubTypeFields
            );
        }

        private void FillSubTypeFields(DataGridViewRow row)
        {
            TxtSubTypeId.Text = row.Value<int>(FieldNames.SubTypeId).ToString();
            TxtSubTypeDescription.Text = row.Value<string>(FieldNames.Description);
            TxtSubTypeCategoryId.Text = row.Value<int>(FieldNames.CategoryId).ToString();
            TxtSubTypeCategory.Text = row.Value<string>(FieldNames.CategoryDescription);
            TxtSubTypeTypeId.Text = row.Value<int>(FieldNames.TypeId).ToString();
            TxtSubTypeTypeDescription.Text = row.Value<string>(FieldNames.TypeDescription);
        }

        private void SetupSubTypes(IEnumerable<SubTypeViewModel> model)
        {
            SubTypes = model.ToList();

            PopulateGrid(
                DgvSubTypes,
                SubTypes,
                FormatGrid,
                new List<string>
                {
                    FieldNames.SubTypeId,
                    FieldNames.TypeId,
                    FieldNames.CategoryId,
                }
            );
        }

        private void HandleSubTypeMaintenance(MaintenanceType type)
        {
            InitializeSubTypeMaintenanceControls(type);

            if (!subTypeMaintenance.ShowDialog().IsOkResponse())
                return;

            HandleEntity<SubTypeViewModel>(
                subTypeService.GetAll(),
                SetupSubTypes
            );

            TxtSubTypeFilter.Clear();

            HandleEntity<TypeViewModel>(
                typeService.GetAll(),
                SetupTypes
            );
        }

        private void InitializeSubTypeMaintenanceControls(MaintenanceType type)
        {
            subTypeMaintenance.Categories = Categories;
            subTypeMaintenance.Types = Types;

            switch (type)
            {
                case MaintenanceType.CreateNew:
                    subTypeMaintenance.Text = StringResources.Add.Format(StringResources.SubType);

                    subTypeMaintenance.SubType = new SubTypeViewModel();
                    break;

                case MaintenanceType.Modify:
                    subTypeMaintenance.Text = StringResources.Modify.Format(StringResources.SubType);

                    subTypeMaintenance.SubType = SubTypes.Single(
                        w => w.SubTypeId == TxtSubTypeId.Text.ToIntOrDefault()
                    );
                    break;
            }
        }

        #endregion

        #region Projects

        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            HandleProjectMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnModifyProject_Click(object sender, EventArgs e)
        {
            HandleProjectMaintenance(MaintenanceType.Modify);
        }

        private void BtnDeleteProject_Click(object sender, EventArgs e)
        {
            Delete(
                projectService,
                Projects.Single(w => w.ProjectId == TxtProjectId.Text.ToInt()),
                TxtProjectFilter,
                () =>
                {
                    HandleEntity<ProjectViewModel>(
                        projectService.GetAll(),
                        SetupProjects
                    );
                }
            );
        }

        private void BtnBudgetManagement_Click(object sender, EventArgs e)
        {
            budgetManagement.Text = StringResources.BudgetManagement;

            var project = Projects.Single(w => w.Id == TxtProjectId.Text.ToInt());

            budgetManagement.Project = project;

            budgetManagement.Incomes =
                AccountingMovements
                    .PrettyWhere(w => w.ProjectId == project.ProjectId)
                    .GetIncomes();

            budgetManagement.Expenses =
                AccountingMovements
                    .PrettyWhere(w => w.ProjectId == project.ProjectId)
                    .GetExpenses();

            budgetManagement.Categories = Categories;
            budgetManagement.Types = Types;
            budgetManagement.SubTypes = SubTypes;

            budgetManagement.ShowDialog();

            if (GlobalProperties.ProjectsNeedToBeUpdated)
            {
                GlobalProperties.ProjectsNeedToBeUpdated = false;

                HandleEntity<ProjectViewModel>(
                    projectService.GetAll(),
                    SetupProjects
                );

                AccountingMovements = 
                    HandleEntity<IEnumerable<AccountingMovementViewModel>>(
                        accountingMovementService.GetAll()
                    )
                    .ToList();
            }
        }

        private void TxtProjectFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtProjectFilter.Text;

            PopulateGrid(
                DgvProjects,
                GetFilteredData(text, Projects, c => c.Name.ToLower().Contains(text.ToLower())),
                FormatGrid,
                new List<string> { FieldNames.ProjectId }
            );
        }

        private void DgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailsData(
                DgvProjects,
                BtnModifyProject,
                BtnDeleteProject,
                FillProjectFields
            );

            SetControlsStatus(DgvProjects.HasRowsSelected(), BtnBudgetManagement);
        }

        private void FillProjectFields(DataGridViewRow row)
        {
            TxtProjectId.Text = row.Value<int>(FieldNames.ProjectId).ToString();
            TxtProjectName.Text = row.Value<string>(FieldNames.Name);
            TxtStartDate.Text = row.Value<DateTime>(FieldNames.StartDate).ToShortDateString();
            TxtEndDate.Text = row.Value<DateTime>(FieldNames.EndDate).ToShortDateString();
            TxtConstruction.Text = row.Value<decimal>(FieldNames.Construction).ToStringWithDecimals();
            TxtCost.Text = row.Value<decimal>(FieldNames.Cost).ToStringWithDecimals();
        }

        private void SetupProjects(IEnumerable<ProjectViewModel> model)
        {
            Projects = model.ToList();

            PopulateGrid(
                DgvProjects,
                Projects,
                FormatProjectGrid,
                new List<string> { FieldNames.ProjectId }
            );
        }

        protected void FormatProjectGrid(
            DataGridView grid,
            List<string> columnNamesToHide
        )
        {
            if (!grid.HasDataSource())
                return;

            try
            {
                DisableColumns(grid, columnNamesToHide);

                grid.Columns[FieldNames.Cost].DefaultCellStyle.Format = "C2";
                grid.Columns[FieldNames.Construction].DefaultCellStyle.Format = "C2";
            }
            catch { }
        }

        private void HandleProjectMaintenance(MaintenanceType type)
        {
            InitializeProjectMaintenanceControls(type);

            if (!projectMaintenance.ShowDialog().IsOkResponse())
                return;

            TxtProjectFilter.Clear();

            HandleEntity<ProjectViewModel>(
                projectService.GetAll(),
                SetupProjects
            );
        }

        private void InitializeProjectMaintenanceControls(MaintenanceType type)
        {
            switch (type)
            {
                case MaintenanceType.CreateNew:
                    projectMaintenance.Text = StringResources.Add.Format(StringResources.Projects);

                    projectMaintenance.Project = new ProjectViewModel();
                    break;

                case MaintenanceType.Modify:
                    projectMaintenance.Text = StringResources.Modify.Format(StringResources.Projects);

                    projectMaintenance.Project = Projects.Single(w => w.Id == TxtProjectId.Text.ToInt());
                    break;
            }
        }

        #endregion
    }
}