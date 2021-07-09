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

        [HttpGet]
        public IActionResult All()
        {
            var booksTable = _bookService.GenerateBookList();
            return View(booksTable);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(NewBookViewModel newBookViewModel)
        {
            _bookService.AddNewBook(newBookViewModel);
            return RedirectToAction(nameof(All)); //$"{Title}, {Author}, {Genre}, {Num} copies. Thanks for submitting your book.";
        }
    }
}
