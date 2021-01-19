using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Categories;

namespace BudgetManagementApp.Forms
{
    public partial class FrmCategoryMaintenance : Form
    {
        private readonly ICategoryService categoryService;

        public FrmCategoryMaintenance(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var category = new CategoryViewModel
            {
                Id = TxtCategoryId.Text.HasValue()
                    ? TxtCategoryId.Text.ToInt()
                    : 0,
                Description = TxtDescription.Text
            }; 

            await categoryService.Upsert(category).ConfigureAwait(false);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
