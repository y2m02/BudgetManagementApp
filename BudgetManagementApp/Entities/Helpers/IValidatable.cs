using System.Collections.Generic;

namespace BudgetManagementApp.Entities.Helpers
{
    public interface IValidatable
    {
        IEnumerable<string> Validate();
    }
}