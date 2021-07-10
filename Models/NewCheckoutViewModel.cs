using System;

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
