namespace DBOperationsWithEFCoreApi.Data
{
    public class BookPrice
    {
        public long Id {  get; set; }
        public long bookId {  get; set; }
        public decimal amount  {  get; set; }
        public long CurrencyId {  get; set; }
    }
}
