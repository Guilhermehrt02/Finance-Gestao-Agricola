
using Core.Enums;

namespace Core.Entities
{
    public class Expense
    {
        public Guid Id { get; set; } 
        public string? Description { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public PaymentMethod? PaymentMethod { get; set; }  
        public string? ReceiptUrl { get; set; }

        public Expense() { }

        public Expense(string category, decimal amount, DateTime date, Guid userId)
        {
            Category = CategoryExtension.ToCategory(category);
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
            Category = CategoryExtension.ToCategory(category ?? Category.ToFriendlyString());
            Amount = amount ?? Amount;
            Date = date ?? Date;
            PaymentMethod = PaymentMethodExtension.ToPaymentMethod(paymentMethod ?? PaymentMethod?.ToFriendlyString() ?? string.Empty);
            ReceiptUrl = receiptUrl ?? ReceiptUrl;

            UpdatedAt = DateTime.Now;
        }
    }
}