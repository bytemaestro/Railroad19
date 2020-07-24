using System.ComponentModel.DataAnnotations;
using DocumentService.WebAPI.Models.Validation;

namespace DocumentService.WebAPI.Models
{
    [DocumentValidation]
    public class Document
    {
        [Required]
        //[DocumentTitleValidation]
        public string Title { get; set; }

        [Required]
        //[DocumentSizeValidation]
        public int Size { get; set; }

        [Required]
        //[DocumentFormatValidation]
        public string Format { get; set; }
    }
}