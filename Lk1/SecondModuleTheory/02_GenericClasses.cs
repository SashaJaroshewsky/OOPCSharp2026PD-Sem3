using System;

namespace SecondModuleTheory.GenericClasses
{
    // ТЕРМІНИ:
    // Узагальнення (generics) - механізм C#, що дозволяє оголошувати класи, інтерфейси та методи
    // з параметром типу. Конкретний тип підставляється тоді, коли клас використовують.
    //
    // Узагальнений клас (generic class) - клас, оголошений з одним або кількома параметрами типу в кутових дужках: Box<T>.
    // Параметр типу (type parameter) - "заповнювач" для типу, який вкажуть пізніше. Зазвичай позначається T (від Type).
    // Аргумент типу (type argument) - конкретний тип, який підставляють замість параметра: у Box<int> аргумент типу - int.

    // АНАЛОГІЯ:
    // Бланк заяви з порожнім полем "Прошу видати ________".
    // Текст бланка однаковий для всіх, а в поле кожен вписує своє.
    // Box<T> - це бланк, Box<int> і Box<string> - заповнені бланки.
    // Продовжуючи аналогію зі складом: тепер на коробці є наклейка "Тільки для книжок",
    // і охоронець (компілятор) не дасть покласти туди чашку.

    // ПОЯСНЕННЯ:
    // - Код класу пишемо один раз, використовуємо з будь-яким типом.
    // - Компілятор знає конкретний тип -> немає приведень, немає упаковки, помилки видно ще до запуску.
    // - Box<T> називають відкритим типом (open type), Box<int> - закритим, або сконструйованим (closed / constructed type).
    // - Box<int> і Box<string> - це РІЗНІ типи. Присвоїти один одному їх не можна.

    // ПРИКЛАД 1: коробка для одного значення будь-якого типу.
    public class Box<T>
    {
        // Усередині класу T використовується як звичайний тип: для полів, властивостей, параметрів, результатів методів.
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public void Print()
        {
            // typeof(T) дозволяє дізнатися, який тип підставили замість T
            Console.WriteLine($"Box<{typeof(T).Name}> містить: {Value}");
        }
    }

    // ПРИКЛАД 2: власний простий стек (стопка) на основі масиву.
    // Схожий клас Stack<T> уже є в .NET - ми розглянемо його в темі про колекції.
    public class SimpleStack<T>
    {
        private T[] _items = new T[4]; // Масив елементів типу T
        private int _count = 0;

        public int Count => _count;

        public void Push(T item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2); // Збільшуємо масив удвічі, коли закінчилося місце
            }
            _items[_count] = item;
            _count++;
        }

        public T Pop()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Стек порожній");
            }
            _count--;
            return _items[_count];
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            Box<int> intBox = new Box<int>(42);
            int number = intBox.Value;       // Без приведення типу! Компілятор знає, що там int.
            // intBox.Value = "текст";       // Помилка КОМПІЛЯЦІЇ: не можна перетворити string на int
            intBox.Print();                  // Box<Int32> містить: 42

            Box<string> stringBox = new Box<string>("Привіт");
            stringBox.Print();               // Box<String> містить: Привіт
            // intBox = stringBox;           // Помилка: Box<int> і Box<string> - різні типи

            var dateBox = new Box<DateTime>(DateTime.Now); // var - тип виводиться з правої частини
            dateBox.Print();

            SimpleStack<string> books = new SimpleStack<string>();
            books.Push("Кобзар");
            books.Push("Тіні забутих предків");
            Console.WriteLine(books.Pop());  // Тіні забутих предків - останній покладений знімається першим
            Console.WriteLine(number + 1);   // 43 - звичайна арифметика, бо number має тип int
        }
    }
}
