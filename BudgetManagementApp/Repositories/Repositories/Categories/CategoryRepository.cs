using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BudgetManagementApp.Entities.Models;

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

        public void Create(Category category)
        {
            base.Create(category);
        }

        public void Update(Category category)
        {
            base.Update(category);
        }

        public void Delete(Category category)
        {
            base.Delete(category);
        }
    }
}