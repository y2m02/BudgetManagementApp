using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories.Categories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(BudgetManagementAppContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await Context.Categories
                .Where(w => !w.DeletedOn.HasValue)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task Create(Category category)
        {
            await base.Create(category).ConfigureAwait(false);
        }

        public async Task Update(Category category)
        {
            Context.Categories.Attach(category);

            AddPropertiesToModify(category, new List<string>
            {
                nameof(category.Description)
            });

            await Save().ConfigureAwait(false);
        }

        public async Task Delete(Category category)
        {
            Context.Categories.Attach(category);

            await base.Delete(category).ConfigureAwait(false);
        }
    }
}