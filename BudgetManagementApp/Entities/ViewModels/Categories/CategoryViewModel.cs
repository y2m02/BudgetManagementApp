using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Resources.Properties;
using System.Collections.Generic;

namespace BudgetManagementApp.Entities.ViewModels.Categories
{
    public class CategoryViewModel : BaseViewModel, IValidatable
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int CategoryId => Id;

        public string Description { get; set; }

        public IEnumerable<string> Validate()
        {
            if (string.IsNullOrEmpty(Description) ||
                string.IsNullOrWhiteSpace(Description))
            {

                yield return string.Format(
                    StringResources.FieldRequired,
                    nameof(Description)
                );
            }
        }
    }
}