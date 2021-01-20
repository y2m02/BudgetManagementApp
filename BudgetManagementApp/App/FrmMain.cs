using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
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
            var (model, error) = categoryService.GetAll().DownGrade<CategoryViewModel>();

            SetupCategories(model);

            if (error.HasValue())
            {
                DisplayErrorMessage(error);
            }
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
            var result = categoryMaintenance.ShowDialog();

            if (result != DialogResult.OK) return;

            var (model, error) = categoryService.GetAll().DownGrade<CategoryViewModel>();

            if (error.HasValue())
            {
                DisplayErrorMessage(error);
                return;
            }

            TxtCategoryFilter.Clear();

            SetupCategories(model);
        }

        private void BtnModifyCategory_Click(object sender, EventArgs e)
        {
            categoryMaintenance.TxtCategoryId.Text = DgvCategories.GetSelectedRowValue<int>("CategoryId").ToString();
            categoryMaintenance.TxtDescription.Text = DgvCategories.GetSelectedRowValue<string>("Description");

            BtnNewCategory_Click(sender, e);
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

            if (!DgvCategories.HasValue()) return;

            DgvCategories.SetSelectedRow(0);

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
                TxtCategoryDescription.Text = grid.GetSelectedRowValue<string>("Description");

                SetControlsStatus(true, BtnModifyCategory, BtnDeleteCategory);

                return;
            }

            TxtCategoryDescription.Text = grid.GetRowValue<string>(0, "Description");

            SetControlsStatus(false, BtnModifyCategory, BtnDeleteCategory);
        }
    }
}