namespace Lk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Hero", 100, 20);
            Player player2 = new Player("Hero2", 80, 15);

            player.Attack(player2);
            player2.Attack(player);

            player.Attack(player);

            Team team = new Team();
            team.AddPlayer(player);
            team.AddPlayer(player2);


            new Teacher().Teach(player); 

        }
    }
}
