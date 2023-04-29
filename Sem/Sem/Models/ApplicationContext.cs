using Microsoft.EntityFrameworkCore;

namespace Sem.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Immovable> Immovables { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Mortgage> Mortgages { get; set; }
        public DbSet<CookieToken> CookieTokens { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }
    }
}