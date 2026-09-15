
namespace PZ1
{
    internal class Task3
    {
        public void Run()
        {
           

            string input;
            do
            {
                input = Console.ReadLine();

            } while (!int.TryParse(input, out int a));

        }
    }
}
