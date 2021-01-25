using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Repositories.Repositories.Types
{
    public class TypeRepository :
        BaseRepository<Type>,
        ITypeRepository
    {
        public TypeRepository(
            BudgetManagementAppContext context
        ) : base(context)
        {
        }

        public IEnumerable<Type> GetAll()
        {
            return Context.Types
                .Include(w => w.SubTypes)
                .Include(w => w.Category)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderBy(w => w.Description)
                .AsNoTracking();
        }

        public void Create(Type entity)
        {
            Add(entity);
        }

        public void Update(Type entity)
        {
            Modify(entity);
        }

        public void Delete(Type entity)
        {
            Remove(entity);
        }
    }
}