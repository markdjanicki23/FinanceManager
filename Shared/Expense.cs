using System;

namespace FinanceManager.Shared
{
   public class Expense
    {
        public Expense()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Subject { get; set; }

        public ExpenseCategory Category { get; set; }

        public decimal Amount { get; set; }
    }
}
