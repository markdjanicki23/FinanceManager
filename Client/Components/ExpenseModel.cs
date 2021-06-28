﻿using FinanceManager.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManager.Client.Components
{
    public class ExpenseModel
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        [Required]
        public ExpenseCategory Category { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
