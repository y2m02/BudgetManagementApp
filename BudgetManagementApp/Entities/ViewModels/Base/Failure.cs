using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.Base
{
    public class Failure : BaseReturnViewModel
    {
        public Failure(string errorMessage)
        {
            ErrorMessage = string.Format(
                StringResources.ProccessingError,
                errorMessage
            );
        }

        public string ErrorMessage { get; }
    }
}