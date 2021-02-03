using System.Collections.Generic;
using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Repositories.Repositories.AccountingMovements;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Services.Services.Base;

namespace BudgetManagementApp.Services.Services.AccountingMovements
{
    public class AccountingMovementService :
        BaseService<AccountingMovement, AccountingMovementViewModel>,
        IAccountingMovementService
    {
        private readonly IAccountingMovementRepository accountingMovementRepository;

        public AccountingMovementService(
            IMapper mapper,
            IAccountingMovementRepository accountingMovementRepository
        ) : base(mapper)
        {
            this.accountingMovementRepository = accountingMovementRepository;
        }

        protected override IBaseRepository<AccountingMovement> Repository => accountingMovementRepository;

        public BaseReturnViewModel GetIncomes()
        {
            return HandleErrors(() =>
            {
                return Success(
                    mapper.Map<IEnumerable<AccountingMovementViewModel>>(
                        accountingMovementRepository.GetIncomes()
                    )
                );
            });
        }

        public BaseReturnViewModel GetExpenses()
        {
            return HandleErrors(() =>
            {
                return Success(
                    mapper.Map<IEnumerable<AccountingMovementViewModel>>(
                        accountingMovementRepository.GetExpenses()
                    )
                );
            });
        }
    }
}