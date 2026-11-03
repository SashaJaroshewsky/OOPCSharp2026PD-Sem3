
namespace PZ3
{
    public abstract class Animal: ISoundeable
    {
        private string _name;

        public string Name => _name;

        public Animal(string name)
        {
            _name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"Animal {Name} is making a sound.");
        }

        public abstract void Run();
    }
}
