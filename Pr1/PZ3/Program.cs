using PZ3.Task2;

namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Coockie coockie = new Coockie();

            //Animal animal = new Animal("Max");
            //Console.WriteLine(animal.Name);
            
            //animal.MakeSound();

            //Console.WriteLine("==================");

            Dog dog = new Dog("Buddy");
            Cat cat = new Cat("Whiskers");
            Ostrich ostrich = new Ostrich("Flightless");
            ToyDuck toyDuck = new ToyDuck();

            Animal[] animals = new Animal[] { dog, cat, ostrich };

           // int[] ints = new int[] { (int)1.5f, (int)2.6f};

            foreach (Animal animal in animals)
            {
                animal.ToGetScared();
            }

            ISoundeable[] soundeables = new ISoundeable[] { dog, cat, ostrich, toyDuck };

            foreach (ISoundeable soundeable in soundeables)
            {
                soundeable.MakeSound();
            }

            //Cat cat2 = (Cat)animals[1];
            //cat2.MakeSound();

            Console.WriteLine("==========================");

            Door door = new Door();
            Bulb bulb = new Bulb();

            Switch switcher = new Switch(toyDuck);

            switcher.Toggle();
            switcher.Toggle();
        }
    }
}
