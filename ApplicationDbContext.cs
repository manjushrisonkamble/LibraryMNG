using LibraryMNG.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryMNG.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
