
using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentService.WebAPI.Models.Validation
{
    public class DocumentSizeValidationAttribute : ValidationAttribute
    {
        private const int SIZE_MIN = 0;
        private const int SIZE_MAX = 500;

        public DocumentSizeValidationAttribute()
        {

        }

        public string GetErrorMessage() =>
            "Size is invalid: Size must be greater than 0 MB and less than 500 MB";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            //validate size
            if ((validationContext != null)
                && (((Document)validationContext.ObjectInstance).Size > SIZE_MIN)
                && ((Document)validationContext.ObjectInstance).Size < SIZE_MAX)
            {
                return ValidationResult.Success;

            }

            return new ValidationResult(GetErrorMessage());
        }
    }
}
