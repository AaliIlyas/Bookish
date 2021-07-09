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
        void AddNewBook(NewBookViewModel newBookViewModel);
        public BookViewModel GetIndividualBook(int id);
        public void EditBook(BookViewModel BookViewModel);
    }

    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public List<BookViewModel> GenerateBookList()
        {
            var booksTable = _context.Books.Select(book => new BookViewModel(book)).ToList();

            return booksTable;
        }

        public void AddNewBook(NewBookViewModel newBookViewModel)
        {
            var newBook = new BookDbModel
            {
                Author = newBookViewModel.Author,
                Title = newBookViewModel.Title,
                Genre = newBookViewModel.Genre,
                NumberOfCopies = newBookViewModel.NumberOfCopies
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();
        }

        public void EditBook(BookViewModel bookViewModel)
        {
            var book = _context.Books.Find(bookViewModel.Id);

            if (bookViewModel.Title != null)
            {
                book.Title = bookViewModel.Title;
            }

            if (bookViewModel.Author != null)
            {
                book.Author = bookViewModel.Author;
            }

            if (bookViewModel.NumberOfCopies != 0)
            {
                book.NumberOfCopies = bookViewModel.NumberOfCopies;
            }

            if (bookViewModel.Genre != null)
            {
                book.Genre = bookViewModel.Genre;
            }

            _context.SaveChanges();
        }

        public BookViewModel GetIndividualBook(int id)
        {
            var book = _context.Books.Where(book => book.Id == id)
                                 .Select(book => new BookViewModel(book));
            return book.First();
        }
    }
}