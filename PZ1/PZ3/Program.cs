namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();

            Build build = new Build();

            Build build2 = new Build(21);

            Build build3 = build;

            build.Show();
            build2.Show();

            build.BuildFloor();
            build.Show();
        }
    }
}
