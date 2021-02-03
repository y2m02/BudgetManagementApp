using System.Collections.Generic;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;

namespace BudgetManagementApp.Entities.Extensions
{
    public static class AccountingMovementExtensions
    {
        public static List<AccountingMovementViewModel> GetIncomes(
            this IEnumerable<AccountingMovementViewModel> movements
        )
        {
            return movements.PrettyWhere(w => w.IsAnIncome);
        }

        public static List<AccountingMovementViewModel> GetExpenses(
            this IEnumerable<AccountingMovementViewModel> movements
        )
        {
            return movements.PrettyWhere(w => !w.IsAnIncome);
        }
    }
}