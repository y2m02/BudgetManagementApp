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
        public List<CategoryViewModel> Categories { get; set; } = new();
        public List<TypeViewModel> Types { get; set; } = new();
        public List<SubTypeViewModel> SubTypes { get; set; } = new();
        public List<ProjectViewModel> Projects { get; set; } = new();
        public List<AccountingMovementViewModel> AccountingMovements { get; set; } = new();
    }
}
