using Core.Entities;
using Core.Enums;

namespace Application.ViewModels
{
    public class RevenueViewModel
    {
        public Guid Id { get; set; } 
        public string? Description { get; set; }
        public string Source { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string? ReceiptUrl { get; set; }

        public static RevenueViewModel FromEntity(Revenue revenue)
        {
            return new RevenueViewModel
            {
                Id = revenue.Id,
                Description = revenue.Description,
                Source = revenue.Source.ToFriendlyString(),
                Amount = revenue.Amount,
                Date = revenue.Date,
                UserId = revenue.UserId,
                CreatedAt = revenue.CreatedAt,
                UpdatedAt = revenue.UpdatedAt,
                ReceiptUrl = revenue.ReceiptUrl
            };
        }
    }
}