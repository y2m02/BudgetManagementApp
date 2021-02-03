using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
using System;
using System.Collections.Generic;

namespace BudgetManagementApp.Forms.AccountingMovements
{
    public partial class FrmAccountingMovementMaintenance : BaseForm
    {
        public FrmAccountingMovementMaintenance()
        {
            InitializeComponent();
        }

        public bool IsAnIncome { get; set; }

        public List<TypeViewModel> Types { get; set; }

        public List<SubTypeViewModel> SubTypes { get; set; }

        private void FrmAccountingMovementMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbxCategory = CbxCategory;

            var categoryId = cbxCategory.SafeSelectedValue<int>();

            if (cbxCategory.HasDataSource() && categoryId == 0)
            {
                categoryId = cbxCategory.SafeSelectedValue<CategoryViewModel>().CategoryId;
            }

            CbxType.SetData(
                Types.PrettyWhere(w => w.CategoryId == categoryId),
                FieldNames.TypeId,
                FieldNames.Description
            );
        }

        private void CbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbxType = CbxType;

            var typeId = cbxType.SafeSelectedValue<int>();

            if (cbxType.HasDataSource() && typeId == 0)
            {
                typeId = cbxType.SafeSelectedValue<TypeViewModel>().TypeId;
            }

            CbxSubType.SetData(
                Types.PrettyWhere(w => w.TypeId == typeId),
                FieldNames.SubTypeId,
                FieldNames.Description
            );
        }
    }
}
