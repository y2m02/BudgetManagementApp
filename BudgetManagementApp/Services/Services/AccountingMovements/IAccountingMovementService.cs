using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Services.Services.Base;

namespace BudgetManagementApp.Services.Services.AccountingMovements
{
    public interface IAccountingMovementService : IBaseService
    {
        BaseReturnViewModel GetIncomes();
        BaseReturnViewModel GetExpenses();
    }
}