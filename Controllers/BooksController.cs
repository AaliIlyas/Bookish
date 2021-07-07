using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;

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
            var dune = new BookViewModel
            {
                Title = "Dune",
                Author = "Frank Herbert",
                NumberOfCopies = 3,
                Genre = "Sci-Fi",
                Id = 1
            };

            var emma = new BookViewModel
            {
                Title = "Emma",
                Author = "Jane Austen",
                NumberOfCopies = 5,
                Genre = "Classic",
                Id = 2
            };

            var oliverTwist = new BookViewModel
            {
                Title = "Oliver Twist",
                Author = "Charles Dickens",
                NumberOfCopies = 3,
                Genre = "Classic",
                Id = 3
            };

            var theVeryHungryCaterpillar = new BookViewModel
            {
                Title = "The Very Hungry Caterpillar",
                Author = "Eric Carle",
                NumberOfCopies = 4,
                Genre = "Children",
                Id = 4
            };

            var capital = new BookViewModel
            {
                Title = "Capital",
                Author = "Karl Marx",
                NumberOfCopies = 1,
                Genre = "Politics",
                Id = 5
            };

            var ofMiceAndMen = new BookViewModel
            {
                Title = "Of Mice and Men",
                Author = "John Steinbeck",
                NumberOfCopies = 2,
                Genre = "Classic",
                Id = 6
            };

            var bookList = new List<BookViewModel> { dune, emma, oliverTwist, theVeryHungryCaterpillar, capital, ofMiceAndMen };

            return View(bookList);
        }
    }
}
