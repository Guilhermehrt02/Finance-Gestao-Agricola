using System.ComponentModel.DataAnnotations;

namespace Application.InputModels.RevenueModels
{
    public class UpdateRevenueInputModel
    {
        [MaxLength(300, ErrorMessage = "Description cannot be longer than 300 characters.")]
        public string? Description { get; set; }

        [MaxLength(50, ErrorMessage = "Source cannot be longer than 50 characters.")]
        public string? Source { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public decimal? Amount { get; set; }

        [CustomValidation(typeof(UpdateRevenueInputModel), nameof(ValidateDate))]
        public DateTime? Date { get; set; }

        [MaxLength(500, ErrorMessage = "Receipt URL cannot be longer than 500 characters.")]
        public string? ReceiptUrl { get; set; }

        public static ValidationResult? ValidateDate(DateTime? date, ValidationContext context)
        {
            if (date.HasValue) 
            {
                if (date.Value > DateTime.Now)
                {
                    return new ValidationResult("Date cannot be in the future.");
                }
            }
            return ValidationResult.Success;
        }
    }
}