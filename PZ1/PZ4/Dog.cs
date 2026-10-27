
namespace PZ4
{
    internal class Dog: Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} barks.");
        }

        public override void Run()
        {
            Console.WriteLine($"{Name} runs on all fours.");
        }
    }
}
