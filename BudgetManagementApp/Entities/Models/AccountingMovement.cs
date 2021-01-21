using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BudgetManagementApp.Entities.Helpers;

namespace BudgetManagementApp.Entities.Models
{
    public class AccountingMovement : IDeletable
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

        public string Comment { get; set; }

        public DateTime? DeletedOn { get; set; }

        [ForeignKey(nameof(SubType))]
        public int SubTypeId { get; set; }

        public virtual SubType SubType { get; set; }

        public virtual ICollection<BalanceSheet> BalanceSheets { get; set; }
    }
}
