using System.Collections.Generic;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Repositories.Repositories.AccountingMovements
{
    public interface IAccountingMovementRepository : IBaseRepository<AccountingMovement>
    {
        IEnumerable<AccountingMovement> GetIncomes();
        IEnumerable<AccountingMovement> GetExpenses();
    }
}