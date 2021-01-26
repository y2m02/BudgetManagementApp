using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using System.Collections.Generic;

namespace BudgetManagementApp.Entities.ViewModels.SubTypes
{
    public class SubTypeViewModel : BaseViewModel
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int SubTypeId => Id;

        public string Description { get; set; }

        public int TypeId { get; set; }

        public string TypeDescription { get; set; }

        public int CategoryId { get; set; }

        public string CategoryDescription { get; set; }

        public override IEnumerable<string> Validate()
        {
            if (string.IsNullOrEmpty(Description) ||
                string.IsNullOrWhiteSpace(Description))
            {
                yield return string.Format(
                    StringResources.FieldRequired,
                    StringResourcesHandler.GetString(FieldNames.Description)
                );
            }

            if (TypeId < 1)
            {
                yield return string.Format(
                    StringResources.FieldRequired,
                    StringResourcesHandler.GetString(FieldNames.Type)
                );
            }

            if (CategoryId < 1)
            {
                yield return string.Format(
                    StringResources.FieldRequired,
                    StringResourcesHandler.GetString(FieldNames.Category)
                );
            }
        }
    }
}
