namespace C_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Giorgi", 85, true));
            players.Add(new Player("Nika", 40, false));
            players.Add(new Player("Luka", 95, true));
            players.Add(new Player("Ana", 60, true));
            players.Add(new Player("Mariam", 72, false));
            players.Add(new Player("Dato", 30, true));
            players.Add(new Player("Tamar", 88, true));
            players.Add(new Player("Sandro", 55, false));
            players.Add(new Player("Nino", 91, false));
            players.Add(new Player("Irakli", 47, true));







            Console.WriteLine("დალაგებული მოთამაშეები:");

            var sortedPlayers = players.OrderByDescending(p => p.Score).ToList();

            foreach (var p in sortedPlayers)
            {
                Console.WriteLine(p.Name + " - " + p.Score + " - " + p.IsActive);
            }



            Console.WriteLine();
            Console.WriteLine("აქტიური მოთამაშეები:");

            var activePlayers = players.Where(p => p.IsActive == true).ToList();

            foreach (var p in activePlayers)
            {
                Console.WriteLine(p.Name + " - " + p.Score);
            }



            Console.WriteLine();
            Console.WriteLine("მაქსიმალური ქულის მქონე მოთამაშე:");

            var maxPlayer = players.OrderByDescending(p => p.Score).First();

            Console.WriteLine(maxPlayer.Name + " - " + maxPlayer.Score);






            Console.WriteLine();
            Console.WriteLine("მინიმალური ქულის მქონე აქტიური მოთამაშე:");

            var minActivePlayer = players.Where(p => p.IsActive == true).OrderBy(p => p.Score).First();

            Console.WriteLine(minActivePlayer.Name + " - " + minActivePlayer.Score);






        }
    }
}
