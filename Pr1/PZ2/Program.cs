namespace PZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // одновимірний масив
            int[] arr = new int[3];

            // двовимірний масим
            int[,] arr2 = new int[2,2];

            // зубчасті масиви

            int[][] arr3 = new int[3][];

            arr3[0] = new int[2];
            arr3[1] = new int[3];
            arr3[2] = new int[1];

            Random random = new Random();
            //for(int i=0; i < arr3.Length; i++)
            //{
            //    arr3[i] = new int[random.Next(2,3)];
            //}

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {                         //[1, 21)
                    arr3[i][j] = random.Next(1, 20);
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write($"{arr3[i][j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}
