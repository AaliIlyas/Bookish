using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class CheckedOutBooks
    {
        public int Name_Id { get; set; }
        public int Book_Id { get; set; }
        public int Id { get; set; }
        public DateTime DateLoaned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }
    }
}
