﻿using System.Collections.Generic;
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
            if (string.IsNullOrEmpty(Description) ||
                string.IsNullOrWhiteSpace(Description))
            {
                yield return string.Format(
                    StringResources.FieldRequired,
                    StringResourcesHandler.GetString(FieldNames.Description)
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