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

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

            Console.WriteLine("============================");

            Animal[] animals = new Animal[] { dog, cat, bird };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
                animal.MakeSound();
                animal.Run();
            }

            Dog dog1 = (Dog)animals[0];
            dog1.Bark();
        }
    }
}
