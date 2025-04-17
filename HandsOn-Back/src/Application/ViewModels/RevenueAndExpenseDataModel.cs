using Core.Entities;
using Core.Enums;

namespace Application.ViewModels
{
    public class RevenueAndExpenseDataModel
    {
        public string Type { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0;
        public string Period { get; set; } = string.Empty;
    }
}