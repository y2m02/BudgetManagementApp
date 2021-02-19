using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using System.Collections.Generic;

namespace BudgetManagementApp.Entities
{
    public class DataViewModel : BaseReturnViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IEnumerable<TypeViewModel> Types { get; set; }
        public IEnumerable<SubTypeViewModel> SubTypes { get; set; }
        public IEnumerable<ProjectViewModel> Projects { get; set; }
        public IEnumerable<AccountingMovementViewModel> AccountingMovements { get; set; }
    }
}
