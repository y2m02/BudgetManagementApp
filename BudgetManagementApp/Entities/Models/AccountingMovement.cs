using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetManagementApp.Entities.Models
{
    public class AccountingMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountingMovementId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public bool IsAnIncome { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public DateTime? DeletedOn { get; set; }

        [ForeignKey(nameof(SubType))]
        public int SubTypeId { get; set; }

        [ForeignKey(nameof(Project))]
        public int? ProjectId { get; set; }

        public virtual SubType SubType { get; set; }

        public virtual Project Project { get; set; }
    }
}
