using System.ComponentModel.DataAnnotations;

namespace PojistakNET.Models
{
    public class DateRangeAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;

        public DateRangeAttribute(string minDate, string maxDate)
        {
            _minDate = DateTime.Parse(minDate);
            _maxDate = DateTime.Parse(maxDate);
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateValue)
            {
                if (dateValue < _minDate || dateValue > _maxDate)
                {
                    return new ValidationResult(ErrorMessage ?? $"Datum musí být mezi {_minDate:d} a {_maxDate:d}.");
                }
            }
            return ValidationResult.Success;
        }
    }

}
