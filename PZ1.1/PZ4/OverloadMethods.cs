namespace PZ4
{
    internal class OverloadMethods
    {
        public OverloadMethods()
        {
        }
        public void MackeTee()
        {
            Console.WriteLine("Гріємо воду");
            Console.WriteLine("Заливаємо воду в чашку");
            Console.WriteLine("Засипаємо чай");
            Console.WriteLine("Заварюємо чай в пакетику");
        }

        //public int MackeTee()
        //{
        //    Console.WriteLine("Гріємо воду");
        //    Console.WriteLine("Заливаємо воду в чашку");
        //    Console.WriteLine("Засипаємо чай");
        //    Console.WriteLine("Заварюємо чай в пакетику");
        //    return 1;
        //}

        public void MackeTee(string type)
        {
            Console.WriteLine("Гріємо воду");
            Console.WriteLine("Заливаємо воду в чашку");
            Console.WriteLine("Засипаємо чай");
            Console.WriteLine($"Варимо чай {type}");
        }

        public void MackeTee(string type, int sugar)
        {
            Console.WriteLine("Гріємо воду");
            Console.WriteLine("Заливаємо воду в чашку");
            Console.WriteLine("Засипаємо чай");
            Console.WriteLine($"Варимо чай {type}");
            Console.WriteLine($"Додаємо цукор {sugar} ложки");
            Console.WriteLine("Помішали чай");
        }
        public void MackeTee(int sugar, string type)
        {
            Console.WriteLine("Гріємо воду");
            Console.WriteLine("Заливаємо воду в чашку");
            Console.WriteLine("Засипаємо чай");
            Console.WriteLine($"Варимо чай {type}");
            Console.WriteLine($"Додаємо цукор {sugar} ложки");
            Console.WriteLine("Помішали чай");
        }

        public void MackeTee(string type, bool milk)
        {
            Console.WriteLine("Гріємо воду");
            Console.WriteLine("Заливаємо воду в чашку");
            Console.WriteLine("Засипаємо чай");
            Console.WriteLine($"Варимо чай {type}");
            Console.WriteLine("Помішали чай");
        }

        public void MackeTee(string type, int sugar, bool milk)
        {
            Console.WriteLine("Гріємо воду");
            Console.WriteLine("Заливаємо воду в чашку");
            Console.WriteLine("Засипаємо чай");
            Console.WriteLine($"Варимо чай {type}");
            Console.WriteLine($"Додаємо цукор {sugar} ложки");
            Console.WriteLine("Додаємо молоко");
            Console.WriteLine("Помішали чай");
        }
    }
}
