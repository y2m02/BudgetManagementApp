using System;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;

namespace BudgetManagementApp.Forms.Categories
{
    public partial class FrmCategoryMaintenance : BaseForm
    {
        private readonly ICategoryService categoryService;

        public FrmCategoryMaintenance(ICategoryService categoryService)
        {
            this.categoryService = categoryService;

            InitializeComponent();
        }

        private void FrmCategoryMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        protected sealed override void SetLabels()
        {
            Text = StringResources.CategoryMaintenance;

            LoopControlsToSetLabels(Controls);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Upsert(categoryService.Upsert, new CategoryViewModel
            {
                Id = TxtCategoryId.Text.ToIntOrDefault(),
                Description = TxtDescription.Text,
            });
        }
    }
}