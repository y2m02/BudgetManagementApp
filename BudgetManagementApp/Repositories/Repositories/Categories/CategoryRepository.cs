using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Repositories.Repositories.Categories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(BudgetManagementAppContext context) : base(context)
        {
        }

        public IEnumerable<Category> GetAll()
        {
            return Context.Categories
                .Include(w => w.Types)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderBy(w => w.Description)
                .AsNoTracking();
        }

        public void Create(Category entity)
        {
            Add(entity);
        }

        public void Update(Category entity)
        {
            Modify(entity);
        }

        public void Delete(Category entity)
        {
            Remove(entity);
        }
    }
}