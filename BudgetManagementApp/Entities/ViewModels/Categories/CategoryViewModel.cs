﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.History;

namespace BudgetManagementApp.Entities.ViewModels.Categories
{
    public class CategoryViewModel : BaseViewModel
    {
        /// <summary>
        /// This property's going to be set automatically. 
        /// Please use Id instead.  
        /// </summary>
        public int CategoryId => Id;
        
        [DisplayName()]
        public string Description { get; set; }
    }
}