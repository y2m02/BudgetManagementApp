using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task Create(Category category);
        Task Update(Category category);
        Task Delete(Category category);
    }

    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(BudgetManagementAppContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await Context.Categories
                .Where(w => !w.DeletedOn.HasValue)
                .ToListAsync();
        }

        public async Task Create(Category category)
        {
            await base.Create(category);
        }

        public async Task Update(Category category)
        {
            Context.Categories.Attach(category);

            AddPropertiesToModify(category, new List<string>
            {
                nameof(category.Description)
            });

            await Save();
        }

        public async Task Delete(Category category)
        {
            Context.Categories.Attach(category);

            await base.Delete(category);
        }
    }
}