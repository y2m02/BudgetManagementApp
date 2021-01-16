using System;

namespace BudgetManagementApp.Entities
{
    public interface IDeletable
    {
        DateTime? DeletedOn { get; set; }
    }
}