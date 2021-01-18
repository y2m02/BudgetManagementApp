using System.Collections.Generic;
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
}