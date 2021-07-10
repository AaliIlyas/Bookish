using Microsoft.EntityFrameworkCore;

namespace Bookish.DbModels
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<BookDbModel> Books { get; set; }
        public DbSet<CheckedOutBookDbModel> CheckedOutBooks { get; set; }
        public DbSet<MemberDbModel> Members { get; set; }
    }
}
