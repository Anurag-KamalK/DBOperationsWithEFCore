namespace DBOperationsWithEFCoreApi.Data
{
    public class Language
    {
        public long Id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
