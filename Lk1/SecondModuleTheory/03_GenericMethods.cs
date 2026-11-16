using System;

namespace SecondModuleTheory.GenericMethods
{
    // ТЕРМІНИ:
    // Узагальнений метод (generic method) - метод, що має власний параметр типу,
    // оголошений у кутових дужках одразу після імені методу: void Swap<T>(...).
    // Виведення типів (type inference) - здатність компілятора самостійно визначити аргумент типу
    // за типами переданих аргументів, тож <int> можна не писати.

    // АНАЛОГІЯ:
    // Дія "поміняти місцями вміст лівої та правої руки" однакова для будь-яких предметів:
    // яблук, ключів чи телефонів. Саму дію описуємо один раз, а предмет може бути будь-яким.

    // ПОЯСНЕННЯ:
    // - Узагальнений метод може бути у звичайному (НЕузагальненому) класі, навіть у статичному.
    // - Параметр типу методу "живе" лише всередині цього методу.
    // - Компілятор виводить T з аргументів, але НЕ з типу результату:
    //   якщо T використовується лише в результаті, тип треба вказати явно, наприклад Create<Product>().
    // - Ми вже користувалися вбудованим узагальненим методом: Array.Resize<T>(ref T[] array, int newSize).

    public static class Utils
    {
        // Міняє місцями значення двох змінних будь-якого (але однакового) типу
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Виводить усі елементи масиву будь-якого типу
        public static void PrintArray<T>(T[] items)
        {
            Console.WriteLine($"Масив {typeof(T).Name}[{items.Length}]: {string.Join(", ", items)}");
        }

        // Створює масив заданої довжини, заповнений одним значенням
        public static T[] Fill<T>(T value, int count)
        {
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = value;
            }
            return result;
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            int x = 1, y = 2;
            Utils.Swap<int>(ref x, ref y);   // Явно вказуємо аргумент типу
            Utils.Swap(ref x, ref y);        // Виведення типу: компілятор сам бачить, що T = int
            Console.WriteLine($"{x} {y}");   // 1 2 (поміняли двічі)

            string first = "А", second = "Б";
            Utils.Swap(ref first, ref second); // T = string
            Console.WriteLine($"{first} {second}"); // Б А

            // Utils.Swap(ref x, ref first); // Помилка: T не може бути одночасно int і string

            Utils.PrintArray(new[] { 1, 2, 3 });        // T = int
            Utils.PrintArray(new[] { "кіт", "пес" });   // T = string

            string [] stars = Utils.Fill("*", 5);         // T виводиться з першого аргументу -> string
            Utils.PrintArray(stars);
        }
    }
}
