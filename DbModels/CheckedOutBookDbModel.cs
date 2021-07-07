using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.DbModels
{
    public class CheckedOutBookDbModel
    {
        public MemberDbModel Member { get; set; }
        public BookDbModel Book { get; set; }
        public int Id { get; set; }
        public DateTime DateLoaned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}
