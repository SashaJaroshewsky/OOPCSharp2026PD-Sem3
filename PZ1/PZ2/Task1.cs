

namespace PZ2
{
    internal class Task1
    {
        public void Run()
        {
            Random random = new Random();

            int[][] sofa = new int[3][];

            int sizeTemp = 0;
            int sizeMin = 1;
            int sizeMax = 10;
            for (int i = 0; i < sofa.Length; i++)
            {
                sizeMin += sizeTemp;
                sizeMax = sizeMin + random.Next(1, 10);
                sofa[i] = new int[random.Next(sizeMin, sizeMax)];
                for (int j = 0; j < sofa[i].Length; j++)
                {
                    sofa[i][j] = random.Next(50, 300);
                }
                sizeTemp = sofa[i].Length;
            }

            Console.WriteLine("Зубчастий масив (sofa):");
            for (int i = 0; i < sofa.Length; i++)
            {
                for (int j = 0; j < sofa[i].Length; j++)
                {
                    Console.Write(sofa[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < sofa.Length; i++)
            {
                Console.WriteLine($"Books in row {i}: {sofa[i].Length}");
            }

            Console.WriteLine();

            for (int i = 0; i < sofa.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < sofa[i].Length; j++)
                {
                    sum += sofa[i][j];
                }
                Console.WriteLine($"Sum of books in row {i}: {sum}");
            }

            Console.WriteLine();

            int totalSum = 0;
            for (int i = 0; i < sofa.Length; i++)
            {
                for (int j = 0; j < sofa[i].Length; j++)
                {
                    totalSum += sofa[i][j];
                }
            }
            Console.WriteLine($"Total sum of books: {totalSum}");
        }
    }
}
