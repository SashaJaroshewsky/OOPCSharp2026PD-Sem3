

namespace PZ3
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
           
        }

        public new void MakeSound()
        {
            Console.WriteLine($"Cat {Name} is meowing.");
        }

        public override void Run()
        {
            Console.WriteLine($"Cat {Name} is running on four legs.");
        }

        public void Purr()
        {
            Console.WriteLine($"Cat {Name} is purring.");
        }
    }
}
