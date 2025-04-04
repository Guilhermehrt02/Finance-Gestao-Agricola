using Core.Entities;
using Core.Enums;

namespace Application.ViewModels
{
    public class ExpenseViewModel
    {
        public Guid Id { get; set; } 
        public string? Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string? PaymentMethod { get; set; }  
        public string? ReceiptUrl { get; set; }

        public static ExpenseViewModel FromEntity(Expense expense)
        {
            return new ExpenseViewModel
            {
                Id = expense.Id,
                Description = expense.Description,
                Category = expense.Category.ToFriendlyString(),
                Amount = expense.Amount,
                Date = expense.Date,
                UserId = expense.UserId,
                CreatedAt = expense.CreatedAt,
                UpdatedAt = expense.UpdatedAt,
                PaymentMethod = expense.PaymentMethod?.ToString(),
                ReceiptUrl = expense.ReceiptUrl
            };
        }
    }
}