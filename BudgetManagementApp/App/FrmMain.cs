using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Forms;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;

namespace BudgetManagementApp
{
    public partial class FrmMain : BaseForm
    {
        private readonly FrmCategoryMaintenance categoryMaintenance;
        private readonly ICategoryService categoryService;

        public FrmMain(
            FrmCategoryMaintenance categoryMaintenance,
            ICategoryService categoryService
        )
        {
            this.categoryMaintenance = categoryMaintenance;
            this.categoryService = categoryService;
            InitializeComponent();

            StringResources.Culture = CultureInfo.CurrentCulture;

            SetLabels();
        }

        private List<CategoryViewModel> Categories { get; set; }

        protected sealed override void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            LoopControlsToSetLabels(Controls);

            LoopControlsToSetLabels(TclBudgetManagement.Controls);

            LoopControlsToSetLabels(TabCategories.Controls);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HandleCategories(categoryService.GetAll());
        }

        private void TxtCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtCategoryFilter.Text;

            var categories = new List<CategoryViewModel>(Categories);

            if (text.HasValue())
            {
                categories = categories.Where(CategoryFilter).ToList();
            }

            PopulateGrid(DgvCategories, categories, FormatCategories);
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            categoryMaintenance.TxtCategoryId.Clear();
            categoryMaintenance.TxtDescription.Clear();

            HandleCategoryMaintenance();
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (DisplayQuestionMessage(StringResources.DeleteQuestion) != DialogResult.Yes) return;
            
            var result = categoryService.Delete(new CategoryViewModel
            {
                Id = TxtCategoryId.Text.ToInt(),
                DeletedOn = DateTime.Now
            });

            if (result.IsSuccess<bool>())
            {
                DisplayInformationMessage(StringResources.RecordDeleted);

                HandleCategories(categoryService.GetAll());
                
                TxtCategoryFilter.Clear();

                return;
            }

            DisplayErrorMessage(result.AsFailure().ErrorMessage);
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

        private static void PopulateGrid<TDataModel>(
            DataGridView grid,
            IEnumerable<TDataModel> list,
            Action formatGrid
        )
        {
            grid.DataSource = list.ToList();

            formatGrid();
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
                DgvCategories.Columns["CategoryId"].Visible = false;
                DgvCategories.Columns["Id"].Visible = false;
                DgvCategories.Columns["Action"].Visible = false;
            }
            catch
            {
            }
        }

        private bool CategoryFilter(CategoryViewModel category)
        {
            return category.Description.Contains(TxtCategoryFilter.Text);
        }

        private void SetCategoryDetailsData(DataGridView grid)
        {
            if (grid.SelectedRows.Count > 0)
            {
                TxtCategoryId.Text = grid.GetSelectedRowValue<int>("CategoryId").ToString();
                TxtCategoryDescription.Text = grid.GetSelectedRowValue<string>("Description");

                SetControlsStatus(true, BtnModifyCategory, BtnDeleteCategory);

                return;
            }

            TxtCategoryDescription.Text = grid.GetRowValue<string>(0, "Description");

            SetControlsStatus(false, BtnModifyCategory, BtnDeleteCategory);
        }

        private void HandleCategories(BaseViewModel result)
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
            if (categoryMaintenance.ShowDialog() != DialogResult.OK)
                return;

            var result = categoryService.GetAll();

            HandleCategories(result);

            TxtCategoryFilter.Clear();
        }
    }
}