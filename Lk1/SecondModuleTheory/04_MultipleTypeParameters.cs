using System;

namespace SecondModuleTheory.MultipleTypeParameters
{
    // ТЕРМІН:
    // Узагальнений тип чи метод може мати КІЛЬКА параметрів типу, перелічених через кому: Pair<TFirst, TSecond>.
    // Кожен параметр незалежний: їм можна підставити як різні, так і однакові типи.

    // АНАЛОГІЯ:
    // Бланк з двома полями: "Студент: ________  Оцінка: ________".
    // У перше поле вписують текст, у друге - число. Поля незалежні одне від одного.

    // ПОЯСНЕННЯ - правила іменування параметрів типу (рекомендації Microsoft):
    // - Якщо параметр один і його зміст очевидний - називаємо просто T.
    // - Якщо параметрів кілька або зміст важливий - даємо описові імена з префіксом T:
    //   TKey, TValue, TFirst, TSecond, TResult, TItem.
    // У .NET багато таких типів: Dictionary<TKey, TValue>, KeyValuePair<TKey, TValue>.

    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        // Метод повертає НОВУ пару з переставленими типами: Pair<TSecond, TFirst>
        public Pair<TSecond, TFirst> Swap()
        {
            return new Pair<TSecond, TFirst>(Second, First);
        }

        public override string ToString() => $"({First}, {Second})";
    }

    // Узагальнений метод теж може мати кілька параметрів типу
    public static class PairFactory
    {
        public static Pair<TFirst, TSecond> Create<TFirst, TSecond>(TFirst first, TSecond second)
        {
            return new Pair<TFirst, TSecond>(first, second);
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            Pair<string, int> grade = new Pair<string, int>("Олена", 95);
            Console.WriteLine($"{grade.First} отримала {grade.Second} балів");

            Pair<int, string> swapped = grade.Swap();
            Console.WriteLine(swapped);                 // (95, Олена)

            Pair<double, double> point = new Pair<double, double>(3.5, -1.0); // Однакові типи - теж можна
            Console.WriteLine(point);

            var city = PairFactory.Create("Львів", 1256); // Виведення: TFirst = string, TSecond = int
            Console.WriteLine($"{city.First} - перша згадка в {city.Second} році");
        }
    }
}
