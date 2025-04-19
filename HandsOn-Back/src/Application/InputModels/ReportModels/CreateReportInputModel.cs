using System.ComponentModel.DataAnnotations;

namespace Application.InputModels.ReportModels
{
    public class CreateReportInputModel
    {
        [Required(ErrorMessage = "Start date is required.")]
        [CustomValidation(typeof(CreateReportInputModel), nameof(ValidatePeriod))]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [CustomValidation(typeof(CreateReportInputModel), nameof(ValidateText))]
        public string[]? Category { get; set; } = [];
        
        [CustomValidation(typeof(CreateReportInputModel), nameof(ValidateText))]
        public string[]? Source { get; set; } = [];

        public static ValidationResult? ValidateText(string[]? text, ValidationContext context)
        {
            if (text != null && text.Length > 0)
            {
                foreach (var item in text)
                {
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        return new ValidationResult("It cannot be empty.");
                    }

                    if (item.Length > 50)
                    {
                        return new ValidationResult("It cannot be longer than 50 characters.");
                    }
                }
            }
            return ValidationResult.Success;
        }

        public static ValidationResult? ValidatePeriod(DateTime startDate, ValidationContext context)
        {
            var instance = context.ObjectInstance as CreateReportInputModel;

            if (instance == null)
            {
                return new ValidationResult("Invalid model instance.");
            }

            // Check if StartDate is in the past
            if (startDate > DateTime.Now)
            {
                return new ValidationResult("Start date must be in the past.");
            }

            // If EndDate exists, validate it
            if (instance.EndDate.HasValue)
            {

                if (startDate > instance.EndDate.Value)
                {
                    return new ValidationResult("Start date cannot be after end date.");
                }
            }

            return ValidationResult.Success;
        }
    }

}