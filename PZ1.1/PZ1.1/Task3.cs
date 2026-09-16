

namespace PZ1._1
{
    internal class Task3
    {
        public void Run()
        {
            int a;
            int b = 6;
            int c;

            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("The number is: " + a);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            float P = 0;
            P = Math.Max(a, b);

            do
            {

            } while (!int.TryParse(Console.ReadLine(), out a));

        }
    }
}
