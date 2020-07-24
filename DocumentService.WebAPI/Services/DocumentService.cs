using System;
using DocumentService.WebAPI.Models;

namespace DocumentService.WebAPI.Services
{

    //TODO: Remove This Class... Not Using: doing validation in model attributes
    //public class DocumentService : IDocumentService
    //{
    //    private const int TITLE_MIN = 5;
    //    private const int TITLE_MAX = 35;
    //    private const int SIZE_MIN = 0;
    //    private const int SIZE_MAX = 500;

    //    public bool Validate(Document doc)
    //    {
    //        var validTitle = false;
    //        var validSize = false;
    //        var validFormat = false;

    //        //validate title
    //        if (!(doc.Title == null)
    //            && (doc.Title.Length >= TITLE_MIN)
    //            && (doc.Title.Length <= TITLE_MAX)
    //            && Char.IsUpper(doc.Title, 0))
    //        {
    //            validTitle = true;
    //        }

    //        //validate size
    //        if ((doc.Title.Length > SIZE_MIN) && (doc.Title.Length <= SIZE_MAX))
    //        {
    //            validSize = true;
    //        }

    //        return (validTitle && validSize && validFormat);

    //    }
    //}
}
