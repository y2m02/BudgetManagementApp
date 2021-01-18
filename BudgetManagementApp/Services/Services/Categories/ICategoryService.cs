using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using System.Threading.Tasks;

namespace BudgetManagementApp.Services.Services.Categories
{
    public interface ICategoryService
    {
        Task<BaseViewModel> GetAll();
        Task<BaseViewModel> Create(CategoryViewModel category);
        Task<BaseViewModel> Update(CategoryViewModel category);
        Task<BaseViewModel> Delete(CategoryViewModel category);
    }
}