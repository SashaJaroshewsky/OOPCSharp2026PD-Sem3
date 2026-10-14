
namespace PZ3
{
    internal abstract class Animal: ISoundeable
    {
        private string _name;

        public string Name => _name;

        public Animal(string name)
        {
            _name = name; 
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{_name} makes a sound.");
        }

        public abstract void Run();

        public void ToGetScared()
        {
            Console.WriteLine($"{_name} is scared!");
            MakeSound();
            Run();
        }
    }
}
