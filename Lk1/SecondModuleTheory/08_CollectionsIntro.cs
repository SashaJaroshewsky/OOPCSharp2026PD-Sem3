using System;
using System.Collections.Generic; // Тут "живуть" узагальнені колекції: List<T>, Dictionary<TKey, TValue>, ...

namespace SecondModuleTheory.CollectionsIntro
{
    // ТЕРМІН:
    // Колекція (collection) - об'єкт, що зберігає групу елементів і надає операції для роботи з ними:
    // додавання, видалення, пошук, перебір. На відміну від масиву, більшість колекцій змінюють розмір автоматично.

    // АНАЛОГІЯ:
    // Масив - це лоток для яєць на 10 місць: розмір фіксований, 11-те яйце не влізе,
    // а щоб вставити яйце в середину, доведеться перекладати решту вручну.
    // Колекція - це сумка, що розтягується: кладеш скільки треба, вона сама підлаштовується.
    // До того ж є різні "сумки" під різні задачі: з кишеньками (словник), черга, стопка тощо.

    // ПОЯСНЕННЯ:
    // У .NET є два набори колекцій:
    //   System.Collections          - старі, неузагальнені (ArrayList, Hashtable). Зберігають object. У новому коді НЕ використовуємо.
    //   System.Collections.Generic  - узагальнені (List<T>, Dictionary<TKey, TValue>, ...). Типобезпечні, без упаковки.
    //
    // Колекції побудовані на ієрархії інтерфейсів (кожен наступний розширює попередній):
    //   IEnumerable<T>          - можна перебрати у foreach
    //     └ ICollection<T>      - + Count, Add, Remove, Contains, Clear
    //         └ IList<T>        - + доступ за індексом [i], Insert, IndexOf, RemoveAt
    //   IDictionary<TKey, TValue> - доступ до значення за ключем
    //
    // Основні колекції, які розглянемо далі:
    //   List<T>                   - список (динамічний масив)
    //   Dictionary<TKey, TValue>  - словник "ключ -> значення"
    //   HashSet<T>                - множина унікальних елементів
    //   Queue<T>                  - черга (першим прийшов - першим вийшов)
    //   Stack<T>                  - стек (останнім прийшов - першим вийшов)

    internal static class Demo
    {
        public static void Run()
        {
            // Масив: розмір задається при створенні і не змінюється
            string[] array = new string[2];
            array[0] = "Київ";
            array[1] = "Львів";
            // array[2] = "Одеса"; // IndexOutOfRangeException - місця немає

            // Колекція: просто додаємо
            List<string> list = new List<string>();
            list.Add("Київ");
            list.Add("Львів");
            list.Add("Одеса");
            Console.WriteLine($"Масив: {array.Length} ел., список: {list.Count} ел.");

            // Програмування на рівні інтерфейсу (поліморфізм!):
            // змінна має тип інтерфейсу, тому реалізацію можна замінити, не змінюючи решту коду.
            ICollection<string> cities = new List<string>();
            AddCities(cities);
            Console.WriteLine($"List: {cities.Count}");     // 3 - список зберігає дублікати

            cities = new HashSet<string>();
            AddCities(cities);
            Console.WriteLine($"HashSet: {cities.Count}");  // 2 - множина відкидає дублікат
        }

        // Метод не знає, яка саме колекція прийде, - йому достатньо контракту ICollection<T>
        private static void AddCities(ICollection<string> collection)
        {
            collection.Add("Київ");
            collection.Add("Львів");
            collection.Add("Київ");
        }
    }
}
