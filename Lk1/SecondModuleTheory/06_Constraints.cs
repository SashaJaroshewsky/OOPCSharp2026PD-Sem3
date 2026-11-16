using System;

namespace SecondModuleTheory.Constraints
{
    // ТЕРМІН:
    // Обмеження параметра типу (type parameter constraint) - вимога до аргументу типу,
    // записана після ключового слова where. Компілятор не дозволить підставити тип, що їй не відповідає.

    // АНАЛОГІЯ:
    // Оголошення про вакансію: "Шукаємо водія. Вимога: права категорії B".
    // Роботодавець не знає заздалегідь, хто саме прийде, але знає, що ця людина ВМІЄ кермувати,
    // тож може доручити їй поїздку.
    // Так і з обмеженням: якщо T : IComparable<T>, ми не знаємо конкретний тип,
    // але знаємо, що в нього точно є метод CompareTo.

    // ПОЯСНЕННЯ:
    // Без обмежень компілятор дозволяє робити зі значенням типу T лише те, що вміє будь-який object
    // (ToString, Equals, GetHashCode). Порівняти два T через > або викликати їхній метод не можна.
    // Обмеження розширюють можливості всередині методу і звужують коло допустимих типів.
    //
    // Основні види обмежень:
    //   where T : struct           - T має бути значимим типом (int, double, struct ...)
    //   where T : class            - T має бути посилальним типом (класи, string, масиви ...)
    //   where T : new()            - T має мати публічний конструктор без параметрів (можна писати new T())
    //   where T : НазваКласу       - T має бути цим класом або його нащадком
    //   where T : НазваІнтерфейсу  - T має реалізовувати цей інтерфейс
    //   where T : notnull          - T не може бути типом, що допускає null
    //
    // Обмеження можна комбінувати через кому. Порядок: спочатку class/struct, потім базовий клас та інтерфейси, new() - останнім:
    //   where T : Animal, IComparable<T>, new()
    // Для кількох параметрів кожен має свій where:
    //   class Registry<TKey, TValue> where TKey : notnull where TValue : class

    // ПРИКЛАД 1: обмеження інтерфейсом.
    // IComparable<T> - вбудований інтерфейс .NET з методом CompareTo, що порівнює два об'єкти:
    // результат < 0 - менше, 0 - рівні, > 0 - більше. Його реалізують int, double, string, DateTime тощо.
    public static class MathHelper
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
           // return a > b ? a : b;            // Помилка: оператор > не визначений для довільного T
            return a.CompareTo(b) >= 0 ? a : b; // А CompareTo гарантовано є завдяки обмеженню
        }
    }

    // ПРИКЛАД 2: обмеження базовим класом.
    public abstract class Animal
    {
        public string Name { get; }
        protected Animal(string name) { Name = name; }
        public abstract string MakeSound();
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override string MakeSound() => "Гав!";
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override string MakeSound() => "Мяу!";
    }

    // Притулок приймає лише тварин. Shelter<Dog> - лише собак, Shelter<Animal> - будь-яких тварин.
    public class Shelter<T> where T : Animal
    {
        public void Admit(T animal)
        {
            // Можемо звертатися до Name і MakeSound(), бо T - це Animal або його нащадок
            Console.WriteLine($"До притулку прийнято: {animal.Name}. Каже: {animal.MakeSound()}");
        }
    }

    // ПРИКЛАД 3: обмеження new().
    public class Product
    {
        public string Title { get; set; } = "Без назви";
    }

    public static class Factory
    {
        public static T Create<T>() where T : new()
        {
            return new T(); // Без обмеження new() компілятор не дозволить так написати
        }
    }

    internal static class Demo
    {
        public static void Run()
        {


            Console.WriteLine(MathHelper.Max(3, 7));                // 7
            Console.WriteLine(MathHelper.Max("груша", "яблуко"));   // яблуко (за алфавітом)
            // MathHelper.Max(new Dog("Рекс"), new Dog("Бім"));    // Помилка: Dog не реалізує IComparable<Dog>

            Shelter<Dog> dogShelter = new Shelter<Dog>();
            dogShelter.Admit(new Dog("Рекс"));
            // dogShelter.Admit(new Cat("Мурка")); // Помилка: очікується Dog
            // Shelter<string> wrong;              // Помилка: string не є нащадком Animal

            Shelter<Animal> anyShelter = new Shelter<Animal>();
            anyShelter.Admit(new Cat("Мурка"));    // Поліморфізм: Cat - це Animal

            Product product = Factory.Create<Product>(); // Тип вказуємо явно: аргументів немає, виводити нема з чого
            Console.WriteLine(product.Title);            // Без назви
            // Factory.Create<Dog>(); // Помилка: у Dog немає конструктора без параметрів
        }
    }
}
