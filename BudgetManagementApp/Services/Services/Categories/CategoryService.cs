using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Repositories.Repositories.Categories;

namespace BudgetManagementApp.Services.Services.Categories
{
    public class CategoryService :
        BaseService<CategoryViewModel, Category>,
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

        public new BaseViewModel Upsert(CategoryViewModel entity)
        {
            return base.Upsert(entity);
        }

        public BaseViewModel Delete(CategoryViewModel entity)
        {
            return Remove(entity);
        }
    }
}