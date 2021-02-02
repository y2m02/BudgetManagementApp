using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.Base
{
    public class Failure : BaseReturnViewModel
    {
        public Failure(string errorMessage)
        {
            ErrorMessage = StringResources.ProccessingError.Format(errorMessage);
        }

        public string ErrorMessage { get; }
    }
}