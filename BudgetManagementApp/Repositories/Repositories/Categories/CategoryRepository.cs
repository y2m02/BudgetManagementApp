using System.Collections.Generic;
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
                .Where(w => !w.DeletedOn.HasValue)
                .OrderBy(w => w.Description);
        }

        public void Create(Category category)
        {
            base.Create(category);
        }

        public void Update(Category category)
        {
            Context.Categories.Attach(category);

            AddPropertiesToModify(category, new List<string>
            {
                nameof(category.Description),
            });

            Save();
        }

        public void Delete(Category category)
        {
            Context.Categories.Attach(category);

            base.Delete(category);
        }
    }
}