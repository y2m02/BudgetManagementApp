namespace BudgetManagementApp.Entities.ViewModels.Base
{
    public class Success<T> : BaseReturnViewModel
    {
        public Success(T model)
        {
            Model = model;
        }

        public T Model { get; }
    }
}