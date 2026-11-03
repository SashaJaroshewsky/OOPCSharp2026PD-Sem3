using PZ3;

namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           OverloadMethods overloadMethods = new OverloadMethods();

            overloadMethods.MackeTee();

            Console.WriteLine("============================");
            overloadMethods.MackeTee("Green Tea");
            Console.WriteLine("============================");
            overloadMethods.MackeTee("Black Tea", 2);
            Console.WriteLine("============================");
            overloadMethods.MackeTee("Herbal Tea", 1, true);
            Console.WriteLine("============================");
            overloadMethods.MackeTee("Oolong Tea", false);

            //Animal animal = new Animal("Buddy");
        }

        //public bool addbookviaid(int bkid, ref book[] books, ref reader reader)
        //{
        //    Book fBook;
        //    foreach (var book in books)
        //    {
        //        if (book.getid() == bkid) 
        //        {
        //            fBook = book;
        //            break;
        //        }
        //    }

        //    if(fBook == null)
        //    {
        //        Console.WriteLine();
        //        return false;
        //    }

        //    if(fBook.taken != true)
        //    {
        //        Console.WriteLine();
        //        return false;
        //    }

        //    reader.addbook(book);
        //    book.taken = true;
        //    Console.WriteLine($"sucsess");
        //    return true; 





        //    foreach (book book in books)
        //    {
        //        if (book.getid() == bkid && book.taken != true)
        //        {
        //            reader.addbook(book);
        //            book.taken = true;
        //            Console.WriteLine($"sucsess");
        //            return;
        //        }
                
        //    }
        //    else if (book.getid() == bkid && book.taken)
        //    {
        //        Console.WriteLine("book had been taken");
        //        return;
        //    }

        //    Console.WriteLine($"no book found with such id or it is already taken");
        //}
    }
}
