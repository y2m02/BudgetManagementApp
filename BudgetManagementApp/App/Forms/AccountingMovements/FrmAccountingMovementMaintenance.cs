using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManagementApp.Forms.AccountingMovements
{
    public partial class FrmAccountingMovementMaintenance : BaseForm
    {
        public FrmAccountingMovementMaintenance()
        {
            InitializeComponent();
        }

        public AccountingMovementViewModel AccountingMovement { get; set; }

        public List<CategoryViewModel> Categories { get; set; }

        public List<TypeViewModel> Types { get; set; }

        public List<SubTypeViewModel> SubTypes { get; set; }

        private void FrmAccountingMovementMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();

            TxtAccountingMovementId.SetText(
                AccountingMovement.AccountingMovementId.ToString()
            );

            DtpDate.Value = AccountingMovement.Date > DateTime.MinValue
                ? AccountingMovement.Date
                : DateTime.Now;

            CbxSubType.SetData(
              SubTypes,
              FieldNames.SubTypeId,
              FieldNames.Description
            );

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

            CbxCategory.SetSelectedValue(AccountingMovement.CategoryId);

            CbxType.SetSelectedValue(AccountingMovement.TypeId);

            CbxSubType.SetSelectedValue(AccountingMovement.SubTypeId);

            TxtAmount.SetText(AccountingMovement.Amount.ToStringWithDecimals());

            TxtComment.SetText(AccountingMovement.Comment);
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
            var cbxCategory = (ComboBox)sender;

            var categoryId = cbxCategory.SafeSelectedValue<int>();

            var types = Types.PrettyWhere(w => w.CategoryId == categoryId);

            CbxType.SetData(
                types,
                FieldNames.TypeId,
                FieldNames.Description
            );

            if (types.Any()) return;

            CbxSubType.SetData(
                new List<SubTypeViewModel>(),
                FieldNames.SubTypeId,
                FieldNames.Description
            );
        }

        private void CbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbxType = (ComboBox)sender;;

            var typeId = cbxType.SafeSelectedValue<int>();

            CbxSubType.SetData(
                SubTypes.PrettyWhere(w => w.TypeId == typeId),
                FieldNames.SubTypeId,
                FieldNames.Description
            );
        }

        private void FrmAccountingMovementMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            CbxSubType.ClearDataSource();
            CbxType.ClearDataSource();
            CbxCategory.ClearDataSource();
        }
    }
}
