using Bookish.DbModels;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Services
{
    public interface ICheckoutService
    {
        List<CheckoutViewModel> GenerateCheckoutList();
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
    }
}
