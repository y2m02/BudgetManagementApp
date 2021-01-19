using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Forms;
using BudgetManagementApp.Resources;

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

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            var (model, error) = (await categoryService.GetAll().ConfigureAwait(false)).DownGrade<CategoryViewModel>();

            SetupCategories(model);

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
                        control.Text = StringResourcesHandler.GetString(
                            name.Substring(3, name.Length - 3)
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

        private void SetupCategories(IEnumerable<CategoryViewModel> model)
        {
            Categories = model.ToList();

            PopulateGrid(DgvCategories, Categories, FormatCategories);

            if (!DgvCategories.HasValue()) return;

            DgvCategories.Rows[0].Selected = true;

            LblCategoryId.Text = DgvCategories.SelectedRows[0].Cells[0].Value.ToString();
            TxtCategoryDescription.Text = DgvCategories.SelectedRows[0].Cells[1].Value.ToString();

            BtnModifyCategory.Enabled = true;
            BtnDeleteCategory.Enabled = true;
        }

        private async void BtnNewCategory_Click(object sender, EventArgs e)
        {
            var a = categoryMaintenance.ShowDialog();

            if (a != DialogResult.OK) return;

            var (model, error) = (await categoryService.GetAll().ConfigureAwait(false)).DownGrade<CategoryViewModel>();

            SetupCategories(model);
        }
    }
}