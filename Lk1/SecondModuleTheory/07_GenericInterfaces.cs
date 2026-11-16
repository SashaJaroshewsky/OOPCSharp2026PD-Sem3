using System;

namespace SecondModuleTheory.GenericInterfaces
{
    // ТЕРМІН:
    // Узагальнений інтерфейс (generic interface) - інтерфейс з параметром типу: IRepository<T>.
    // Він описує контракт, однаковий для різних типів даних.

    // АНАЛОГІЯ:
    // Посадова інструкція комірника: прийняти товар, видати товар за номером, порахувати залишки.
    // Інструкція однакова для складу книжок і складу запчастин - змінюється лише те, ЩО зберігають.

    // ПОЯСНЕННЯ:
    // Реалізувати узагальнений інтерфейс можна двома способами:
    //   1) Закрито - підставити конкретний тип:  class StudentRepository : IRepository<Student>
    //   2) Відкрито - узагальненим класом:       class MemoryRepository<T> : IRepository<T>
    // Багато ключових інтерфейсів .NET узагальнені:
    //   IComparable<T>  - "мене можна порівняти з іншим T"
    //   IEquatable<T>   - "мене можна перевірити на рівність з іншим T"
    //   IEnumerable<T>  - "мене можна перебрати у foreach" (на ньому побудовані всі колекції)

    // Інтерфейс-"ідентифікатор": кожна сутність має унікальний номер
    public interface IEntity
    {
        int Id { get; }
    }

    // Узагальнений інтерфейс сховища
    public interface IRepository<T>
    {
        void Add(T item);
        T? GetById(int id);   // T? - якщо не знайдено, повернеться default (для класів - null)
        int Count { get; }
    }

    public class Student : IEntity
    {
        public int Id { get; }
        public string Name { get; }
        public Student(int id, string name) { Id = id; Name = name; }
    }

    public class Book : IEntity
    {
        public int Id { get; }
        public string Title { get; }
        public Book(int id, string title) { Id = id; Title = title; }
    }

    // Спосіб 2: узагальнений клас реалізує узагальнений інтерфейс.
    // Обмеження where T : IEntity потрібне, щоб звертатися до item.Id
    public class MemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private T[] _items = new T[4];
        private int _count;

        public int Count => _count;

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count] = item;
            _count++;
        }

        public T? GetById(int id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Id == id)
                {
                    return _items[i];
                }
            }
            return default; // Не знайшли
        }
    }

    // Спосіб 1 (закрита реалізація) виглядав би так:
    // public class StudentRepository : IRepository<Student>
    // {
    //     public void Add(Student item) { ... }
    //     public Student? GetById(int id) { ... }
    //     public int Count { get { ... } }
    // }

    internal static class Demo
    {
        public static void Run()
        {
            // Працюємо через інтерфейс: одна й та сама реалізація для різних типів
            IRepository<Student> students = new MemoryRepository<Student>();
            students.Add(new Student(1, "Олена"));
            students.Add(new Student(2, "Тарас"));

            IRepository<Book> books = new MemoryRepository<Book>();
            books.Add(new Book(100, "Лісова пісня"));

            Student? found = students.GetById(2);
            Console.WriteLine(found?.Name ?? "Не знайдено");              // Тарас
            Console.WriteLine(books.GetById(5)?.Title ?? "Не знайдено");  // Не знайдено
            Console.WriteLine($"Студентів: {students.Count}, книжок: {books.Count}");
        }
    }
}
