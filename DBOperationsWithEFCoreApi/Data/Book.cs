using System.Numerics;

namespace DBOperationsWithEFCoreApi.Data
{
    public class Book
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public long noOfPages { get; set; }
        public bool isActive { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
        public long languageId { get; set; }

        public Language language { get; set; }
    }
}
