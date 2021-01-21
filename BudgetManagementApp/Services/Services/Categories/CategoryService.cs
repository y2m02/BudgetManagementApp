using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Repositories.Repositories.Categories;

namespace BudgetManagementApp.Services.Services.Categories
{
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(
            IMapper mapper,
            ICategoryRepository categoryRepository
        ) : base(mapper)
        {
            this.categoryRepository = categoryRepository;
        }

        public BaseViewModel GetAll()
        {
            return HandleErrors(() =>
            {
                return Success(
                    Mapper.Map<IEnumerable<CategoryViewModel>>(
                        categoryRepository.GetAll()
                    )
                );
            });
        }

        public BaseViewModel Create(CategoryViewModel category)
        {
            return Upsert(category);
        }

        public BaseViewModel Update(CategoryViewModel category)
        {
            return Upsert(category);
        }

        public BaseViewModel Delete(CategoryViewModel category)
        {
            category.SetDeletedOn();

            return Upsert(category);
        }

        public BaseViewModel Upsert(CategoryViewModel category)
        {
            return HandleErrors(
                () =>
                {
                    var validations = category.Validate().ToList();

                    if (validations.Any())
                    {
                        return new Validation(validations);
                    }

                    switch (category.Action)
                    {
                        case ActionType.Create:
                            categoryRepository.Create(Mapper.Map<Category>(category));
                            break;

                        case ActionType.Update:
                            categoryRepository.Update(Mapper.Map<Category>(category));
                            break;

                        case ActionType.Delete:
                            categoryRepository.Delete(Mapper.Map<Category>(category));
                            break;
                    }

                    return Success(true);
                }
            );
        }
    }
}