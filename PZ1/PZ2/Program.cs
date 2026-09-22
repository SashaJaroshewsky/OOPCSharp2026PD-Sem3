namespace PZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Одновимірний масив
            int[] array1D = new int[3];

            // Двовимірний масив
            int[,] array2D = new int[3, 3];

            // трьохвимірний масив
            int[,,] array3D = new int[3, 3, 3];

            // Зубчастий масив (jagged array)
            int[][] arrayJagged = new int[3][];
            arrayJagged[0] = new int[1];
            arrayJagged[1] = new int[2];
            arrayJagged[2] = new int[3];

            // Заповнення зупчастого масиву випадковими числами
            Random random = new Random();
            for (int i = 0; i < arrayJagged.Length; i++)
            {
                for (int j = 0; j < arrayJagged[i].Length; j++)
                {
                    arrayJagged[i][j] = random.Next(1, 10);
                }
            }

            // Виведення зубчастого масиву
            Console.WriteLine("Зубчастий масив:");
            for (int i = 0; i < arrayJagged.Length; i++)
            {
                for (int j = 0; j < arrayJagged[i].Length; j++)
                {
                    Console.Write(arrayJagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("======================");

            Task1 task1 = new Task1();
            task1.Run();

        }
    }
}
