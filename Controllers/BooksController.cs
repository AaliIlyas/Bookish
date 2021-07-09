using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.DbModels;
using Bookish.Services;

namespace Bookish.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult All()
        {
            var booksTable = _bookService.GenerateBookList();
            return View(booksTable);
        }

        public IActionResult New()
        {

            return View();
        }

        [HttpPost]
        public string Submit(string Title, string Author, string Genre, int Num)
        {
            // goes to service to add to db
            return $"{Title}, {Author}, {Genre}, {Num} copies. Thanks for submitting your book.";
        }
    }
}
