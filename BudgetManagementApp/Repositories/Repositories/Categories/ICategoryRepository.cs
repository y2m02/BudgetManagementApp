using System.Collections.Generic;
using System.Threading.Tasks;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories.Categories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}