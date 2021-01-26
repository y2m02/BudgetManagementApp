using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.SubTypes;

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
                TypeId = CbxType.SafeSelectedValue<int>()
            });
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
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

        protected void Upsert(
            Func<BaseViewModel, BaseReturnViewModel> executor,
            BaseViewModel model
        )
        {
            var result = executor(model);

            if (result.HasValidations())
            {
                var message = result.GetValidations().Join("\n");

                DisplayExclamationMessage(message);

                return;
            }

            if (result.IsSuccess())
            {
                DialogResult = DialogResult.OK;

                Close();

                return;
            }

            DialogResult = DialogResult.None;

            DisplayErrorMessage(result.GetFailureError());
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // why this is failing
            //var a = CbxCategory.SelectedValue;

            //fixed()

            //CbxType.SetData(
            //    Types.Where(
            //        w => w.CategoryId == a
            //    ).ToList(),
            //    "TypeId",
            //    "Description"
            //);
        }
    }
}
