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
        void AddNewBook(string title, string author, string genre, int num);
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

        public void AddNewBook(string title, string author, string genre, int num)
        {
            var newBook = new BookDbModel
            {
                Author = author,
                Title = title,
                Genre = genre,
                NumberOfCopies = num
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();
        }
    }
}