using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ASP.ASPdotnetFrontEndJsonfilecosumption.Models
{
    public class BookObj
    {
        public string BookTitle { get; set; }
        public string BookEdition { get; set; }
        public string BookAuthor1 { get; set; }
        public string BookAuthor2 { get; set; }
        public string BookCategory { get; set; }
        public string BookPurchasePrice { get; set; }
        public string BookPublisher { get; set; }
        public string BookISBN { get; set; }
        public string BookStatus { get; set; }
        public string BookStorage_Code { get; set; }
        public string BookFormat { get; set; }
        public string ReleaseDate { get; set; }
        [JsonPropertyName("BookImgURL")]
        public string BookImg { get; set; }
        ////create Object
        public override string ToString() => JsonSerializer.Serialize<BookObj>(this);

    }
}
