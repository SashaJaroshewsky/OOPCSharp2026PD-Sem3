
namespace PZ4
{
    abstract class Animal: ISoundeable
    {
        private string _name;

        public string Name => _name;

        public Animal(string name)
        {
            _name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        public abstract void Run();

        public void ToGetScared()
        {
            Console.WriteLine($"{Name} is scared and runs away!");
            MakeSound();
            Run();
        }
    }
}
