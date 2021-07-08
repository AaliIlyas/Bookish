using Bookish.DbModels;
using Bookish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Services
{
    public class BookService
    {
        public static List<BookViewModel> GenerateBookList()
        {
            var context = new LibraryContext();
            var booksTable = context.Books.Select(book => ConvertToBookViewModel(book)).ToList();

            return booksTable;
        }

        private static BookViewModel ConvertToBookViewModel(BookDbModel book)
        {
            var bookToView = new BookViewModel
            {
                Author = book.Author,
                Title = book.Title,
                Id = book.Id,
                Genre = book.Genre,
                NumberOfCopies = book.NumberOfCopies
            };
            return bookToView;
        }
    }
}
