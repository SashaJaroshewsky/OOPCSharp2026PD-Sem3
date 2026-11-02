namespace FirstModuleTheory._014
{
    // ad hoc polymorphism (статичний, під час компіляції) — перевантаження методів та операторів
    // (методи з однаковим ім'ям, але різною сигнатурою).

    public class AdHocPolymorphism
    {
        // Перевантаження методу Add з різними параметрами
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
    }

    public class ExampleAdHocPolymorphism
    {
        public void Example()
        {
            var adHoc = new AdHocPolymorphism();
            int sumInt = adHoc.Add(2, 3); // Викликається Add(int, int)
            double sumDouble = adHoc.Add(2.5, 3.5); // Викликається Add(double, double)
            string sumString = adHoc.Add("Hello, ", "World!"); // Викликається Add(string, string)
            // Дія одна - додавання, але поведінка різна в залежності від типів параметрів (int, double, string).

            Console.WriteLine($"Sum of integers: {sumInt}");
            Console.WriteLine($"Sum of doubles: {sumDouble}");
            Console.WriteLine($"Sum of strings: {sumString}");
        }
    }
}
