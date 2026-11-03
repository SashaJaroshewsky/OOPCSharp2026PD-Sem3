namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");
            dog.Run();
            dog.Bark();

            Cat cat = new Cat("Whiskers");
            cat.Run();


            Bird bird = new Bird("Tweety");
            bird.Run();

            ToyDuck toyDuck = new ToyDuck();

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

            Console.WriteLine("============================");

            Animal[] animals = new Animal[] { dog, cat, bird };

            ISoundeable[] soundeables = { dog, cat, bird, toyDuck };

            Animal an = new Dog("Max");

            float b = 1.5f;
            int a = (int)(b);


            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
                animal.MakeSound();
                animal.Run();
            }

            foreach (ISoundeable soundeable in soundeables)
            {
                soundeable.MakeSound();
            }

            Cat cat1 = (Cat)animals[1];
            cat1.Purr();

            Dog dog1 = (Dog)animals[0];
            dog1.Bark();


            Console.WriteLine("=================");

            Dog dog2 = new Dog("Rex");
            dog2.Bark();
            dog2.MakeSound();

            Animal animal2 = dog2;
            animal2.MakeSound(); // Calls the overridden method in Dog class

        }
    }
}
