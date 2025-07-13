// LINQ (Language Integrated Query)
// Allows to Easily Queries to your Data Collections

using System.Linq;
class Progrm
{

    public class Player
    {
        public string playerName;
        public string team;

        public override string ToString()
        {
            return playerName + " " + team;
        }
    }
    public static void Main(string[] args)
    {

        List<Player> players = new List<Player>
        {
            new Player {playerName="Arham", team= "Red"},
            new Player{playerName="Akhzer", team="Blue"},
            new Player{playerName="Bilal", team="Red"},
            new Player{playerName="Shayan", team="Blue"}
        };

        // LINQ
        // To Fetch players which are in Red Team
        List<Player> redPlayers = players.Where(player => player.team == "Red").ToList();
        foreach (Player p in redPlayers)
        {
            Console.WriteLine(p);
        }

        // OR
        IEnumerable<Player> redPLayersIEnumberable =
            from player in players
            where player.team == "Red"
            select player;

        foreach (Player pl in redPLayersIEnumberable)
        {
            Console.WriteLine(pl);
        }
    }
}