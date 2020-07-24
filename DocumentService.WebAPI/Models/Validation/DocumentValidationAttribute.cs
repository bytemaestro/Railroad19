using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentService.WebAPI.Models.Validation
{
    public class DocumentValidationAttribute : ValidationAttribute
    {
        private const int SIZE_MIN = 0;
        private const int SIZE_MAX = 500;
        private const int TITLE_MIN = 5;
        private const int TITLE_MAX = 35;

        public DocumentValidationAttribute()
        {

        }
        public string GetTitleError() =>
         "Title is invalid: Title must contain a minimum of 5 characters and a maximum of 35, and each word should start with an uppercase letter";
        public string GetSizeError() =>
        "Size is invalid: Size must be greater than 0 MB and less than 500 MB";

        public string GetFormatError() =>
            "Format is invalid: Format must be lowercase and equal one of the following: 'txt', 'pdf', 'docx'";


        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            //validate title
            if (validationContext == null
                || (((Document)validationContext.ObjectInstance).Title.Length < TITLE_MIN)
                || (((Document)validationContext.ObjectInstance).Title.Length > TITLE_MAX)
                || !Char.IsUpper((string)((Document)validationContext.ObjectInstance).Title, 0))
            {
                return new ValidationResult(GetTitleError());

            }


            //validate size
            if (validationContext == null
                || (((Document)validationContext.ObjectInstance).Size <= SIZE_MIN)
                || (((Document)validationContext.ObjectInstance).Size > SIZE_MAX))
            {

                return new ValidationResult(GetSizeError());
            }

            //validate format
            if (
                validationContext != null && (
                       (((Document)validationContext.ObjectInstance).Format != "txt")
                    && (((Document)validationContext.ObjectInstance).Format != "pdf")
                    && ((Document)validationContext.ObjectInstance).Format != "docx")
                    )
            {
                return new ValidationResult(GetFormatError());

            }

            return ValidationResult.Success;
         
        }
    }
}