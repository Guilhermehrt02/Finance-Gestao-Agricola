using Core.Entities;

namespace Application.ViewModels
{
    public class ExpenseViewModel
    {
        public Guid Id { get; set; } 
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string? PaymentMethod { get; set; }  
        public string? ReceiptUrl { get; set; }

        public static ExpenseViewModel FromEntity(Expense expense)
        {
            return new ExpenseViewModel
            {
                Id = expense.Id,
                Description = expense.Description,
                Category = expense.Category,
                Amount = expense.Amount,
                Date = expense.Date,
                UserId = expense.UserId,
                User = expense.User,
                CreatedAt = expense.CreatedAt,
                UpdatedAt = expense.UpdatedAt,
                PaymentMethod = expense.PaymentMethod,
                ReceiptUrl = expense.ReceiptUrl
            };
        }
    }
}