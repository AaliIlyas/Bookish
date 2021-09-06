using Bookish.DbModels;
using System.Collections.Generic;
using System.Linq;

namespace Bookish.Models
{
    public class BookViewModel
    {
        public BookViewModel()
        {
        }

        public BookViewModel(BookDbModel bookDb, 
            bool loadMember = false,
            bool loadBook = false)
        {
            Author = bookDb.Author;
            Title = bookDb.Title;
            Id = bookDb.Id;
            Genre = bookDb.Genre;
            NumberOfCopies = bookDb.NumberOfCopies;

            if (loadMember && loadBook)
            {
                CheckedOutBooks = bookDb.CheckedOutBooks
                    .Select(b => new CheckoutViewModel(b, true, true));
            } else if (loadMember && !loadBook)
            {
                CheckedOutBooks = bookDb.CheckedOutBooks
                    .Select(b => new CheckoutViewModel(b, true, false));
            }  else if (!loadMember && loadBook)
            {
                CheckedOutBooks = bookDb.CheckedOutBooks
                    .Select(b => new CheckoutViewModel(b, false, true));
            } 
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int NumberOfCopies { get; set; }
        public IEnumerable<CheckoutViewModel>? CheckedOutBooks { get; set; }
    }
}
