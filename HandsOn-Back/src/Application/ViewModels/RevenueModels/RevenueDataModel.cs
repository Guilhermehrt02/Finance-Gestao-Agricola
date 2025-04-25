using Core.Entities;
using Core.Enums;

namespace Application.ViewModels.RevenueModels
{
    public class RevenueDataModel
    {
        public string Source { get; set; } = string.Empty;
        public decimal Amount { get; set; }

        public static RevenueDataModel FromEntity(Revenue revenue)
        {
            return new RevenueDataModel
            {
                Source = revenue.Source.ToFriendlyString(),
                Amount = revenue.Amount
            };
        }
    }
}