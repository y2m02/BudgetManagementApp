using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;

namespace BudgetManagementApp.Forms
{
    public partial class FrmCategoryMaintenance : BaseForm
    {
        private readonly ICategoryService categoryService;

        public FrmCategoryMaintenance(ICategoryService categoryService)
        {
            this.categoryService = categoryService;

            InitializeComponent();

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
            var result = categoryService.Upsert(new CategoryViewModel
            {
                Id = TxtCategoryId.Text.HasValue()
                    ? TxtCategoryId.Text.ToInt()
                    : 0,
                Description = TxtDescription.Text
            });

            if (result is Success<bool>)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
