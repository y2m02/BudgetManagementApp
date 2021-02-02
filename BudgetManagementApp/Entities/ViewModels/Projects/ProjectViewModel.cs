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

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? Construction { get; set; }

        public decimal? Cost { get; set; }

        public override IEnumerable<string> Validate()
        {
            if (Name.IsEmpty())
            {
                yield return string.Format(
                    StringResources.FieldRequired,
                    StringResourcesHandler.GetString(FieldNames.Name)
                );
            }

            if (StartDate.HasValue &&
                EndDate.HasValue &&
                StartDate.Value.Date.IsGreaterThan(EndDate.Value.Date) 
            )
            {
                yield return string.Format(
                    StringResources.DateGreaterThanValidation,
                    StringResourcesHandler.GetString(FieldNames.StartDate),
                    StringResourcesHandler.GetString(FieldNames.EndDate)
                );
            }
        }
    }
}