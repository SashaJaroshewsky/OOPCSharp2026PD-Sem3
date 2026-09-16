
namespace Pr1
{
    internal class Task4
    {
        public void Run()
        {
            int number = 5;
            Method1(number);
            Console.WriteLine(number);

            Method2Ref(ref number);
            Console.WriteLine(number);

            Method3Out(out number);
            Console.WriteLine(number);
        }

        public void Method1(int number)
        {
            number += 10;
        }

        public void Method2Ref(ref int number)
        {
            number += 10;
        }

        public void Method3Out(out int number)
        {
            number = 0;
        }
    }
}
