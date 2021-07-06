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

        public IActionResult booksdb()
        {
            var dune = new BooksViewModel();
            dune.Title = "Dune";
            dune.Author = "Frank Herbert";
            dune.NumberOfCopies = 3;
            dune.Genre = "Sci-Fi";
            dune.Id = 1;
            return View(dune);
        }
    }
}
