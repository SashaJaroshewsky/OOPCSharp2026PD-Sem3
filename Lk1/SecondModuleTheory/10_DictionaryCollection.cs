using System;
using System.Collections.Generic;

namespace SecondModuleTheory.DictionaryCollection
{
    // ТЕРМІНИ:
    // Dictionary<TKey, TValue> - колекція пар "ключ - значення", у якій за ключем дуже швидко знаходиться значення.
    // Ключ (key) - унікальний ідентифікатор запису; двох однакових ключів у словнику бути не може.
    // Значення (value) - дані, пов'язані з ключем; значення можуть повторюватися.
    // KeyValuePair<TKey, TValue> - структура, що зберігає одну пару (властивості Key і Value).

    // АНАЛОГІЯ:
    // Гардероб у театрі. Віддаєш пальто - отримуєш номерок (ключ).
    // Гардеробниця не перебирає всі пальта, а одразу йде до гачка з потрібним номером.
    // Двох однакових номерків не буває, а от однакових пальт може бути скільки завгодно.

    // ПОЯСНЕННЯ:
    // - Усередині словник - це хеш-таблиця: з ключа обчислюється хеш-код (число), що вказує, де лежить значення.
    //   Тому швидкість пошуку за ключем майже не залежить від кількості елементів - на відміну від пошуку в List<T>.
    // - Порядок елементів у словнику НЕ гарантований - не покладайтеся на нього.
    // - Додати наявний ключ через Add -> виняток ArgumentException.
    // - Прочитати відсутній ключ через [key] -> виняток KeyNotFoundException.
    //   Тому для читання "можливо відсутнього" ключа використовують TryGetValue.

    internal static class Demo
    {
        public static void Run()
        {
            // Телефонна книга: ім'я -> номер
            Dictionary<string, string> phones = new Dictionary<string, string>();
            phones.Add("Олена", "067-111-22-33");
            phones.Add("Тарас", "050-444-55-66");
            // phones.Add("Олена", "000");      // ArgumentException: ключ уже існує

            phones["Ірина"] = "093-777-88-99";   // Індексатор: додає, якщо ключа немає...
            phones["Тарас"] = "050-000-00-00";   // ...або замінює значення, якщо ключ є

            Console.WriteLine(phones["Олена"]);  // Читання за ключем
            // Console.WriteLine(phones["Петро"]); // KeyNotFoundException

            // Безпечне читання
            if (phones.TryGetValue("Петро", out string? number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Петра немає в книзі");
            }

            Console.WriteLine(phones.ContainsKey("Ірина")); // True
            phones.Remove("Ірина");

            // Перебір: кожен елемент - KeyValuePair<string, string>
            foreach (KeyValuePair<string, string> pair in phones)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            // Окремо ключі та значення
            Console.WriteLine(string.Join(", ", phones.Keys));
            Console.WriteLine(string.Join(", ", phones.Values));

            // Ініціалізатор словника
            Dictionary<string, int> stock = new Dictionary<string, int>
            {
                ["яблука"] = 50,
                ["груші"] = 20
            };
            Console.WriteLine($"Яблук на складі: {stock["яблука"]}");

            // Класична задача: скільки разів трапляється кожне слово
            string text = "кіт пес кіт риба пес кіт";
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in text.Split(' '))
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            foreach (var (word, count) in counts) // Деконструкція пари на дві змінні
            {
                Console.WriteLine($"{word}: {count}"); // кіт: 3, пес: 2, риба: 1
            }
        }
    }
}
