using System;

namespace BudgetManagementApp.Entities.Helpers
{
    public interface IDeletable
    {
        DateTime? DeletedOn { get; set; }
    }
}