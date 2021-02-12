using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Extensions;

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
            if (Description.IsEmpty())
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Description)
                );
            }

            if (TypeId < 1)
            {
                yield return StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Type)
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
