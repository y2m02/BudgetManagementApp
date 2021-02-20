using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
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

        public SubTypeViewModel SubType { get; set; }

        public List<TypeViewModel> Types { get; set; }

        public List<CategoryViewModel> Categories { get; set; }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Upsert(subTypeService.Upsert, new SubTypeViewModel
            {
                Id = TxtSubTypeId.Text.ToIntOrDefault(),
                Description = TxtDescription.Text,
                TypeId = CbxType.SafeSelectedValue<int>(),
                CategoryId = CbxCategory.SafeSelectedValue<int>()
            });

            if (!DialogResult.IsOkResponse())
                return;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSubTypeMaintenance_Load(object sender, EventArgs e)
        {
            AddLoadingPointer(() =>
            {
                SetLabels();

                TxtSubTypeId.SetText(SubType.SubTypeId.ToString());

                TxtDescription.SetText(SubType.Description);

                CbxType.SetData(
                  Types,
                  FieldNames.TypeId,
                  FieldNames.Description
                );

                CbxCategory.SetData(
                  Categories,
                  FieldNames.CategoryId,
                  FieldNames.Description
                );

                CbxCategory.SetSelectedValue(SubType.CategoryId);

                CbxType.SetSelectedValue(SubType.TypeId);
            });
        }

        protected sealed override void SetLabels()
        {
            LoopControlsToSetLabels(Controls);
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbxCategory = (ComboBox)sender;

            var categoryId = cbxCategory.SafeSelectedValue<int>();

            CbxType.SetData(
                Types.PrettyWhere(w => w.CategoryId == categoryId),
                FieldNames.TypeId,
                FieldNames.Description
            );
        }

        private void FrmSubTypeMaintenance_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            CbxType.ClearDataSource();
            CbxCategory.ClearDataSource();
        }
    }
}