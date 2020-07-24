
using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentService.WebAPI.Models.Validation
{
    public class DocumentTitleValidationAttribute : ValidationAttribute
    {
        private const int TITLE_MIN = 5;
        private const int TITLE_MAX = 35;

        public DocumentTitleValidationAttribute()
        {
           
        }

        public string GetErrorMessage() =>
            "Title is invalid: Title must contain a minimum of 5 characters and a maximum of 35, and each word should start with an uppercase letter";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            //validate title
            if ((validationContext != null)
                && (((Document)validationContext.ObjectInstance).Title.Length >= TITLE_MIN)
                && (((Document)validationContext.ObjectInstance).Title.Length <= TITLE_MAX)
                && Char.IsUpper((string)((Document)validationContext.ObjectInstance).Title, 0))
            {
                return ValidationResult.Success;
                
            }

            return new ValidationResult(GetErrorMessage());
        }

        public bool IsTitleCase(string title)
        {
            return false; //TODO: Validate TitleCase first word capital
        }
    }
}
