
namespace PZ1._1
{
    internal class Task1
    {
        public void Run()
        {
            int number = 4; 
            bool isEven = IsEven(number);
            PrintResult(isEven);
        }
        private bool IsEven(int number)
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
