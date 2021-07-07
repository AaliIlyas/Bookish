using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<BooksViewModel> BooksViewModel { get; set; }
        public DbSet<CheckedOutBooks> CheckedOutBooks { get; set; }
        public DbSet<LibraryMember> LibraryMember { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=BookishDB;User Id=sa;Password=Password123;");
        }
    }
}
