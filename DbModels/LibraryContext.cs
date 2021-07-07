using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.DbModels
{
    public class LibraryContext : DbContext
    {
        public DbSet<BookDbModel> Books { get; set; }
        public DbSet<CheckedOutBookDbModel> CheckedOutBooks { get; set; }
        public DbSet<MemberDbModel> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=BookishDB;User Id=sa;Password=Password123;");
        }
    }
}
