
namespace PZ4
{
    internal class Cat: Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows.");
        }

        public override void Run()
        {
            Console.WriteLine($"{Name} runs on all fours.");
        }
    } 
}
