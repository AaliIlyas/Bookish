namespace Bookish.Models
{
    public class MainDB
    {
        static public void MainDatabase()
        {
            using (var context = new LibraryContext())
            {
                var dune = new BooksViewModel()
                {
                    Title = "Dune",
                    Author = "Frank Herbert",
                    NumberOfCopies = 3,
                    Genre = "Sci-Fi",
                    Id = 1
                };

                context.BooksViewModel.Add(dune);
                context.SaveChanges();
            }
        }
    }
}
