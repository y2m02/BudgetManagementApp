using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using System.Threading.Tasks;

namespace BudgetManagementApp.Services.Services.Categories
{
    public interface ICategoryService
    {
        BaseViewModel GetAll();
        BaseViewModel Create(CategoryViewModel category);
        BaseViewModel Update(CategoryViewModel category);
        BaseViewModel Upsert(CategoryViewModel category);
        BaseViewModel Delete(CategoryViewModel category);
    }
}