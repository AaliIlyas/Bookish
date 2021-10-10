using Bookish.DbModels;
using System;

namespace Bookish.Models
{
    public class CheckoutViewModel
    {
        public CheckoutViewModel()
        {
        }

        public CheckoutViewModel(
            CheckedOutBookDbModel checkedOutBookDbModel,
            bool showMember = true,
            bool showBook = true)
        {
            if (showMember)
            {
                Member = new MemberViewModel(checkedOutBookDbModel.Member);
            }

            if (showBook)
            {
                Book = new BookViewModel(checkedOutBookDbModel.Book);
                Author = Book.Author;
            }

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

