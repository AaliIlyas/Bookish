using Bookish.DbModels;

namespace Bookish.Models
{
    public class MemberViewModel
    {
        public MemberViewModel()
        {
        }

        public MemberViewModel(MemberDbModel memberDb)
        {
            Id = memberDb.Id;
            Name = memberDb.Name;
            Address = memberDb.Address;
            PhoneNumber = memberDb.PhoneNumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
    }
}
