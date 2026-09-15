
namespace PZ1
{
    internal class Task2
    {
        public void Run()
        {
            int[] arr = new int[10];

            InitializeArrayRandom(arr);
            PrintArray(arr);
            Console.WriteLine("Sum of array elements: " + SumArray(arr));
            Console.WriteLine("Average of array elements: " + AvgArray(arr));
            Console.WriteLine("Maximum element in the array: " + FindMax(arr));
            Console.WriteLine("Minimum element in the array: " + FindMin(arr));

        }

        public void InitializeArrayRandom(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                //                  [1, 101)  
                arr[i] = random.Next(1, 101);
            }
        }

        public void PrintArray(int[] arr)
        {
            Console.WriteLine("Array elements:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public double AvgArray(int[] arr)
        {
            int sum = SumArray(arr);
            return (double)sum / arr.Length;
        }

        public int FindMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public int FindMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

    }
}
