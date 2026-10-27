
namespace PZ5.Library
{
    internal class Library
    {
        public List<Book> _books;

        public List<User> _users; 

        public Library()
        {
            _books = new List<Book>(200);
            _users = new List<User>(20);
            //_booksArr = new Book[0];

            //_books.Add(new Book("123", "dfhdf", "sdfh"));

            //foreach (var book in _books)
            //{
            //    if ("sdfh" == book.InventoryNumber)
            //    {
            //        _books.Remove(_books[0]);
            //    }
            //}

            //Book book1 = _books[0];
        }

        public Library(List<Book> books)
        {
            _books = books;
            _users = new List<User>(20);
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Remove(string key)
        {
            foreach (var book in _books)
            {
                if (key == book.InventoryNumber)
                {
                    _books.Remove(book);
                    break;
                }
            }
        }

        public void Remove(Book book)
        {
            _books.Remove(book);
            
        }

        public void Show()
        {
            foreach (var book in _books)
                Console.WriteLine(book);
                //Console.WriteLine($"{book.Title}, {book.Author}, {book.InventoryNumber}");
        }

    }
}
