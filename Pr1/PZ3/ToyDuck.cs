
using PZ3.Task2;

namespace PZ3
{
    internal class ToyDuck: ISoundeable, ISwitcheable
    {
        public void MakeSound()
        {
            Console.WriteLine("Toy duck squeaks.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Toy duck is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Toy duck is turned on.");
        }
    }
}
