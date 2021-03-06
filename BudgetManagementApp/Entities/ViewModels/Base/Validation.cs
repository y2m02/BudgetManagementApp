using System.Collections.Generic;

namespace BudgetManagementApp.Entities.ViewModels.Base
{
    public class Validation : BaseReturnViewModel
    {
        public Validation(IEnumerable<string> validationErrors)
        {
            ValidationErrors = validationErrors;
        }

        public IEnumerable<string> ValidationErrors { get; }
    }
}