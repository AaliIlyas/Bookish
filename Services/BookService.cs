using Bookish.DbModels;
using Bookish.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bookish.Services
{
    public interface IBookService
    {
        List<BookViewModel> GenerateBookList();
        void AddNewBook(NewBookViewModel newBookViewModel);
        public BookViewModel GetIndividualBook(int id);
        public void EditBook(BookViewModel BookViewModel);
        public void DeleteBook(BookViewModel bookViewModel);
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

                book.Title = bookViewModel.Title;
                book.Author = bookViewModel.Author;
                book.NumberOfCopies = bookViewModel.NumberOfCopies;
                book.Genre = bookViewModel.Genre;

            _context.SaveChanges();
        }

        public void DeleteBook (BookViewModel bookViewModel)
        {
            var book = _context.Books.Find(bookViewModel.Id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public BookViewModel GetIndividualBook(int id)
        {
            var DbBook = _context.Books.Find(id);
            var book = new BookViewModel(DbBook);

            return book;
        }
    }
}