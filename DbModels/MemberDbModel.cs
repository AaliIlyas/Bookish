using System.Collections.Generic;

namespace Bookish.DbModels
{
    public class MemberDbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public List<CheckedOutBookDbModel> CheckedOutBooks { get; set; }
    }
}
