using Core.Enums;

namespace Core.Entities
{
    public class Revenue
    {
        public Guid Id { get; set; } 
        public string? Description { get; set; }
        public Source Source { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string? ReceiptUrl { get; set; }

        public Revenue() { }

        public Revenue(string source, decimal amount, DateTime date, Guid userId)
        {
            Source = SourceExtension.ToSource(source);
            Amount = amount;
            Date = date;
            UserId = userId;
            CreatedAt = DateTime.Now;
        }

        public void Update(
            string? description,
            string? source,
            decimal? amount,
            DateTime? date,
            string? receiptUrl
        )
        {
            Description = description ?? Description;
            Source = SourceExtension.ToSource(source ?? Source.ToFriendlyString());
            Amount = amount ?? Amount;
            Date = date ?? Date;
            ReceiptUrl = receiptUrl ?? ReceiptUrl;
            UpdatedAt = DateTime.Now;
        }
    }
}