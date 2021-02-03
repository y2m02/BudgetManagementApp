using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.AccountingMovements
{
    public class AccountingMovementViewModel: BaseViewModel
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int AccountingMovementId => Id;

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public bool IsAnIncome { get; set; }

        public string Comment { get; set; }

        public int SubTypeId { get; set; }

        public int? ProjectId { get; set; }

        public override IEnumerable<string> Validate()
        {
            throw new NotImplementedException();
            //if (Name.IsEmpty())
            //{
            //    yield return string.Format(
            //        StringResources.FieldRequired,
            //        StringResourcesHandler.GetString(FieldNames.Name)
            //    );
            //}
        }
    }
}
