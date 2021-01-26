using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Categories;
using BudgetManagementApp.Forms.Types;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;
using BudgetManagementApp.Services.Services.SubTypes;
using BudgetManagementApp.Services.Services.Types;

namespace BudgetManagementApp.Forms.Base
{
    public partial class FrmMain : BaseForm
    {
        private readonly FrmCategoryMaintenance categoryMaintenance;
        private readonly FrmTypeMaintenance typeMaintenance;
        private readonly ICategoryService categoryService;
        private readonly ITypeService typeService;
        private readonly ISubTypeService subTypeService;

        public FrmMain(
            FrmCategoryMaintenance categoryMaintenance,
            FrmTypeMaintenance typeMaintenance,
            ICategoryService categoryService,
            ITypeService typeService,
            ISubTypeService subTypeService
        )
        {
            this.categoryMaintenance = categoryMaintenance;
            this.typeMaintenance = typeMaintenance;
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
            IEnumerable<TDataModel> list,
            Action formatGrid
        )
        {
            grid.DataSource = list.ToList();

            formatGrid();
        }

        private static void DisableColumns(
            DataGridView grid,
            List<string> columnNames,
            bool includeCommonFields = true
        )
        {
            if (includeCommonFields)
            {
                columnNames.AddRange(new []
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

        #endregion

        #region Control Methods

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HandleCategories(categoryService.GetAll());
            HandleTypes(typeService.GetAll());

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

            var categories = new List<CategoryViewModel>(Categories);

            if (text.HasValue())
            {
                categories = categories.Where(CategoryFilter).ToList();
            }

            PopulateGrid(DgvCategories, categories, FormatCategories);

            bool CategoryFilter(CategoryViewModel category)
            {
                return category.Description.Contains(TxtCategoryFilter.Text);
            }
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            HandleCategoryMaintenance(MaintenanceType.CreateNew);
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (!DisplayQuestionMessage(StringResources.DeleteQuestion).IsYesResponse())
                return;

            var result = categoryService.Delete(
                Categories.Single(w => w.CategoryId == TxtCategoryId.Text.ToInt())
            );

            if (result.IsSuccess())
            {
                DisplayInformationMessage(StringResources.RecordDeleted);

                HandleCategories(categoryService.GetAll());

                TxtCategoryFilter.Clear();

                return;
            }

            DisplayErrorMessage(result.GetFailureError());
        }

        private void BtnModifyCategory_Click(object sender, EventArgs e)
        {
            HandleCategoryMaintenance(MaintenanceType.Modify);
        }

        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            SetCategoryDetailsData(DgvCategories);
        }

        private void SetupCategories(IEnumerable<CategoryViewModel> model)
        {
            Categories = model.ToList();

            PopulateGrid(DgvCategories, Categories, FormatCategories);

            if (!DgvCategories.IsEmpty())
                return;

            DgvCategories.SetSelectedRow(0);

            TxtCategoryId.Text = DgvCategories.GetSelectedRowValue<int>(FieldNames.CategoryId).ToString();
            TxtCategoryDescription.Text = DgvCategories.GetSelectedRowValue<string>(FieldNames.Description);
        }

        private void FormatCategories()
        {
            if (!DgvCategories.HasDataSource())
                return;

            try
            {
                DisableColumns(DgvCategories, new List<string>
                {
                    FieldNames.CategoryId,
                });
            }
            catch { }
        }

        private void SetCategoryDetailsData(DataGridView grid)
        {
            if (grid.HasRowsSelected())
            {
                TxtCategoryId.Text = grid.GetSelectedRowValue<int>(FieldNames.CategoryId).ToString();
                TxtCategoryDescription.Text = grid.GetSelectedRowValue<string>(FieldNames.Description);

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>(FieldNames.InUse),
                    BtnDeleteCategory
                );

                SetControlsStatus(true, BtnModifyCategory);

                return;
            }

            TxtCategoryId.Text = grid.FirstRow<int>(FieldNames.CategoryId).ToString();
            TxtCategoryDescription.Text = grid.FirstRow<string>(FieldNames.Description);

            SetControlsStatus(false, BtnModifyCategory, BtnDeleteCategory);
        }

        private void HandleCategories(BaseReturnViewModel result)
        {
            if (result.IsSuccess<IEnumerable<CategoryViewModel>>())
            {
                SetupCategories(
                    result.GetSuccessModel<IEnumerable<CategoryViewModel>>()
                );
            }
            else
            {
                DisplayErrorMessage(result.GetFailureError());
            }
        }

        private void HandleCategoryMaintenance(MaintenanceType type)
        {
            InitializeCategoryMaintenanceControls(type);

            if (!categoryMaintenance.ShowDialog().IsOkResponse())
                return;

            HandleCategories(categoryService.GetAll());

            TxtCategoryFilter.Clear();

            HandleTypes(typeService.GetAll());
        }

        private void InitializeCategoryMaintenanceControls(MaintenanceType type)
        {
            switch (type)
            {
                case MaintenanceType.CreateNew:
                    categoryMaintenance.TxtCategoryId.Clear();
                    categoryMaintenance.TxtDescription.Clear();
                    break;

                case MaintenanceType.Modify:
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
            if (!DisplayQuestionMessage(StringResources.DeleteQuestion).IsYesResponse())
                return;

            var result = typeService.Delete(
                Types.Single(w => w.TypeId == TxtTypeId.Text.ToInt())
            );

            if (result.IsSuccess())
            {
                DisplayInformationMessage(StringResources.RecordDeleted);

                HandleTypes(typeService.GetAll());

                TxtTypeFilter.Clear();

                HandleCategories(categoryService.GetAll());

                return;
            }

            DisplayErrorMessage(result.GetFailureError());
        }

        private void TxtTypeFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtTypeFilter.Text;

            var types = new List<TypeViewModel>(Types);

            if (text.HasValue())
            {
                types = types.Where(TypeFilter).ToList();
            }

            PopulateGrid(DgvTypes, types, FormatTypes);

            bool TypeFilter(TypeViewModel type)
            {
                return
                    type.Description.Contains(text) ||
                    type.CategoryDescription.Contains(text);
            }
        }

        private void DgvTypes_SelectionChanged(object sender, EventArgs e)
        {
            SetTypeDetailsData(DgvTypes);
        }

        private void SetupTypes(IEnumerable<TypeViewModel> model)
        {
            Types = model.ToList();

            PopulateGrid(DgvTypes, Types, FormatTypes);

            if (DgvTypes.IsEmpty())
                return;

            DgvTypes.SetSelectedRow(0);

            TxtTypeId.Text = DgvTypes.GetSelectedRowValue<int>("TypeId").ToString();
            TxtTypeDescription.Text = DgvTypes.GetSelectedRowValue<string>("Description");
            TxtTypeCategoryId.Text = DgvTypes.GetSelectedRowValue<int>("CategoryId").ToString();
            TxtTypeCategory.Text = DgvTypes.GetSelectedRowValue<string>("CategoryDescription");
        }

        private void FormatTypes()
        {
            if (!DgvTypes.HasDataSource())
                return;

            try
            {
                DisableColumns(DgvTypes, new List<string>
                {
                    FieldNames.TypeId,
                    FieldNames.CategoryId,
                });
            }
            catch { }
        }

        private void SetTypeDetailsData(DataGridView grid)
        {
            if (grid.HasRowsSelected())
            {
                TxtTypeId.Text = grid.GetSelectedRowValue<int>(FieldNames.TypeId).ToString();
                TxtTypeDescription.Text = grid.GetSelectedRowValue<string>(FieldNames.Description);
                TxtTypeCategoryId.Text = grid.GetSelectedRowValue<int>(FieldNames.CategoryId).ToString();
                TxtTypeCategory.Text = grid.GetSelectedRowValue<string>(FieldNames.CategoryDescription);

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>(FieldNames.InUse),
                    BtnDeleteType
                );

                SetControlsStatus(true, BtnModifyType);

                return;
            }

            TxtTypeId.Text = grid.FirstRow<int>(FieldNames.TypeId).ToString();
            TxtTypeDescription.Text = grid.FirstRow<string>(FieldNames.Description);
            TxtTypeCategoryId.Text = grid.FirstRow<int>(FieldNames.CategoryId).ToString();
            TxtTypeCategory.Text = grid.FirstRow<string>(FieldNames.CategoryDescription);

            SetControlsStatus(false, BtnModifyType, BtnDeleteType);
        }

        private void HandleTypes(BaseReturnViewModel result)
        {
            if (result.IsSuccess<IEnumerable<TypeViewModel>>())
            {
                SetupTypes(
                    result.GetSuccessModel<IEnumerable<TypeViewModel>>()
                );
            }
            else
            {
                DisplayErrorMessage(result.GetFailureError());
            }
        }

        private void HandleTypeMaintenance(MaintenanceType type)
        {
            InitializeTypeMaintenanceControls(type);

            if (!typeMaintenance.ShowDialog().IsOkResponse())
                return;

            HandleTypes(typeService.GetAll());
            
            TxtTypeFilter.Clear();

            HandleCategories(categoryService.GetAll());
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
                    typeMaintenance.TxtTypeId.Clear();
                    typeMaintenance.TxtDescription.Clear();

                    if (cbxCategory.HasValue())
                    {
                        cbxCategory.SelectedIndex = 0;
                    }

                    break;

                case MaintenanceType.Modify:
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

        }

        private void BtnModifySubType_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteSubType_Click(object sender, EventArgs e)
        {

        }

        private void TxtSubTypeFilter_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void DgvSubTypes_SelectionChanged(object sender, EventArgs e)
        {

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

            PopulateGrid(DgvSubTypes, SubTypes, FormatSubTypes);

            if (DgvSubTypes.IsEmpty())
                return;

            DgvSubTypes.SetSelectedRow(0);

            FillSubTypeFields(DgvSubTypes.GetSelectedRow());
        }

        private void FormatSubTypes()
        {
            if (!DgvSubTypes.HasDataSource())
                return;

            try
            {
                DisableColumns(DgvSubTypes, new List<string>
                {
                    FieldNames.TypeId,
                    FieldNames.CategoryId,
                    FieldNames.SubTypeId,
                });
            }
            catch { }
        }

        private void SetSubTypeDetailsData(DataGridView grid)
        {
            if (grid.HasRowsSelected())
            {
                FillSubTypeFields(grid.GetSelectedRow());

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>(FieldNames.InUse),
                    BtnDeleteSubType
                );

                SetControlsStatus(true, BtnModifySubType);

                return;
            }

            FillSubTypeFields(grid.FirstRow());

            SetControlsStatus(false, BtnModifySubType, BtnDeleteSubType);
        }

        private void HandleSubTypes(BaseReturnViewModel result)
        {
            if (result.IsSuccess<IEnumerable<SubTypeViewModel>>())
            {
                SetupSubTypes(
                    result.GetSuccessModel<IEnumerable<SubTypeViewModel>>()
                );
            }
            else
            {
                DisplayErrorMessage(result.GetFailureError());
            }
        }

        private void HandleSubTypeMaintenance(MaintenanceType type)
        {
            InitializeSubTypeMaintenanceControls(type);

            //if (!typeMaintenance.ShowDialog().IsOkResponse()) // change
            //    return;

            HandleSubTypes(subTypeService.GetAll());
            
            TxtSubTypeFilter.Clear();

            HandleTypes(typeService.GetAll());
        }

        private void InitializeSubTypeMaintenanceControls(MaintenanceType type)
        {
            //var cbxCategory = typeMaintenance.CbxCategory;

            //cbxCategory.SetData(
            //    Categories, 
            //    FieldNames.CategoryId, 
            //    FieldNames.Description
            //);

            //switch (type)
            //{
            //    case MaintenanceType.CreateNew:
            //        typeMaintenance.TxtTypeId.Clear();
            //        typeMaintenance.TxtDescription.Clear();

            //        if (cbxCategory.HasValue())
            //        {
            //            cbxCategory.SelectedIndex = 0;
            //        }

            //        break;

            //    case MaintenanceType.Modify:
            //        typeMaintenance.TxtTypeId.Text = TxtTypeId.Text;
            //        typeMaintenance.TxtDescription.Text = TxtTypeDescription.Text;
            //        cbxCategory.Text = TxtTypeCategory.Text;
            //        break;
            //}
        }

        #endregion
    }
}