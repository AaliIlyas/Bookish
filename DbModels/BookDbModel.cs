using System.Collections.Generic;

namespace Bookish.DbModels
{
    public class BookDbModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int NumberOfCopies { get; set; }
        public List<CheckedOutBookDbModel> CheckedOutBooks { get; set; }
    }
}
