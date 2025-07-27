using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApi.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
