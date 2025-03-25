using System.ComponentModel.DataAnnotations;

namespace Application.InputModels.ExpenseModels
{
    public class UpdateExpenseInputModel
    {
        [MaxLength(300, ErrorMessage = "Description cannot be longer than 300 characters.")]
        public string? Description { get; set; }

        [MaxLength(50, ErrorMessage = "Category cannot be longer than 50 characters.")]
        public string? Category { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public decimal? Amount { get; set; }

        [CustomValidation(typeof(UpdateExpenseInputModel), nameof(ValidateDate))]
        public DateTime? Date { get; set; }

        [MaxLength(50, ErrorMessage = "Payment method cannot be longer than 50 characters.")]
        public string? PaymentMethod { get; set; }

        [MaxLength(500, ErrorMessage = "Receipt URL cannot be longer than 500 characters.")]
        public string? ReceiptUrl { get; set; }

        public static ValidationResult? ValidateDate(DateTime date, ValidationContext context)
        {
            if (date > DateTime.Now)
            {
                return new ValidationResult("Date cannot be in the future.");
            }
            return ValidationResult.Success;
        }
    }
}