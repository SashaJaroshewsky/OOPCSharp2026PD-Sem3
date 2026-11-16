using System;
using System.Collections.Generic;

namespace SecondModuleTheory.ListCollection
{
    // ТЕРМІНИ:
    // List<T> - узагальнена колекція-список: впорядкована послідовність елементів з доступом за індексом,
    // розмір якої змінюється автоматично. Усередині - звичайний масив (тому його ще називають динамічним масивом).
    // Count - кількість елементів, що реально є у списку.
    // Capacity - місткість: скільки елементів уміщує внутрішній масив до наступного розширення.

    // АНАЛОГІЯ:
    // Список покупок у блокноті: пункти йдуть по порядку (1, 2, 3...), можна дописати в кінець,
    // вставити між рядками, викреслити зайве. Коли сторінка закінчується, переписуєш усе
    // на більшу сторінку (Capacity зростає) і пишеш далі, не думаючи про місце.

    // ПОЯСНЕННЯ:
    // - Коли Count досягає Capacity, List<T> створює новий масив, удвічі більший, і копіює туди елементи.
    //   Тому додавання в кінець зазвичай дуже швидке.
    // - Вставка й видалення на початку чи в середині повільніші: решту елементів треба зсунути.
    // - Пошук Contains / IndexOf перебирає елементи по черзі - на великих списках це повільно.
    // - List<T> - колекція "за замовчуванням": якщо немає особливих вимог, беремо її.
    // - УВАГА: не можна додавати або видаляти елементи списку всередині foreach по цьому ж списку -
    //   буде InvalidOperationException. Для видалення використовуйте for у зворотному порядку.

    internal static class Demo
    {
        public static void Run()
        {
            List<string> shopping = new List<string>();
            Console.WriteLine($"Count = {shopping.Count}, Capacity = {shopping.Capacity}"); // 0, 0

            // Додавання
            shopping.Add("хліб");                          // у кінець
            shopping.Add("молоко");
            shopping.AddRange(new[] { "сир", "яблука" });  // кілька елементів одразу
            shopping.Insert(0, "кава");                    // на позицію 0, решта зсуваються
            Console.WriteLine($"Count = {shopping.Count}, Capacity = {shopping.Capacity}"); // 5, 8

            // Доступ за індексом - як у масиві
            Console.WriteLine(shopping[1]);                // хліб
            shopping[1] = "батон";                         // заміна елемента

            // Пошук
            Console.WriteLine(shopping.Contains("сир"));   // True
            Console.WriteLine(shopping.IndexOf("молоко")); // 2  (-1, якщо не знайдено)

            // Видалення
            shopping.Remove("сир");   // за значенням (перше входження); повертає true/false
            shopping.RemoveAt(0);     // за індексом

            // Сортування та розворот
            shopping.Sort();          // за алфавітом (для власних класів - див. тему про порівняння)
            shopping.Reverse();

            // Перебір
            foreach (string item in shopping)
            {
                Console.WriteLine($"- {item}");            // яблука, молоко, батон
            }

            // Ініціалізатор колекції - коротке заповнення при створенні
            List<int> grades = new List<int> { 90, 75, 100, 60 };

            // Безпечне видалення в циклі: for у зворотному напрямку
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 70)
                {
                    grades.RemoveAt(i);
                }
            }
            // foreach (int g in grades) { if (g < 70) grades.Remove(g); } // InvalidOperationException!

            int[] asArray = grades.ToArray();         // список -> масив
            List<int> copy = new List<int>(asArray);  // масив -> список (новий, незалежний)
            Console.WriteLine(string.Join(", ", copy)); // 90, 75, 100
        }
    }
}
