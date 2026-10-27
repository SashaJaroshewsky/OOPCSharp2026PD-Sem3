namespace PZ5.Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> { 
                new Book("dfzh", "zsg", "sdg"),
                new Book("dfzh", "zsg", "sdg2"),
                new Book("dfzh", "zsg", "sdg4"),
                new Book("dfzh", "zsg", "sdg5")
            };

            Library library = new Library(books);

            Book book = new Book("dfzh", "zsg", "sdg3");
            library.Add(book);


            library.Remove(book);
            library.Remove("sdg2");

            library.Show();

        }
    }
}
