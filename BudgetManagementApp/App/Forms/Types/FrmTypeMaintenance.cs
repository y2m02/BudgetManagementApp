using System;
using BudgetManagementApp.Entities.Extensions;
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
        }

        protected sealed override void SetLabels()
        {
            LoopControlsToSetLabels(Controls);
        }
    }
}