using System.Collections.Generic;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.Categories
{
    public class CategoryViewModel : BaseViewModel
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int CategoryId => Id;

        public string Description { get; set; }

        public override IEnumerable<string> Validate()
        {
            if (Description.IsEmpty())
            {
                yield return string.Format(
                    StringResources.FieldRequired,
                    StringResourcesHandler.GetString(FieldNames.Description)
                );
            }
        }
    }
}