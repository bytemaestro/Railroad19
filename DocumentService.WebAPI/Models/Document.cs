using System.ComponentModel.DataAnnotations;
using DocumentService.WebAPI.Models.Validation;

namespace DocumentService.WebAPI.Models
{
    [DocumentValidation]
    public class Document
    {
        //[DocumentTitleValidation]
        public string Title { get; set; }

        //[DocumentSizeValidation]
        public int Size { get; set; }

        //[DocumentFormatValidation]
        public string Format { get; set; }
    }
}