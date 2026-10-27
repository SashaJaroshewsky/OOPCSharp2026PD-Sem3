
namespace PZ3
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Bark();
        }

        public void Bark()
        {
            Console.WriteLine($"Dog {Name} is barking.");
        }

        public override void Run()
        {
            Console.WriteLine($"Dog {Name} is running on four legs.");
        }
    }
}
