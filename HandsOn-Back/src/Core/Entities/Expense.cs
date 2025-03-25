
namespace Core.Entities
{
    public class Expense
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

        public Expense() { }

        public Expense(string description, string category, decimal amount, DateTime date, Guid userId)
        {
            Description = description;
            Category = category;
            Amount = amount;
            Date = date;
            UserId = userId;
            CreatedAt = DateTime.Now;
        }

        public void Update(
            string? description,
            string? category,
            decimal? amount,
            DateTime? date,
            string? paymentMethod,
            string? receiptUrl
        )
        {
            Description = description ?? Description;
            Category = category ?? Category;
            Amount = amount ?? Amount;
            Date = date ?? Date;
            PaymentMethod = paymentMethod ?? PaymentMethod;
            ReceiptUrl = receiptUrl ?? ReceiptUrl;

            UpdatedAt = DateTime.Now;
        }
    }
}