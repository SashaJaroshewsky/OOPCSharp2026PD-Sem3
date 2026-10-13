using PZ4.Task2;

namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cookies cookies = new Cookies(5, 10);

           // Animal animal = new Animal("Dog");
            
            Dog dog = new Dog("Buddy");
            dog.MakeSound();
            Cat cat = new Cat("Whiskers");
            cat.MakeSound();
            Kangaroo kangaroo = new Kangaroo("Joey");

            Console.WriteLine("==============");

            //int[] ints = new int[] { (int)1.3f, (int)2.7f };
            Animal[] animals = new Animal[] { dog, cat, kangaroo };

            foreach (Animal animal in animals)
            {
                animal.ToGetScared();
            }

            Dog dog1 = (Dog)animals[0];
            //Animal animal1 = new Animal("Buddy"); // Помилка: неможливо створити екземпляр абстрактного класу

            ISoundeable[] soundeables = new ISoundeable[] { dog, cat, kangaroo, new ToyDuck() };

            foreach (ISoundeable soundeable in soundeables)
            {
                soundeable.MakeSound();
            }

            Console.WriteLine("==========================");

            Door door = new Door();
            Bulb bulb = new Bulb();
            Robot robot = new Robot();

            Switch switchObj = new Switch(door);
            Switch @switchObj2 = new Switch(bulb);
            Switch switchObj3 = new Switch(robot);

            switchObj.Toggle(); // Відкриває двері
            switchObj.Toggle(); // Закриває двері

            @switchObj2.Toggle(); // Вмикає лампу
            @switchObj2.Toggle(); // Вимикає лампу

            switchObj3.Toggle(); // Вмикає робота
            switchObj3.Toggle(); // Вимикає робота



        }
    }
}
