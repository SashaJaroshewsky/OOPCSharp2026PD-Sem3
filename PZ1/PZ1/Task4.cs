namespace PZ1
{
    internal class Task4
    {
        public void Run()
        {
            int a = default;
            Method1(a);
            Console.WriteLine(a);

            Method2(ref a);
            Console.WriteLine(a);

            Method3(out int b);
            Console.WriteLine(b);
        }
        
        private void Method1(int a)
        {
            a = 5;
        }

        private void Method2(ref int a)
        {
            a = 6;
        }
        private void Method3(out int a)
        {
            a = 7;
        }
    }
}
