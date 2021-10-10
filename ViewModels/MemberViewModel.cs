using Bookish.DbModels;
using System.Collections.Generic;
using System.Linq;

namespace Bookish.Models
{
    public class MemberViewModel
    {
        public MemberViewModel()
        {
        }

        public MemberViewModel(MemberDbModel memberDb, bool loadDependencies = false)
        {
            Id = memberDb.Id;
            Name = memberDb.Name;
            Address = memberDb.Address;
            PhoneNumber = memberDb.PhoneNumber;

            if (loadDependencies)
            {
                CheckedOutBooks = memberDb.CheckedOutBooks
                    .Select(c => new CheckoutViewModel(c, false, true))
                    .ToList();
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public IEnumerable<CheckoutViewModel>? CheckedOutBooks { get; set; }
    }
}
