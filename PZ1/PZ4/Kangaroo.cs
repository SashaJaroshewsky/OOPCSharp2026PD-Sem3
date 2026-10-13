using System;
using System.Collections.Generic;
using System.Text;

namespace PZ4
{
    internal class Kangaroo : Animal
    {
        public Kangaroo(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a thumping sound.");
        }
        public override void Run()
        {
            Console.WriteLine($"{Name} hops on its hind legs.");
        }

    }
}
