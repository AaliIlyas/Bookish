using Bookish.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class CheckoutViewModel
    {
        public CheckoutViewModel()
        {
        }

        public CheckoutViewModel(CheckedOutBookDbModel checkedOutBookDbModel)
        {
            Member = new MemberViewModel(checkedOutBookDbModel.Member);
            Book = new BookViewModel(checkedOutBookDbModel.Book);
            Author = Book.Author;
            Id = checkedOutBookDbModel.Id;
            DateLoaned = checkedOutBookDbModel.DateLoaned;
            DateDue = checkedOutBookDbModel.DateDue;
            DateReturned = checkedOutBookDbModel.DateReturned;
        }

        public MemberViewModel Member { get; set; }
        public BookViewModel Book { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public DateTime DateLoaned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}

