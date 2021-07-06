using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class BooksViewModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int NumberOfCopies { get; set; }
    }
}
