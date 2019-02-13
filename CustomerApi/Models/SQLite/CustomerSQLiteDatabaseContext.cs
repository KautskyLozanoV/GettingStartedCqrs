using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Models.SQLite
{
    public class CustomerSQLiteDatabaseContext : DbContext
    {
        public CustomerSQLiteDatabaseContext(DbContextOptions<CustomerSQLiteDatabaseContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerRecord>()
                .HasMany(x => x.Phones);
        }
        public DbSet<CustomerRecord> Customers { get; set; }
    }
}
