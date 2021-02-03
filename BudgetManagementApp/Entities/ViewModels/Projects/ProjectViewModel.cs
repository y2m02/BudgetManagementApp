using System;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels.Projects
{
    public class ProjectViewModel : BaseViewModel
    {
        /// <summary>
        ///     This property's going to be set automatically.
        ///     Please use Id instead.
        /// </summary>
        public int ProjectId => Id;

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal? Construction { get; set; }

        public decimal? Cost { get; set; }

        public override IEnumerable<string> Validate()
        {
            if (Name.IsEmpty())
            {
                StringResources.FieldRequired.Format(
                    StringResourcesHandler.GetString(FieldNames.Name)
                );
            }

            if (StartDate.IsGreaterThan(EndDate.Date))
            {
                yield return StringResources.DateGreaterThanValidation.Format(
                    StringResourcesHandler.GetString(FieldNames.StartDate),
                    StringResourcesHandler.GetString(FieldNames.EndDate)
                );
            }
        }
    }
}