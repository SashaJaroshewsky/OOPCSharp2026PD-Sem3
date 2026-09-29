namespace PZ1._1
{
    public class Program
    {
        static void Main()
        {
            //Task1 task1 = new Task1();
            //task1.Run();

            //Console.WriteLine("========================");
            //Task2 task2 = new Task2();
            //task2.Run();

            //Console.WriteLine("========================");
            //Task3 task3 = new Task3();
            //task3.Run();

            //Console.WriteLine("========================");
            //Task4 task4 = new Task4();
            //task4.Run();

            new Task5().Run();

            Task5 task5 = new Task5(6, DateTime.Now);
            task5.Run();
            Task5 task51 = new Task5(7, DateTime.Now);

            Task5 task52 = task5;
        }

       
    }
}
