using System;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.AccountingMovements
{
    public class AccountingMovementViewModel : BaseViewModel
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int AccountingMovementId => Id;

        public int CategoryId { get; set; }

        public string CategoryDescription { get; set; }

        public int TypeId { get; set; }

        public string TypeDescription { get; set; }

        public int SubTypeId { get; set; }

        public string SubTypeDescription { get; set; }

        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public bool IsAnIncome { get; set; }

        public string Comment { get; set; }

        public override IEnumerable<string> Validate()
        {
            if (CategoryDescription.IsEmpty())
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Category)
                );
            }

            if (TypeDescription.IsEmpty())
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Type)
                );
            }

            if (SubTypeDescription.IsEmpty())
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.SubType)
                );
            }

            if (Date.IsGreaterThan(DateTime.Today))
            {
                yield return StringResources.DateGreaterThanValidation.Format(
                    StringResourcesHandler.GetString(FieldNames.Date),
                    StringResourcesHandler.GetString(FieldNames.Today)
                );
            }

            if (Amount <= 0)
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Amount)
                );
            }
        }
    }
}