using PZ4.Task2;
using PZ4.Task3;

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

                if(soundeable is Animal animal)
                {
                    animal.Run();
                }
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

            Console.WriteLine("==============");

            Dog dog2 = new Dog("Max");
            dog2.MakeSound();

            Animal animal1 = dog2; // Поліморфізм: Dog є підкласом Animal // Upcasting
            animal1.MakeSound(); // Викликає метод MakeSound() з класу Dog

            Dog dog7 = (Dog)animal1; // Downcasting



            if (animal1 is Dog)
            {
                Dog dog3 = (Dog)animal1;
                dog3.MakeSound(); // Викликає метод MakeSound() з класу Dog
            }

            if(animal1 is Dog dog4)
            {
                dog4.MakeSound();
            }

            Dog dog5 = animal1 as Dog;

            if (dog5 != null)
            {
                dog5.MakeSound();
            }


            //Task3.Dog dog6 = (Dog)new Task3.Animal(); 
            //Animal animal2 = new Dog("Charlie");

            //Task3.Animal animal2 = new Task3.Dog();

            //Task3.Dog dog6 = (Task3.Dog)animal2;
        }
    }
}
