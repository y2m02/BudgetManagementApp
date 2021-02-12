using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Services.Services.Base
{
    public abstract class BaseService<TModel, TViewModel>
    {
        protected readonly IMapper mapper;

        protected BaseService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        protected abstract IBaseRepository<TModel> Repository { get; }

        public BaseReturnViewModel GetAll()
        {
            return HandleErrors(() =>
            {
                return Success(
                    mapper.Map<IEnumerable<TViewModel>>(
                        Repository.GetAll()
                    )
                );
            });
        }

        public BaseReturnViewModel Delete(BaseViewModel entity)
        {
            entity.SetDeletedOn();

            return Upsert(entity);
        }

        public BaseReturnViewModel Upsert(BaseViewModel entity)
        {
            return HandleErrors(
                () =>
                {
                    var validations = entity.Validate().ToList();

                    if (validations.Any())
                    {
                        return new Validation(validations);
                    }

                    switch (entity.Action)
                    {
                        case ActionType.Create:
                            Repository.Create(mapper.Map<TModel>(entity));
                            break;

                        case ActionType.Update:
                            Repository.Update(mapper.Map<TModel>(entity));
                            break;

                        case ActionType.Delete:
                            Repository.Delete(mapper.Map<TModel>(entity));
                            break;
                    }

                    return Success(true);
                }
            );
        }

        protected static BaseReturnViewModel HandleErrors(Func<BaseReturnViewModel> executor)
        {
            try
            {
                return executor();
            }
            catch (Exception ex)
            {
                return new Failure(ex.Message);
            }
        }

        protected BaseReturnViewModel HandleErrors<T>(
            Func<T, BaseReturnViewModel> executor,
            T request
        )
        {
            try
            {
                return executor(request);
            }
            catch (Exception ex)
            {
                return new Failure(ex.Message);
            }
        }

        protected static BaseReturnViewModel Success<T>(T model)
        {
            return new Success<T>(model);
        }
    }
}