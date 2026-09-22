namespace PZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Одновимірний масив
            int[] array = new int[10];

            // Двовимірний масив
            int[,] twoDimensionalArray = new int[3, 4];

            // Зубчастий масив
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];

            // Виведення елементів зубчастого масиву
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Row {i}:");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
