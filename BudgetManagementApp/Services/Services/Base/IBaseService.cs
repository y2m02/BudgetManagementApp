using BudgetManagementApp.Entities.ViewModels.Base;

namespace BudgetManagementApp.Services.Services.Base
{
    public interface IBaseService
    {
        BaseReturnViewModel GetAll();
        BaseReturnViewModel Upsert(BaseViewModel entity);
        BaseReturnViewModel Delete(BaseViewModel entity);
    }
}