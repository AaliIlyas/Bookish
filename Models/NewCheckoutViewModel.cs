using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class NewCheckoutViewModel
    {
        public string MemberName { get; set; }
        public string BookName { get; set; }
        public DateTime DateLoaned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }
    }
}
