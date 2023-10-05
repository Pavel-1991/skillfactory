using Microsoft.EntityFrameworkCore;

namespace Module25EntityFramework
{
    public class AppContext : DbContext
    {
        // Объекты таблиц
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public AppContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ZVERDVD-G29UUCQ\SQLEXPRESSEFILM;Database=library;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
