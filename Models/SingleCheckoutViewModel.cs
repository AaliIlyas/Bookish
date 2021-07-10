using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class SingleCheckoutViewModel
    {
        public SingleCheckoutViewModel()
        {
        }
        public SingleCheckoutViewModel(CheckoutViewModel checkoutViewModel)
        {
            MemberName = checkoutViewModel.Member.Name;
            BookTitle = checkoutViewModel.Book.Title;
            Author = checkoutViewModel.Book.Author;
            Id = checkoutViewModel.Id;
            DateLoaned = checkoutViewModel.DateLoaned;
            DateDue = checkoutViewModel.DateDue;
            DateReturned = checkoutViewModel.DateReturned;
        }
        public string MemberName { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public DateTime DateLoaned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime? DateReturned { get; set; }
    }

}
