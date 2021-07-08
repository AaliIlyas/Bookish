using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
