using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.DbModels;

namespace Bookish.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        public IActionResult All()
        {
            var context = new LibraryContext();
            var booksTable = context.Books.Select(book => ConvertToBookViewModel(book)).ToList();

            return View(booksTable);
        }

        public static BookViewModel ConvertToBookViewModel(BookDbModel book)
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
