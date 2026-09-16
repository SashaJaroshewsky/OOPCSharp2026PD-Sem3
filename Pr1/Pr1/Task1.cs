
namespace Pr1
{
    public class Task1
    {
        public void Run()
        {
            PrintEvenResult(IsEven(4));
        }
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private void PrintEvenResult(bool isEven)
        {
            if (isEven)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
