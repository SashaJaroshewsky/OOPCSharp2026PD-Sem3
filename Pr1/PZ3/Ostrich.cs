
namespace PZ3
{
    internal class Ostrich : Animal
    {
        public Ostrich(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a booming sound.");
        }
        public override void Run()
        {
            Console.WriteLine($"{Name} runs swiftly on two legs.");
        }
    }
}
