using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Repositories.Repositories.AccountingMovements
{
    public class AccountingMovementRepository :
        BaseRepository<AccountingMovement>,
        IAccountingMovementRepository
    {
        public AccountingMovementRepository(
            BudgetManagementAppContext context
        ) : base(context) { }

        public IEnumerable<AccountingMovement> GetAll()
        {
            return Context.AccountingMovements
                .Include(w => w.SubType)
                .Include(w => w.SubType.Type)
                .Include(w => w.SubType.Type.Category)
                .Include(w => w.Project)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderByDescending(w => w.AccountingMovementId)
                .AsNoTracking();
        }

        public void Create(AccountingMovement entity)
        {
            Add(entity);
        }

        public void Update(AccountingMovement entity)
        {
            Modify(entity);
        }

        public void Delete(AccountingMovement entity)
        {
            Remove(entity);
        }

        public IEnumerable<AccountingMovement> GetIncomes()
        {
            return Context.AccountingMovements
                .Where(w => w.IsAnIncome)
                .Include(w => w.SubType)
                .Include(w => w.SubType.Type)
                .Include(w => w.SubType.Type.Category)
                .Include(w => w.Project)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderByDescending(w => w.AccountingMovementId)
                .AsNoTracking();
        }

        public IEnumerable<AccountingMovement> GetExpenses()
        {
            return Context.AccountingMovements
                .Where(w => !w.IsAnIncome)
                .Include(w => w.SubType)
                .Include(w => w.SubType.Type)
                .Include(w => w.SubType.Type.Category)
                .Include(w => w.Project)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderByDescending(w => w.AccountingMovementId)
                .AsNoTracking();
        }

        public IEnumerable<AccountingMovement> GetIncomesByProjectId(int projectId)
        {
            return Context.AccountingMovements
                .Where(w => w.IsAnIncome && w.ProjectId == projectId)
                .Include(w => w.SubType)
                .Include(w => w.SubType.Type)
                .Include(w => w.SubType.Type.Category)
                .Include(w => w.Project)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderByDescending(w => w.AccountingMovementId)
                .AsNoTracking();
        }

        public IEnumerable<AccountingMovement> GetExpensesByProjectId(int projectId)
        {
            return Context.AccountingMovements
                .Where(w => !w.IsAnIncome && w.ProjectId == projectId)
                .Include(w => w.SubType)
                .Include(w => w.SubType.Type)
                .Include(w => w.SubType.Type.Category)
                .Include(w => w.Project)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderByDescending(w => w.AccountingMovementId)
                .AsNoTracking();
        }
    }
}