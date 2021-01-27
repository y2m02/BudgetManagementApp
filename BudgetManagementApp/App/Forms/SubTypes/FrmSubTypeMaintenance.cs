using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.SubTypes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetManagementApp.Forms.SubTypes
{
    public partial class FrmSubTypeMaintenance : BaseForm
    {
        private readonly ISubTypeService subTypeService;

        public FrmSubTypeMaintenance(ISubTypeService subTypeService)
        {
            this.subTypeService = subTypeService;
            InitializeComponent();
        }

        public List<TypeViewModel> Types { get; set; }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Upsert(subTypeService.Upsert, new SubTypeViewModel
            {
                Id = TxtSubTypeId.Text.ToIntOrDefault(),
                Description = TxtDescription.Text,
                TypeId = CbxType.SafeSelectedValue<int>(),
                CategoryId = CbxCategory.SafeSelectedValue<int>()
            });

            if (!DialogResult.IsOkResponse()) return;

            CbxType.ClearDataSource();
            CbxCategory.ClearDataSource();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CbxType.ClearDataSource();
            CbxCategory.ClearDataSource();

            Close();
        }

        private void FrmSubTypeMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        protected sealed override void SetLabels()
        {
            Text = StringResources.SubTypeMaintenance;

            LoopControlsToSetLabels(Controls);
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoryId = CbxCategory.SafeSelectedValue<int>();

            if (CbxCategory.HasDataSource() && categoryId == 0)
            {
                categoryId = CbxCategory.SafeSelectedValue<CategoryViewModel>().CategoryId;
            }

            CbxType.SetData(
                Types.PrettyWhere(w => w.CategoryId == categoryId),
                FieldNames.TypeId,
                FieldNames.Description
            );
        }
    }
}
