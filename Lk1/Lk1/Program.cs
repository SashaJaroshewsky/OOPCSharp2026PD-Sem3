namespace Lk1
{
    public class Player
    {
        public int Health;

        public int GetHealth(int a)
        {
            return Health;
        }
    }

    class Program
    {
        static void Main()
        {
            int a = 5;
            Add(a);
            Console.WriteLine(a);

            Console.WriteLine("============");

            Player player = new Player();
            player.Health = 5;
            Console.WriteLine(player.Health);
            Add(player);
            Console.WriteLine(player.Health);

            Console.WriteLine("============");

            if (true)
            {
            }
            else if (true)
            {
            }
            else if (true)
            {
            }
            else
            {
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine(a);
                    break;
                default:
                    Console.WriteLine(a);
                    break;
            }

            while (true)
            {

            }

            do
            {

            } while (true);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] numbers = new int[] { 1, 2, 3 };

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Add(1, 2);
            Add(1);
            Add(player);
        }

        public static void Add(int a)
        {
            a++;
        }

        public static void Add(Player player)
        {
            player.Health++;
        }

        public static void Add(int a, int b)
        {
            a++;
            b++;
        }
        public static void Add(float a, float b)
        {
            a++;
            b++;
        }




        public static void Method1()
        {

        }
        public static int Method2()
        {
            return 0;
        }

        public static void Method3(int a, int b, int c)
        {

        }

        public static int Method4(int a, int b, int c)
        {
            return 0;
        }
    }
}
