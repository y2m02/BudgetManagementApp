﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetManagementApp.Entities.Models
{
    public class BalanceSheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BalanceSheetId { get; set; }

        public DateTime? DeletedOn { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }

        [ForeignKey(nameof(AccountingMovement))]
        public int? AccountingMovementId { get; set; }

        public virtual Project Project { get; set; }

        public virtual AccountingMovement AccountingMovement { get; set; }
    }
}
