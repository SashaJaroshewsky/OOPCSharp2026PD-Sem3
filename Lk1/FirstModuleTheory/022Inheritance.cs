namespace FirstModuleTheory._022
{
    // Наслідування — це зв'язок типу "є" (is-a),
    // за якого похідний клас переймає поля, властивості та методи базового класу і може розширювати або перевизначати їх.
    // У C# клас може мати лише один базовий клас.
    // У UML позначається суцільною лінією з порожнім трикутником (▷), спрямованим на базовий клас.

    // Собака Є твариною.
    public class Animal
    {
        public string Name { get; }
        public Animal(string name) => Name = name;

        public virtual string Speak() => "...";
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string Speak() => "Гав!";   // перевизначення поведінки
        public void Fetch() => Console.WriteLine($"{Name} приніс палицю");   // розширення
    }
}
