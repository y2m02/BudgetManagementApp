using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Repositories.Repositories.Base;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BudgetManagementApp.Repositories.Repositories.SubTypes
{
    public class SubTypeRepository :
        BaseRepository<SubType>,
        ISubTypeRepository
    {
        public SubTypeRepository(
            BudgetManagementAppContext context
        ) : base(context)
        {
        }

        public IEnumerable<SubType> GetAll()
        {
            return Context.SubTypes
                .Include(w => w.AccountingMovements)
                .Include(w => w.Type)
                .Include(w => w.Type.Category)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderBy(w => w.Description)
                .AsNoTracking();
        }

        public void Create(SubType entity)
        {
            Add(entity);
        }

        public void Update(SubType entity)
        {
            Modify(entity);
        }

        public void Delete(SubType entity)
        {
            Remove(entity);
        }
    }
}