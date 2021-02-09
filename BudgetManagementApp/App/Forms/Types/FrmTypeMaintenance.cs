using System;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Services.Services.Types;

namespace BudgetManagementApp.Forms.Types
{
    public partial class FrmTypeMaintenance : BaseForm
    {
        private readonly ITypeService typeService;

        public FrmTypeMaintenance(ITypeService typeService)
        {
            this.typeService = typeService;

            InitializeComponent();
        }

        public TypeViewModel Type { get; set; }

        public List<CategoryViewModel> Categories { get; set; }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Upsert(typeService.Upsert, new TypeViewModel
            {
                Id = TxtTypeId.Text.ToIntOrDefault(),
                Description = TxtDescription.Text,
                CategoryId = CbxCategory.SafeSelectedValue<int>()
            });
        }

        private void FrmTypeMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();

            TxtTypeId.SetText(Type.TypeId.ToString());

            TxtDescription.SetText(Type.Description);
            
            CbxCategory.SetData(
              Categories,
              FieldNames.CategoryId,
              FieldNames.Description
            );

            CbxCategory.SetSelectedValue(Type.CategoryId);
        }

        protected sealed override void SetLabels()
        {
            LoopControlsToSetLabels(Controls);
        }

        private void FrmTypeMaintenance_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            CbxCategory.ClearDataSource();
        }
    }
}