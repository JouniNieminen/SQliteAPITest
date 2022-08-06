using System.ComponentModel.DataAnnotations;

namespace SQliteAPI.Entities
{
//    Id, int, unique id for the quote
//TheQuote, string, the quote text
//WhoSaid, string, who said the quote
//WhenWasSaid, DateTime, when the quote was said
//QuoteCreator, string, who saved the quote to this app
//QuoteCreatorNormalized, string, uppercase, the QuoteCreator value in all CAPS
//QuoteCreateDate, DateTime, when the quote was saved to the app
//The QuoteContext has only one constructor. It must be possible to provide the confguration to the context via the constructor.
    public class Quote
    {
        [Key]
        public int Id { get; set; }
        public string TheQuote { get; set; }
        public string WhoSaid { get; set; }
        public DateTime WhenWasSaid { get; set; }
        public string QuoteCreator { get; set; }
        public string QuoteCreatorNormalized => QuoteCreator.ToUpper();
        public DateTime QuoteCreateTime { get; set; }
        
    }
}
