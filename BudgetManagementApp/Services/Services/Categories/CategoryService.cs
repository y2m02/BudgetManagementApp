using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Repositories.Repositories.Categories;
using BudgetManagementApp.Services.Services.Base;

namespace BudgetManagementApp.Services.Services.Categories
{
    public class CategoryService :
        BaseService<Category, CategoryViewModel>,
        ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(
            IMapper mapper,
            ICategoryRepository categoryRepository
        ) : base(mapper)
        {
            this.categoryRepository = categoryRepository;
        }

        protected override IBaseRepository<Category> Repository => categoryRepository;
    }
}