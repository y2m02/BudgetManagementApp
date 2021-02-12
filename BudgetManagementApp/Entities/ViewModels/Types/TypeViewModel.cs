using System.Collections.Generic;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.Types
{
    public class TypeViewModel : BaseViewModel
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int TypeId => Id;

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string CategoryDescription { get; set; }

        public override IEnumerable<string> Validate()
        {
            if (Description.IsEmpty())
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Description)
                );
            }

            if (CategoryId < 1)
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Category)
                );
            }
        }
    }
}