using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManagementApp
{
    public partial class FrmMain : BaseForm
    {
        private readonly ICategoryService categoryService;

        public FrmMain(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            InitializeComponent();

            StringResources.Culture = CultureInfo.CurrentCulture;

            SetLabels();
        }
        private List<CategoryViewModel> Categories { get; set; }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            var (model, error) = (await categoryService.GetAll().ConfigureAwait(false)).DownGrade<CategoryViewModel>();

            Categories = model.ToList();

            PopulateGrid(DgvCategories, Categories, FormatCategories);

            if (error.HasValue())
            {
                DisplayErrorMessage(error);
            }
        }

        private void TxtCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            var text = TxtCategoryFilter.Text;

            if (text.HasValue())
            {
                PopulateGrid(
                    DgvCategories,
                    Categories.Where(
                        w => w.Description.Contains(text)
                    ),
                    FormatCategories
                );

                return;
            }

            PopulateGrid(DgvCategories, Categories, FormatCategories);
        }

        private void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            string[] controlsToSetLabels = { "Lbl", "Btn", "Tab" };

            LoopControlsToSetLabels(Controls);

            LoopControlsToSetLabels(TclBudgetManagement.Controls);

            LoopControlsToSetLabels(TabCategories.Controls);

            void LoopControlsToSetLabels(IEnumerable controls)
            {
                foreach (var ctrl in controls)
                {
                    var control = (Control)ctrl;

                    var name = control.Name;

                    if (controlsToSetLabels.Any(c => name.StartsWith(c)))
                    {
                        control.Text = StringResources.ResourceManager.GetString(
                            name.Substring(3, name.Length - 3),
                            StringResources.Culture
                        );
                    }
                }
            }
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
            catch { }
        }
    }
}