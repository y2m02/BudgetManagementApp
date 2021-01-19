using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Properties;
using BudgetManagementApp.Services.Services.Categories;

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

        private void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            string[] controlsToSetLabels = {"Lbl", "Btn", "Tab"};

            LoopControlsToSetLabels(Controls);

            LoopControlsToSetLabels(TclBudgetManagement.Controls);

            LoopControlsToSetLabels(TabCategories.Controls);

            void LoopControlsToSetLabels(IEnumerable controls)
            {
                foreach (var ctrl in controls)
                {
                    var control = (Control) ctrl;

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

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            var c = await categoryService.GetAll().ConfigureAwait(false);

            if (c is Success<IEnumerable<CategoryViewModel>> success)
            {
                DgvCategories.DataSource = success.Model;
            }
        }
    }
}