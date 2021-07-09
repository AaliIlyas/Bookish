using Bookish.DbModels;
using Bookish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Services
{
    public interface IBookService
    {
        List<BookViewModel> GenerateBookList();
    }

    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        public BookService (LibraryContext context)
        {
            _context = context;
        }

        public List<BookViewModel> GenerateBookList()
        {
            var booksTable = _context.Books.Select(book => new BookViewModel(book)).ToList();

            return booksTable;
        }

        public void AddNewBook()
        {

        }
    }
}
