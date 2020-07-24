
using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentService.WebAPI.Models.Validation
{
    public class DocumentFormatValidationAttribute : ValidationAttribute
    {
        public DocumentFormatValidationAttribute()
        {

        }

        public string GetErrorMessage() =>
            "Format is invalid: Format must be lowercase and equal one of the following: 'txt', 'pdf', 'docx'";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            //validate title
            if (
                validationContext != null && (
                       (((Document)validationContext.ObjectInstance).Format == "txt" )
                    || (((Document)validationContext.ObjectInstance).Format == "pdf" )
                    || ((Document)validationContext.ObjectInstance).Format == "docx" )
                    )
            {
                return ValidationResult.Success;

            }

            return new ValidationResult(GetErrorMessage());
        }
    }
}
