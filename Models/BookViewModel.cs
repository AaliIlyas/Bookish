using Bookish.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class BookViewModel
    {
        public BookViewModel()
        {
        }
        public BookViewModel(BookDbModel bookDb)
        {
            Author = bookDb.Author;
            Title = bookDb.Title;
            Id = bookDb.Id;
            Genre = bookDb.Genre;
            NumberOfCopies = bookDb.NumberOfCopies;
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int NumberOfCopies { get; set; }
    }
}
