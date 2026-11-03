
namespace PZ4
{
    public class Cat: Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} meows.");
        }

        public override void Run()
        {
            Console.WriteLine($"{Name} runs on all fours.");
        }
    } 
}
