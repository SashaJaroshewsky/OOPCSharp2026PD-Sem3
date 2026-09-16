namespace PZ1._1
{
    internal class Program
    {
        static void Main()
        {
            Task1 task1 = new Task1();
            task1.Run();
            Console.WriteLine("========================");
            Task2 task2 = new Task2();
            task2.Run();
            Console.WriteLine("========================");
            Task3 task3 = new Task3();
            task3.Run();

            Console.WriteLine("========================");
            Task4 task4 = new Task4();
            task4.Run();
        }

       
    }
}
