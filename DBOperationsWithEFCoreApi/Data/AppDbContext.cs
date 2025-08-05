using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApi.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, currency = "INR", description = "Indian Rupees" },
                new Currency() { Id = 2, currency = "USD", description = "American Dollor" },
                new Currency() { Id = 3, currency = "EUR", description = "Europian Currency" },
                new Currency() { Id = 4, currency = "JPY", description = "Japanese Yen" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id=1, title="Hindi", description= "Hindi" },
                new Language() { Id=2, title="Punjabi", description= "Punjabi" },
                new Language() { Id=3, title="Kannada", description= "Kannada" },
                new Language() { Id=4, title="Odia", description= "Odia" }
            );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrice { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }

    
}
