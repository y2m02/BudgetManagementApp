using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Categories;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;
using BudgetManagementApp.Services.Types;

namespace BudgetManagementApp.Forms.Base
{
    public partial class FrmMain : BaseForm
    {
        private readonly FrmCategoryMaintenance categoryMaintenance;
        private readonly ICategoryService categoryService;
        private readonly ITypeService typeService;

        public FrmMain(
            FrmCategoryMaintenance categoryMaintenance,
            ICategoryService categoryService,
            ITypeService typeService
        )
        {
            this.categoryMaintenance = categoryMaintenance;
            this.categoryService = categoryService;
            this.typeService = typeService;

            InitializeComponent();
        }

        private List<CategoryViewModel> Categories { get; set; }

        private List<TypeViewModel> Types { get; set; }

        protected sealed override void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            LoopControlsToSetLabels(Controls);
            LoopControlsToSetLabels(TclBudgetManagement.Controls);
            LoopControlsToSetLabels(TabCategories.Controls);

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
                ["Description"] = StringResourcesHandler.GetString("Description"),
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
            IEnumerable<string> columnNames
        )
        {
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
            categoryMaintenance.TxtCategoryId.Clear();
            categoryMaintenance.TxtDescription.Clear();

            HandleCategoryMaintenance();
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
            categoryMaintenance.TxtCategoryId.Text = TxtCategoryId.Text;
            categoryMaintenance.TxtDescription.Text = TxtCategoryDescription.Text;

            HandleCategoryMaintenance();
        }

        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            SetCategoryDetailsData(DgvCategories);
        }

        private void SetupCategories(IEnumerable<CategoryViewModel> model)
        {
            Categories = model.ToList();

            PopulateGrid(DgvCategories, Categories, FormatCategories);

            if (!DgvCategories.HasValue())
                return;

            DgvCategories.SetSelectedRow(0);

            TxtCategoryId.Text = DgvCategories.GetSelectedRowValue<int>("CategoryId").ToString();
            TxtCategoryDescription.Text = DgvCategories.GetSelectedRowValue<string>("Description");
        }

        private void FormatCategories()
        {
            if (DgvCategories.IsEmpty())
                return;

            try
            {
                DisableColumns(DgvCategories, new[]
                {
                    "CategoryId", "Id", "Action", "DeletedOn", "InUse",
                });
            }
            catch { }
        }

        private void SetCategoryDetailsData(DataGridView grid)
        {
            if (grid.HasRowsSelected())
            {
                TxtCategoryId.Text = grid.GetSelectedRowValue<int>("CategoryId").ToString();
                TxtCategoryDescription.Text = grid.GetSelectedRowValue<string>("Description");

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>("InUse"),
                    BtnDeleteCategory
                );

                SetControlsStatus(true, BtnModifyCategory);

                return;
            }

            TxtCategoryId.Text = grid.FirstRow<int>("CategoryId").ToString();
            TxtCategoryDescription.Text = grid.FirstRow<string>("Description");

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

        private void HandleCategoryMaintenance()
        {
            if (!categoryMaintenance.ShowDialog().IsOkResponse())
                return;

            HandleCategories(categoryService.GetAll());

            TxtCategoryFilter.Clear();
        }

        #endregion

        #region Types

        //private void TxtCategoryFilter_TextChanged(object sender, EventArgs e)
        //{
        //    var text = TxtCategoryFilter.Text;

        //    var categories = new List<CategoryViewModel>(Categories);

        //    if (text.HasValue())
        //    {
        //        categories = categories.Where(CategoryFilter).ToList();
        //    }

        //    PopulateGrid(DgvCategories, categories, FormatCategories);

        //    bool CategoryFilter(CategoryViewModel category)
        //    {
        //        return category.Description.Contains(TxtCategoryFilter.Text);
        //    }
        //}

        //private void BtnNewCategory_Click(object sender, EventArgs e)
        //{
        //    categoryMaintenance.TxtCategoryId.Clear();
        //    categoryMaintenance.TxtDescription.Clear();

        //    HandleCategoryMaintenance();
        //}

        //private void BtnDeleteCategory_Click(object sender, EventArgs e)
        //{
        //    if (!DisplayQuestionMessage(StringResources.DeleteQuestion).IsYesResponse())
        //        return;

        //    var result = categoryService.Delete(
        //        Categories.Single(w => w.CategoryId == TxtCategoryId.Text.ToInt())
        //    );

        //    if (result.IsSuccess())
        //    {
        //        DisplayInformationMessage(StringResources.RecordDeleted);

        //        HandleCategories(categoryService.GetAll());

        //        TxtCategoryFilter.Clear();

        //        return;
        //    }

        //    DisplayErrorMessage(result.GetFailureError());
        //}

        //private void BtnModifyCategory_Click(object sender, EventArgs e)
        //{
        //    categoryMaintenance.TxtCategoryId.Text = TxtCategoryId.Text;
        //    categoryMaintenance.TxtDescription.Text = TxtCategoryDescription.Text;

        //    HandleCategoryMaintenance();
        //}

        //private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        //{
        //    SetCategoryDetailsData(DgvCategories);
        //}

        private void SetupTypes(IEnumerable<TypeViewModel> model)
        {
            Types = model.ToList();

            PopulateGrid(DgvTypes, Types, FormatTypes);

            if (!DgvTypes.HasValue())
                return;

            DgvTypes.SetSelectedRow(0);

            TxtTypeId.Text = DgvTypes.GetSelectedRowValue<int>("TypeId").ToString();
            TxtTypeDescription.Text = DgvTypes.GetSelectedRowValue<string>("Description");
            TxtTypeCategoryId.Text = DgvTypes.GetSelectedRowValue<int>("CategoryId").ToString();
            TxtTypeCategory.Text = DgvTypes.GetSelectedRowValue<string>("CategoryDescription");
        }

        private void FormatTypes()
        {
            if (DgvTypes.IsEmpty())
                return;

            try
            {
                DisableColumns(DgvTypes, new[]
                {
                    "Id",
                    "TypeId", 
                    "CategoryId", 
                    "Action",
                    "DeletedOn",
                    "InUse",
                });
            }
            catch { }
        }

        private void SetTypeDetailsData(DataGridView grid)
        {
            if (grid.HasRowsSelected())
            {
                TxtTypeId.Text = grid.GetSelectedRowValue<int>("TypeId").ToString();
                TxtTypeDescription.Text = grid.GetSelectedRowValue<string>("Description");
                TxtTypeCategoryId.Text = grid.GetSelectedRowValue<int>("CategoryId").ToString();
                TxtTypeCategory.Text = grid.GetSelectedRowValue<string>("CategoryDescription");

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>("InUse"),
                    BtnDeleteType
                );

                SetControlsStatus(true, BtnModifyType);

                return;
            }
            
            TxtTypeId.Text = grid.FirstRow<int>("TypeId").ToString();
            TxtTypeDescription.Text = grid.FirstRow<string>("Description");
            TxtTypeCategoryId.Text = grid.FirstRow<int>("CategoryId").ToString();
            TxtTypeCategory.Text = grid.FirstRow<string>("CategoryDescription");

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

        private void HandleTypeMaintenance()
        {
            if (!categoryMaintenance.ShowDialog().IsOkResponse())
                return;

            HandleTypes(typeService.GetAll());

            TxtTypeFilter.Clear();
        }

        #endregion
    }
}