using Core.Entities;
using Core.Enums;

namespace Application.ViewModels.ExpenseModels
{
    public class ExpenseDataModel
    {
        public string Category { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public static ExpenseDataModel FromEntity(Expense expense)
        {
            return new ExpenseDataModel
            {
                Category = expense.Category.ToFriendlyString(),
                Amount = expense.Amount,
                Date = expense.Date,
            };
        }
    }
}