
namespace PZ5.Library
{
    internal class Book
    {
        private string _title;
        private string _author;
        private string _inventoryNumber;

        public string Title => _title;
        public string Author => _author;

        public string InventoryNumber => _inventoryNumber;

        public Book(string title, string author, string inventoryNumber)
        {
            _title = title;
            _author = author;
            _inventoryNumber = inventoryNumber;
        }

        public override string ToString()
        {
            return $"{Title}, {Author}, {InventoryNumber}";
        }

    }
}
