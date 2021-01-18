using AutoMapper;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Repositories.Repositories.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<BaseViewModel> GetAll()
        {
            return await HandleErrors(async () =>
            {
                return Success(
                    Mapper.Map<IEnumerable<CategoryViewModel>>(
                        await categoryRepository
                            .GetAll()
                            .ConfigureAwait(false)
                    )
                );
            });
        }

        public async Task<BaseViewModel> Create(CategoryViewModel category)
        {
            return await Upsert(category);
        }

        public async Task<BaseViewModel> Update(CategoryViewModel category)
        {
            return await Upsert(category);
        }

        public async Task<BaseViewModel> Delete(CategoryViewModel category)
        {
            category.SetDeletedOn();

            return await Upsert(category);
        }

        private async Task<BaseViewModel> Upsert(CategoryViewModel category)
        {
            return await HandleErrors(
                async () =>
                {
                    switch (category.Action)
                    {
                        case ActionType.Create:
                            await categoryRepository
                                .Create(Mapper.Map<Category>(category))
                                .ConfigureAwait(false);
                            break;

                        case ActionType.Update:
                            await categoryRepository
                                .Update(Mapper.Map<Category>(category))
                                .ConfigureAwait(false);
                            break;

                        case ActionType.Delete:
                            await categoryRepository
                                .Delete(Mapper.Map<Category>(category))
                                .ConfigureAwait(false);
                            break;
                    }

                    return Success(
                        Mapper.Map<IEnumerable<CategoryViewModel>>(
                            await categoryRepository
                                .GetAll()
                                .ConfigureAwait(false)
                        )
                    );
                }
            );
        }
    }
}