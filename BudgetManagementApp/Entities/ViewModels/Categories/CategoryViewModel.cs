﻿using System.ComponentModel;

namespace BudgetManagementApp.Entities.ViewModels.Categories
{
    public class CategoryViewModel : BaseViewModel
    {
        /// <summary>
        /// This property's going to be set automatically. 
        /// Please use Id instead.  
        /// </summary>
        public int CategoryId => Id;

        [DisplayName("Descripción")]
        public string Description { get; set; }
    }
}