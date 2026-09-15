
namespace PZ1._1
{
    internal class Task2
    {
        public void Run()
        {
            int[] arr = new int[10];

            InitializeArrayRandom(arr);
            PrintResult(arr);
            Console.WriteLine("Sum: " + ArraySum(arr));
            Console.WriteLine("Average: " + ArrayAverage(arr));
            Console.WriteLine("Max: " + Max(arr));
            Console.WriteLine("Min: " + Min(arr));
        }

        private void PrintResult(int[] arr)
        {
            Console.WriteLine("Array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        private void InitializeArrayRandom(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 101);
            }
        }

        private int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        private double ArrayAverage(int[] arr)
        {
            int sum = ArraySum(arr);
            return (double)sum / arr.Length;
        }

        private int Max(int[] arr)
        {
            return arr.Max();
        }

        private int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
