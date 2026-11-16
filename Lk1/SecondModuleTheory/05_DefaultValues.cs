using System;

namespace SecondModuleTheory.DefaultValues
{
    // ТЕРМІН:
    // Ключове слово default дає значення за замовчуванням для будь-якого типу:
    //   - числові типи (int, double, ...) -> 0
    //   - bool -> false
    //   - char -> '\0' (символ з кодом 0)
    //   - посилальні типи (string, класи, масиви) -> null
    //   - структури (struct, наприклад DateTime) -> структура, у якої всі поля мають значення за замовчуванням
    // Записується як default(T) або коротко default, якщо тип зрозумілий з контексту.

    // АНАЛОГІЯ:
    // "Порожня клітинка" в таблиці. Для стовпця "Кількість" порожнє - це 0,
    // для стовпця "Так/Ні" - "Ні", для стовпця "Ім'я" - нічого (null).
    // default - це спосіб сказати "порожня клітинка", не знаючи, який це стовпець.

    // ПОЯСНЕННЯ:
    // Усередині узагальненого коду ми не знаємо, яким буде T.
    // Написати "return 0;" не можна (а якщо T - string?), "return null;" теж не можна (а якщо T - int?).
    // default(T) підходить для БУДЬ-ЯКОГО T.
    //
    // Примітка про T? у результаті методу: це позначка "може повернутися значення за замовчуванням".
    // Для посилальних типів це null. Для значимих типів T? НЕ стає int? - повертається звичайний 0.

    public static class SafeArray
    {
        // Повертає елемент за індексом або значення за замовчуванням, якщо індекс поза межами масиву
        public static T? GetOrDefault<T>(T[] items, int index)
        {
            if (index >= 0 && index < items.Length)
            {
                return items[index];
            }
            return default; // те саме, що default(T)
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            Console.WriteLine(default(int));              // 0
            Console.WriteLine(default(bool));             // False
            Console.WriteLine(default(string) == null);   // True
            Console.WriteLine(default(DateTime));         // 01.01.0001 00:00:00 (формат залежить від мови системи)

            int[] numbers = { 10, 20, 30 };
            Console.WriteLine(SafeArray.GetOrDefault(numbers, 1));   // 20
            Console.WriteLine(SafeArray.GetOrDefault(numbers, 10));  // 0 - індекс поза межами

            string[] names = { "Іван", "Марія" };
            string? name = SafeArray.GetOrDefault(names, 5);         // null
            Console.WriteLine(name ?? "(немає)");                     // (немає)
        }
    }
}
