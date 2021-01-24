using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Services.Services
{
    public interface IBaseService<in TViewModel>
    {
        BaseViewModel GetAll();
        BaseViewModel Upsert(TViewModel entity);
        BaseViewModel Delete(TViewModel entity);
    }

    public abstract class BaseService<TViewModel, TModel>
        where TViewModel : BaseViewModel, IValidatable
    {
        private readonly IMapper mapper;

        protected BaseService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        protected abstract IBaseRepository<TModel> Repository { get; }

        public BaseViewModel GetAll()
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

        protected BaseViewModel Remove(TViewModel entity)
        {
            entity.SetDeletedOn();

            return Upsert(entity);
        }

        protected BaseViewModel Upsert(TViewModel entity)
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

        protected static BaseViewModel HandleErrors(Func<BaseViewModel> executor)
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

        protected BaseViewModel HandleErrors<T>(
            Func<T, BaseViewModel> executor,
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

        protected static BaseViewModel Success<T>(T model)
        {
            return new Success<T>(model);
        }
    }
}