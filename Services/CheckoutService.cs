using Bookish.DbModels;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bookish.Services
{
    public interface ICheckoutService
    {
        List<CheckoutViewModel> GenerateCheckoutList();
        void AddNewCheckedOut(NewCheckoutViewModel newCheckoutViewModel);
        SingleCheckoutViewModel GetIndividualCheckout(int i);
        void EditIndividualCheckout(SingleCheckoutViewModel singleCheckoutViewModel);
        void DeleteEntry(SingleCheckoutViewModel singleEntry);
    }
    public class CheckoutService : ICheckoutService
    {
        private readonly LibraryContext _context;

        public CheckoutService(LibraryContext context)
        {
            _context = context;
        }

        public List<CheckoutViewModel> GenerateCheckoutList()
        {
            var checkedOutTable = _context.CheckedOutBooks
                .Include(checkedOutBook => checkedOutBook.Book)
                .Include(checkedOutBook => checkedOutBook.Member)
                .Select(checkout => ConvertToCheckoutViewModel(checkout))
                .ToList();

            return checkedOutTable;
        }

        private static CheckoutViewModel ConvertToCheckoutViewModel(CheckedOutBookDbModel checkout)
        {
            var checkoutToView = new CheckoutViewModel
            {
                Member = new MemberViewModel(checkout.Member),
                Book = new BookViewModel(checkout.Book),
                Author = checkout.Book.Author,
                Id = checkout.Id,
                DateLoaned = checkout.DateLoaned,
                DateDue = checkout.DateDue,
                DateReturned = checkout.DateReturned
            };
            return checkoutToView;
        }

        public SingleCheckoutViewModel GetIndividualCheckout(int id)
        {
            var entry = _context.CheckedOutBooks
                .Include(checkedOutBook => checkedOutBook.Book)
                .Include(checkedOutBook => checkedOutBook.Member)
                .Where(checkedOutBook => checkedOutBook.Id == id)
                .First();

            var checkout = new CheckoutViewModel(entry);
            var singleCheckout = new SingleCheckoutViewModel(checkout);
            return singleCheckout;
        }

        public void EditIndividualCheckout (SingleCheckoutViewModel singleCheckoutViewModel)
        {
            var entry = _context.CheckedOutBooks.Find(singleCheckoutViewModel.Id);

            var member = _context.Members.Where(member => member.Name == singleCheckoutViewModel.MemberName).First();
            var book = _context.Books.Where(book => book.Title == singleCheckoutViewModel.BookTitle).First();

            entry.Member = member;
            entry.Book = book;
            entry.DateLoaned = singleCheckoutViewModel.DateLoaned;
            entry.DateDue = singleCheckoutViewModel.DateDue;
            entry.DateReturned = singleCheckoutViewModel.DateReturned;

            _context.SaveChanges();
        }

        public void DeleteEntry (SingleCheckoutViewModel singleEntry)
        {
            var entry = _context.CheckedOutBooks.Find(singleEntry.Id);
            _context.CheckedOutBooks.Remove(entry);
            _context.SaveChanges();
        }

        public void AddNewCheckedOut(NewCheckoutViewModel newCheckoutViewModel)
        {
            var member = _context.Members.Where(member => member.Name == newCheckoutViewModel.MemberName).First();
            var book = _context.Books.Where(book => book.Title == newCheckoutViewModel.BookName).First();

            var newCheckout = new CheckedOutBookDbModel
            {
                Member = member,
                Book = book,
                DateLoaned = newCheckoutViewModel.DateLoaned,
                DateDue = newCheckoutViewModel.DateDue,
                DateReturned = null
            };

            _context.CheckedOutBooks.Add(newCheckout);
            _context.SaveChanges();
        }
    }
}
