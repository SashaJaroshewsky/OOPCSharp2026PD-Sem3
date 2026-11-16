using System;
using System.Collections;          // Неузагальнений IEnumerable (потрібен для сумісності)
using System.Collections.Generic;

namespace SecondModuleTheory.EnumerationAndForeach
{
    // ТЕРМІНИ:
    // IEnumerable<T> - інтерфейс "мене можна перебрати". Має один метод GetEnumerator().
    //   Його реалізують усі колекції та масиви, саме тому їх можна перебирати у foreach.
    // IEnumerator<T> - перечислювач (енумератор): об'єкт, що виконує сам перебір. Має:
    //   MoveNext() - перейти до наступного елемента (повертає false, коли елементи закінчилися)
    //   Current    - поточний елемент
    // yield return - оператор для написання ітератора (методу, що видає елементи по одному)
    //   без створення класу-енумератора вручну: компілятор згенерує його сам.

    // АНАЛОГІЯ:
    // Плеєр з кнопкою "Наступний трек" (MoveNext) і екраном "Зараз грає" (Current).
    // Слухачеві не важливо, де зберігаються пісні: на диску, флешці чи в інтернеті.
    // IEnumerable - це плейлист, який уміє видати такий плеєр.

    // ПОЯСНЕННЯ:
    // foreach - це "синтаксичний цукор". Компілятор перетворює
    //     foreach (var x in items) { ... }
    // приблизно на такий код:
    //     IEnumerator<T> e = items.GetEnumerator();
    //     while (e.MoveNext()) { var x = e.Current; ... }
    //
    // Метод з yield return виконується "ліниво" (відкладене виконання):
    // код усередині запускається не під час виклику методу, а тоді, коли foreach просить наступний елемент.
    // Саме на IEnumerable<T> і відкладеному виконанні побудований LINQ (одна з наступних тем).

    // ПРИКЛАД 1: власна колекція, яку можна перебрати у foreach
    public class Playlist : IEnumerable<string>
    {
        private readonly List<string> _songs = new List<string>();

        public void Add(string song) => _songs.Add(song);

        // Узагальнена версія - саме її використовує foreach
        public IEnumerator<string> GetEnumerator()
        {
            foreach (string song in _songs)
            {
                yield return song; // Віддаємо пісню і "ставимо метод на паузу" до наступного запиту
            }
        }

        // IEnumerable<T> успадковує старий неузагальнений IEnumerable, тому треба реалізувати і його.
        // Це явна реалізація інтерфейсу: просто перенаправляємо виклик на метод вище.
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // ПРИКЛАД 2: метод-ітератор
    public static class Sequences
    {
        // Парні числа від 0 до max. Список не створюється - числа обчислюються по одному на вимогу.
        public static IEnumerable<int> EvenNumbers(int max)
        {
            for (int i = 0; i <= max; i += 2)
            {
                Console.WriteLine($"  (обчислюю {i})");
                yield return i;
            }
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            // Клас має метод Add і реалізує IEnumerable - тому працює ініціалізатор колекції
            Playlist playlist = new Playlist { "Червона рута", "Стефанія" };
            playlist.Add("Обійми");

            foreach (string song in playlist)
            {
                Console.WriteLine(song);
            }

            // Те саме, що робить foreach "під капотом".
            // using - бо IEnumerator<T> реалізує IDisposable і його треба звільнити після роботи
            using (IEnumerator<string> e = playlist.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }

            // Відкладене виконання
            IEnumerable<int> evens = Sequences.EvenNumbers(10);
            Console.WriteLine("Метод викликано, але ще нічого не обчислено");
            foreach (int n in evens)
            {
                Console.WriteLine(n);
                if (n == 4)
                {
                    break; // Числа 6, 8, 10 не будуть обчислені взагалі
                }
            }
        }
    }
}
