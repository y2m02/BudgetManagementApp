using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Categories;
using BudgetManagementApp.Forms.SubTypes;
using BudgetManagementApp.Forms.Types;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Base;
using BudgetManagementApp.Services.Services.Categories;
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
        private readonly ICategoryService categoryService;
        private readonly ITypeService typeService;
        private readonly ISubTypeService subTypeService;

        public FrmMain(
            FrmCategoryMaintenance categoryMaintenance,
            FrmTypeMaintenance typeMaintenance,
            FrmSubTypeMaintenance subTypeMaintenance,
            ICategoryService categoryService,
            ITypeService typeService,
            ISubTypeService subTypeService
        )
        {
            this.categoryMaintenance = categoryMaintenance;
            this.typeMaintenance = typeMaintenance;
            this.subTypeMaintenance = subTypeMaintenance;
            this.categoryService = categoryService;
            this.typeService = typeService;
            this.subTypeService = subTypeService;

            InitializeComponent();
        }

        private List<CategoryViewModel> Categories { get; set; }

        private List<TypeViewModel> Types { get; set; }

        private List<SubTypeViewModel> SubTypes { get; set; }

        protected sealed override void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            LoopControlsToSetLabels(Controls);
            LoopControlsToSetLabels(TclBudgetManagement.Controls);
            LoopControlsToSetLabels(TabCategories.Controls);
            LoopControlsToSetLabels(TabTypes.Controls);
            LoopControlsToSetLabels(TabSubtypes.Controls);

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

            void SetMenuLabels(ToolStripMenuItem control)
            {
                var name = control.Name;
                const int prefix = 2;

                control.Text = StringResourcesHandler.GetString(
                    name.Substring(prefix, name.Length - prefix)
                );
            }
        }

        #region Private Methods

        private static void PopulateGrid<TDataModel>(
            DataGridView grid,
            IEnumerable<TDataModel> data,
            Action<DataGridView, List<string>> formatGrid,
            List<string> columnNames
        )
        {
            grid.DataSource = data.ToList();

            formatGrid(grid, columnNames);
        }

        private static void DisableColumns(
            DataGridView grid,
            List<string> columnNames,
            bool includeCommonFields = true
        )
        {
            if (includeCommonFields)
            {
                columnNames.AddRange(new[]
                {
                    FieldNames.Id,
                    FieldNames.Action,
                    FieldNames.DeletedOn,
                    FieldNames.InUse,
                });
            }

            foreach (var columnName in columnNames)
            {
                grid.Columns[columnName].Visible = false;
            }
        }

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

            SetAppLabels();
        }

        private static void SetColumnNames(DataGridView grid, Dictionary<string, string> columnNames)
        {
            if (!grid.HasDataSource())
                return;

            foreach (var columnName in columnNames)
            {
                grid.Columns[columnName.Key].HeaderText = columnName.Value;
            }
        }

        private void HandleEntity<T>(BaseReturnViewModel result, Action<IEnumerable<T>> executor)
        {
            if (result.IsSuccess<IEnumerable<T>>())
            {
                executor(result.GetSuccessModel<IEnumerable<T>>());
            }
            else
            {
                DisplayErrorMessage(result.GetFailureError());
            }
        }

        private static IEnumerable<T> GetFilteredData<T>(
            string textToSearch,
            IEnumerable<T> model,
            Func<T, bool> filter
        )
            where T : BaseViewModel
        {
            var data = new List<T>(model);

            return textToSearch.HasValue()
                ? data.PrettyWhere(filter)
                : data;
        }

        private void SetDetailsData(
            DataGridView grid,
            Button btnModify,
            Button btnDelete,
            Action<DataGridViewRow> fillFields
        )
        {
            if (grid.HasRowsSelected())
            {
                fillFields(grid.GetSelectedRow());

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>(FieldNames.InUse),
                    btnDelete
                );

                SetControlsStatus(true, btnModify);

                return;
            }

            if (grid.HasValue())
            {
                fillFields(grid.FirstRow());
            }

            SetControlsStatus(false, btnModify, btnDelete);
        }

        private static void FormatGrid(
            DataGridView grid,
            List<string> columnNames
        )
        {
            if (!grid.HasDataSource())
                return;

            try
            {
                DisableColumns(grid, columnNames);
            }
            catch { }
        }

        private void Delete(
            IBaseService service,
            BaseViewModel model,
            TextBox filter,
            Action executeWhenSuccess
        )
        {
            if (!DisplayQuestionMessage(StringResources.DeleteQuestion).IsYesResponse())
                return;

            var result = service.Delete(model);

            if (result.IsSuccess())
            {
                DisplayInformationMessage(StringResources.RecordDeleted);

                filter.Clear();

                executeWhenSuccess();

                return;
            }

            DisplayErrorMessage(result.GetFailureError());
        }

        #endregion

        #region Control Methods

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HandleEntity<CategoryViewModel>(
                categoryService.GetAll(),
                SetupCategories
            );

            HandleEntity<TypeViewModel>(
                typeService.GetAll(),
                SetupTypes
            );

            HandleEntity<SubTypeViewModel>(
                subTypeService.GetAll(),
                SetupSubTypes
            );

            SetAppLabels();
        }

        private void BtnBudgetManagement_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 0;
            ChangeButtonSelectedStatus(BtnBudgetManagement);
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 1;
            ChangeButtonSelectedStatus(BtnProjects);
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 2;
            ChangeButtonSelectedStatus(BtnCategories);
        }

        private void BtnTypes_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 3;
            ChangeButtonSelectedStatus(BtnTypes);
        }

        private void BtnSubtypes_Click(object sender, EventArgs e)
        {
            TclBudgetManagement.SelectedIndex = 4;
            ChangeButtonSelectedStatus(BtnSubtypes);
        }

        private void TclBudgetManagement_Click(object sender, EventArgs e)
        {
            switch (TclBudgetManagement.SelectedIndex)
            {
                case 0:
                    ChangeButtonSelectedStatus(BtnBudgetManagement);
                    break;

                case 1:
                    ChangeButtonSelectedStatus(BtnProjects);
                    break;

                case 2:
                    ChangeButtonSelectedStatus(BtnCategories);
                    break;

                case 3:
                    ChangeButtonSelectedStatus(BtnTypes);
                    break;

                case 4:
                    ChangeButtonSelectedStatus(BtnSubtypes);
                    break;
            }
        }

        private void MiSpanish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("es-ES");
        }

        private void MiEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
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
                GetFilteredData(text, Categories, c => c.Description.Contains(text)),
                FormatGrid,
                new List<string> { FieldNames.CategoryId }
            );
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            //HandleMaintenance(categoryMaintenance);

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

        public void HandleMaintenance(
            Form frmMaintenance,
            TextBox filter,
            MaintenanceType type,
            Action<MaintenanceType> initializeControls,
            Action executeWhenSuccess
        )
        {
            initializeControls(type);

            if (!categoryMaintenance.ShowDialog().IsOkResponse())
                return;

            filter.Clear();

            executeWhenSuccess();
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
                    categoryMaintenance.TxtCategoryId.Clear();
                    categoryMaintenance.TxtDescription.Clear();
                    break;

                case MaintenanceType.Modify:
                    categoryMaintenance.Text = StringResources.Modify.Format(StringResources.Category);
                    categoryMaintenance.TxtCategoryId.Text = TxtCategoryId.Text;
                    categoryMaintenance.TxtDescription.Text = TxtCategoryDescription.Text;
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
            var cbxCategory = typeMaintenance.CbxCategory;

            cbxCategory.SetData(
                Categories,
                FieldNames.CategoryId,
                FieldNames.Description
            );

            switch (type)
            {
                case MaintenanceType.CreateNew:
                    typeMaintenance.Text = StringResources.Add.Format(StringResources.Type);
                    typeMaintenance.TxtTypeId.Clear();
                    typeMaintenance.TxtDescription.Clear();

                    if (cbxCategory.HasValue())
                    {
                        cbxCategory.SelectedIndex = 0;
                    }

                    break;

                case MaintenanceType.Modify:
                    typeMaintenance.Text = StringResources.Modify.Format(StringResources.Type);
                    typeMaintenance.TxtTypeId.Text = TxtTypeId.Text;
                    typeMaintenance.TxtDescription.Text = TxtTypeDescription.Text;
                    cbxCategory.Text = TxtTypeCategory.Text;
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
                    s => s.Description.Contains(text) ||
                         s.TypeDescription.Contains(text) ||
                         s.CategoryDescription.Contains(text)
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
            subTypeMaintenance.Types = Types;

            var cbxType = subTypeMaintenance.CbxType;

            cbxType.SetData(
                Types,
                FieldNames.TypeId,
                FieldNames.Description
            );

            var cbxCategory = subTypeMaintenance.CbxCategory;

            cbxCategory.SetData(
                Categories,
                FieldNames.CategoryId,
                FieldNames.Description
            );

            switch (type)
            {
                case MaintenanceType.CreateNew:
                    subTypeMaintenance.Text = StringResources.Add.Format(StringResources.SubType);
                    subTypeMaintenance.TxtSubTypeId.Clear();
                    subTypeMaintenance.TxtDescription.Clear();

                    if (cbxCategory.HasValue())
                    {
                        cbxCategory.SelectedIndex = 0;
                    }

                    if (cbxType.HasValue())
                    {
                        cbxType.SelectedIndex = 0;
                    }
                    break;

                case MaintenanceType.Modify:
                    subTypeMaintenance.Text = StringResources.Modify.Format(StringResources.SubType);
                    subTypeMaintenance.TxtSubTypeId.Text = TxtSubTypeId.Text;
                    subTypeMaintenance.TxtDescription.Text = TxtSubTypeDescription.Text;
                    cbxCategory.Text = TxtSubTypeCategory.Text;
                    cbxType.Text = TxtSubTypeTypeDescription.Text;
                    break;
            }
        }

        #endregion
    }
}