
namespace PZ5.Library
{
    internal class Rent
    {
        public int ID { get; }
        public Book Book { get; } 

        public User User { get; }

        public DateTime RentDateTime { get; }

        public DateTime ReturnDateTime { get; }

        public Rent(int id,Book book, User user)
        {
            ID = id;
            Book = book;
            User = user;

            RentDateTime = DateTime.Now;
            ReturnDateTime = RentDateTime.AddDays(14);
        }

        public override string ToString()
        {
            return $"Rent: {ID}, {Book}, {User}, {RentDateTime}, {ReturnDateTime}";
        }

    }
}
