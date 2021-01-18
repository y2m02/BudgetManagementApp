using System;
using System.Threading.Tasks;
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

        protected async Task<BaseViewModel> HandleErrors(Func<Task<BaseViewModel>> executor)
        {
            try
            {
                return await executor();
            }
            catch (Exception ex)
            {
                return new Error(ex.Message);
            }
        }

        protected async Task<BaseViewModel> HandleErrors<T>(
            Func<T, Task<BaseViewModel>> executor,
            T request
        )
        {
            try
            {
                return await executor(request);
            }
            catch (Exception ex)
            {
                return new Error(ex.Message);
            }
        }

        protected BaseViewModel Success<T>(T model)
        {
            return new Success<T>(model);
        }
    }
}