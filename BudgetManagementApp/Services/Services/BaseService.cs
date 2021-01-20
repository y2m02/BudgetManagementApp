using System;
using AutoMapper;
using BudgetManagementApp.Entities.ViewModels;

namespace BudgetManagementApp.Services.Services
{
    public abstract class BaseService
    {
        protected readonly IMapper Mapper;

        protected BaseService(IMapper mapper)
        {
            Mapper = mapper;
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