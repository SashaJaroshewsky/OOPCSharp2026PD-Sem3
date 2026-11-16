using System;
using System.Collections.Generic;

namespace SecondModuleTheory.ComparingAndSorting
{
    // ТЕРМІНИ:
    // IComparable<T> - інтерфейс, що задає "природний" порядок об'єктів класу. Метод CompareTo(T other) повертає:
    //   від'ємне число - цей об'єкт менший (стоїть раніше); 0 - рівні; додатне число - більший (стоїть пізніше).
    // IComparer<T> - інтерфейс зовнішнього порівнювача: окремий клас з методом Compare(T x, T y).
    //   Дозволяє мати скільки завгодно різних способів сортування, не змінюючи сам клас.

    // АНАЛОГІЯ:
    // На уроці фізкультури учні шикуються за зростом - це їхній "природний" порядок (IComparable).
    // Але вчитель може сказати: "А тепер за алфавітом!" - це зовнішнє правило (IComparer).
    // Учні ті самі, а порядок визначає той, хто дає команду.

    // ПОЯСНЕННЯ:
    // - List<int>.Sort() працює одразу, бо int реалізує IComparable<int>.
    // - Для власного класу Sort() не знає, як порівнювати, і кидає InvalidOperationException,
    //   доки клас не реалізує IComparable<T> або в Sort не передадуть IComparer<T>.
    // - Той самий механізм використовують SortedSet<T>, SortedDictionary<TKey, TValue>, а також
    //   обмеження where T : IComparable<T> (див. тему "Обмеження").
    // - Student? у параметрах - так оголошено в самих інтерфейсах .NET: об'єкт для порівняння може бути null.
    // - У темі "Делегати та лямбди" побачимо коротший запис: list.Sort((a, b) => a.Name.CompareTo(b.Name)).

    public class Student : IComparable<Student>
    {
        public string Name { get; }
        public double AverageGrade { get; }

        public Student(string name, double averageGrade)
        {
            Name = name;
            AverageGrade = averageGrade;
        }

        // Природний порядок - за середнім балом (за зростанням)
        public int CompareTo(Student? other)
        {
            if (other is null)
            {
                return 1; // Будь-який об'єкт вважається "більшим" за null - так прийнято в .NET
            }
            return AverageGrade.CompareTo(other.AverageGrade); // Довіряємо порівняння типу double
        }

        public override string ToString() => $"{Name} ({AverageGrade})";
    }

    // Зовнішній порівнювач: за ім'ям 
    public class StudentByNameComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return string.Compare(x?.Name, y?.Name);
        }
    }

    // Зовнішній порівнювач: за балом, від найбільшого (рейтинг). Секрет - порівнюємо y з x, а не x з y.
    public class StudentByGradeDescendingComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x is null || y is null)
            {
                return 0; // Спрощення: null-студентів у нашому списку не буде
            }
            return y.AverageGrade.CompareTo(x.AverageGrade);
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 5, 1, 4 };
            numbers.Sort(); // int уже вміє порівнюватися
            Console.WriteLine(string.Join(", ", numbers)); // 1, 4, 5

            List<Student> group = new List<Student>
            {
                new Student("Тарас", 4.2),
                new Student("Олена", 4.9),
                new Student("Андрій", 3.8)
            };

            group.Sort(); // Використовує IComparable<Student>.CompareTo - за балом
            Console.WriteLine("За балом:   " + string.Join(", ", group));

            group.Sort(new StudentByNameComparer());
            Console.WriteLine("За ім'ям:   " + string.Join(", ", group));

            group.Sort(new StudentByGradeDescendingComparer());
            Console.WriteLine("Рейтинг:    " + string.Join(", ", group));

            // Колекція, що сама тримає елементи відсортованими (за IComparable<Student>)
            SortedSet<Student> sorted = new SortedSet<Student>(group);
            Console.WriteLine($"Найнижчий бал: {sorted.Min}, найвищий: {sorted.Max}");
        }
    }
}
