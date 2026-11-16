using System;
using System.Collections.Generic;

namespace SecondModuleTheory.HashSetCollection
{
    // ТЕРМІНИ:
    // HashSet<T> - колекція-множина: зберігає лише УНІКАЛЬНІ елементи, без індексів і без гарантованого порядку.
    // Множина (set) - математичне поняття: набір різних елементів, над яким визначені операції
    // об'єднання, перетину та різниці.

    // АНАЛОГІЯ:
    // Список гостей на вході до клубу. Охоронець перевіряє: якщо ім'я вже є в списку, вдруге його не записує.
    // Важливо лише "є людина чи немає", а не в якому порядку прийшли.

    // ПОЯСНЕННЯ:
    // - Add повертає true, якщо елемент додано, і false, якщо такий уже є (виняток НЕ виникає).
    // - Contains працює дуже швидко (як пошук ключа в Dictionary) - на відміну від List<T>.Contains.
    // - Використовуйте, коли важлива унікальність або часто треба перевіряти "чи є такий елемент".
    // - Операції над множинами ЗМІНЮЮТЬ ту множину, на якій їх викликали:
    //     UnionWith     - об'єднання (усі елементи з обох)
    //     IntersectWith - перетин (лише спільні)
    //     ExceptWith    - різниця (прибрати ті, що є в іншій)

    internal static class Demo
    {
        public static void Run()
        {
            HashSet<string> visitors = new HashSet<string>();
            Console.WriteLine(visitors.Add("Олена")); // True
            Console.WriteLine(visitors.Add("Тарас")); // True
            Console.WriteLine(visitors.Add("Олена")); // False - вже є
            Console.WriteLine($"Унікальних відвідувачів: {visitors.Count}"); // 2

            // Швидке видалення дублікатів з масиву
            int[] withDuplicates = { 1, 2, 2, 3, 3, 3 };
            HashSet<int> unique = new HashSet<int>(withDuplicates);
            Console.WriteLine(string.Join(", ", unique)); // 1, 2, 3

            // Операції над множинами: студенти в гуртках
            HashSet<string> chess = new HashSet<string> { "Олена", "Тарас", "Ірина" };
            HashSet<string> football = new HashSet<string> { "Тарас", "Петро", "Ірина" };

            // Створюємо копію, бо операція змінює множину, на якій її викликано
            HashSet<string> both = new HashSet<string>(chess);
            both.IntersectWith(football);
            Console.WriteLine($"В обох гуртках: {string.Join(", ", both)}");   // Тарас, Ірина

            HashSet<string> all = new HashSet<string>(chess);
            all.UnionWith(football);
            Console.WriteLine($"Хоча б в одному: {string.Join(", ", all)}");   // Олена, Тарас, Ірина, Петро

            HashSet<string> onlyChess = new HashSet<string>(chess);
            onlyChess.ExceptWith(football);
            Console.WriteLine($"Лише шахи: {string.Join(", ", onlyChess)}");   // Олена

            // Примітка: порядок виводу елементів множини не гарантований і може відрізнятися.
        }
    }
}
