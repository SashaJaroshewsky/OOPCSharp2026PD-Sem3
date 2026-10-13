
namespace PZ3
{
    internal class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine($"Bird {Name} is chirping.");
        }

        public override void Run()
        {
            Console.WriteLine($"Bird {Name} is running on two legs.");
        }
    }
    
}
    

