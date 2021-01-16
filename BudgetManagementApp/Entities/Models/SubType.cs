using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetManagementApp.Entities.Models
{
    public class SubType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public DateTime? DeletedOn { get; set; }

        [ForeignKey(nameof(Type))]
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }

        public virtual ICollection<AccountingMovement> AccountingMovements { get; set; }
    }
}
