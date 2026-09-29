namespace PZ1._1
{
    internal class Task5
    {
        public int A;
        public DateTime DateTime;

        public Task5() {}

        public Task5(int a, DateTime dateTime)
        {
            A = a;
            DateTime = dateTime;
        }

        public void Run()
        {
            var a = 0;
            Console.WriteLine(a);
            Console.WriteLine(A);
            DateTime = DateTime.Now;

            Console.WriteLine(DateTime);
        }

        public void Method1()
        {
            Console.WriteLine(A);
        }

        public void Method1(int A)
        {
            Console.WriteLine(this.A);
        }
    }
}
