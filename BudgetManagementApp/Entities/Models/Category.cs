using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BudgetManagementApp.Entities.Helpers;

namespace BudgetManagementApp.Entities.Models
{
    public class Category : IDeletable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<Type> Types { get; set; }
    }
}
