
namespace Pr1
{
    internal class Task2
    {
        public void Run()
        {
            int[] numbers = new int[10];
            InitializeArrayRandom(numbers);
            PrintArray(numbers);
            Console.WriteLine($"Length of the array: {numbers.Length}");

            Console.WriteLine("Sum of array elements: " + SumArray(numbers));
            Console.WriteLine("Average of array elements: " + AvgArray(numbers));
            Console.WriteLine("Minimum value in the array: " + FindMin(numbers));
            Console.WriteLine("Maximum value in the array: " + FindMax(numbers));

        }

        public void InitializeArrayRandom(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                //                      [1, 101) 
                numbers[i] = random.Next(1, 101);
            }
        }

        public void PrintArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public int SumArray(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double AvgArray(int[] numbers)
        {
            int sum = SumArray(numbers);
            double average = (double)sum / numbers.Length;
            return average;
        }

        public int FindMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        public int FindMax(int[] numbers)
        {
            return numbers.Max();
        }
    }
}
