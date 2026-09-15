
namespace PZ1
{
    internal class Task1
    {
        public void RunTask1()
        {
            int number = 5;
            bool isEven = IsEven(ref number);
            PrintResult(isEven);
        }

        private bool IsEven(ref int number)
        {
            return number % 2 == 0;
        }

        private void PrintResult(bool isEven)
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
