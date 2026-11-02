namespace FirstModuleTheory
{
    // Upcasting (вгору) — перетворення об'єкта дочірнього класу на тип батьківського класу.
    // Downcasting (вниз) — перетворення об'єкта батьківського класу на тип дочірнього класу.

    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Example
    {
        public void ExampleUpcastingDowncasting()
        {
            // Upcasting — завжди безпечний, бо собака ЗАВЖДИ є твариною.
            Animal animal1 = new Dog(); // Upcasting (неявно)
            Animal animal2 = new Cat(); // Upcasting (неявно)

            // !!!
            // Upcasting і downcasting нічого не змінюють в об'єкті, бо це той самий об'єкт у пам'яті.
            // Змінюється лише тип посилання, тобто через яку «призму» ви на об'єкт дивитесь і які члени вам доступні.
            // !!!

            animal1.Speak(); // Викликається Dog.Speak() "Dog barks" - поліморфізм
            animal2.Speak(); // Викликається Cat.Speak() "Cat meows" - поліморфізм

            // Downcasting — небезпечний, бо не кожна тварина є собакою.
            Dog dog = (Dog)animal1; // Downcasting (явно) В даному випадку ок, бо animal1 насправді є Dog.

            // Dog dog2 = (Dog)animal2; // Downcasting (явно) В даному випадку помилка часу виконання, бо animal2 насправді є Cat.

            // Безпечні способи downcasting:
            if (animal1 is Dog dog2) // Безпечний downcasting з перевіркою типу (перевірка + приведення)
            {
                dog2.Speak();
            }
            
            Dog dog3 = animal1 as Dog; // Безпечний downcasting з використанням ключового слова as (якщо не вдасться привести, то буде null)

            // is і as — це ключові слова, які дозволяють безпечно перевіряти тип об'єкта та виконувати приведення типів без ризику виключення InvalidCastException.
            // is — перевіряє, чи є об'єкт певного типу, і повертає true або false.
            // as — намагається привести об'єкт до певного типу і повертає null, якщо приведення неможливе.


            // Зв'язок із поліморфізмом:
            // саме upcasting дає змогу тримати різні об'єкти в List<Animal> і викликати Speak() поліморфно.
            // Downcasting же часто є ознакою того, що поліморфізм використано не до кінця.
            // Якщо доводиться писати if (a is Dog) ... else if (a is Cat) ..., зазвичай краще винести цю поведінку у віртуальний метод
        }
    }
}
