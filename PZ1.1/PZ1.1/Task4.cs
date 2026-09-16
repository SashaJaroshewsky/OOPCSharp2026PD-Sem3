

namespace PZ1._1
{
    internal class Task4
    {
        public void Run()
        {
            int a = 1;
            Method1(a);
            Console.WriteLine(a);

            Method2Ref(ref a);
            Console.WriteLine(a);

            Method3Out(out a);
            Console.WriteLine(a);


        }

        private void Method1(int a)
        {
            a += 6;
        }

        private void Method2Ref(ref int a)
        {
            a += 6;
        }

        private void Method3Out(out int a)
        {
            a = 1;
        }

    }
}
