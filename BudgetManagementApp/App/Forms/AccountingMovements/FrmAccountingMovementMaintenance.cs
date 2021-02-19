using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Services.Services.AccountingMovements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManagementApp.Forms.AccountingMovements
{
    public partial class FrmAccountingMovementMaintenance : BaseForm
    {
        private readonly IAccountingMovementService accountingMovementService;

        public FrmAccountingMovementMaintenance(
            IAccountingMovementService accountingMovementService
        )
        {
            InitializeComponent();
            this.accountingMovementService = accountingMovementService;
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

            CbxCategory.SetData(
              Categories,
              FieldNames.CategoryId,
              FieldNames.Description
            );

            CbxCategory.SetSelectedValue(AccountingMovement.CategoryId);

            CbxType.SetData(
              Types.PrettyWhere(w => w.CategoryId == AccountingMovement.CategoryId),
              FieldNames.TypeId,
              FieldNames.Description
            );

            CbxType.SetSelectedValue(AccountingMovement.TypeId);

            CbxSubType.SetData(
              SubTypes.PrettyWhere(w => w.TypeId == AccountingMovement.TypeId),
              FieldNames.SubTypeId,
              FieldNames.Description
            );

            CbxSubType.SetSelectedValue(AccountingMovement.SubTypeId);

            TxtAmount.SetText(
                AccountingMovement.Amount.ToString(CultureData.GetEnglishCulture())
            );

            TxtComment.SetText(AccountingMovement.Comment);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Upsert(accountingMovementService.Upsert, new AccountingMovementViewModel
            {
                Id = TxtAccountingMovementId.Text.ToIntOrDefault(),
                Date = DtpDate.Value.Date,
                Amount = TxtAmount.Text.ToDecimalOrDefault(),
                Comment = TxtComment.Text,
                IsAnIncome = AccountingMovement.IsAnIncome,
                ProjectId = AccountingMovement.ProjectId,
                CategoryId = CbxCategory.SafeSelectedValue<int>(),
                TypeId = CbxType.SafeSelectedValue<int>(),
                SubTypeId = CbxSubType.SafeSelectedValue<int>(),
            });

            GlobalProperties.ProjectsNeedToBeUpdated = true;
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

            if (types.Any())
                return;

            CbxSubType.ClearDataSource();
        }

        private void CbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbxType = (ComboBox)sender;

            var typeId = cbxType.SafeSelectedValue<int>();

            CbxSubType.SetData(
                SubTypes.PrettyWhere(w => w.TypeId == typeId),
                FieldNames.SubTypeId,
                FieldNames.Description
            );
        }

        private void FrmAccountingMovementMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            CbxCategory.ClearDataSource();
            CbxType.ClearDataSource();
            CbxSubType.ClearDataSource();
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtOnlyDecimals_KeyPress(sender, e);
        }
    }
}
