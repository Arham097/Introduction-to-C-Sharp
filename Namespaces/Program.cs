// Namespaces (Organize your code into code folders)
// We can write whole code into sub folder or in namespaces and can reference it later for help


// We can also use Alias for bettet understanding
using GamePlayer = Game.Player;

class Program
{
    public static void Main(string[] args)
    {
        Player p1 = new Player();

        // Game.Player p2 = new Game.Player();

        // Using alias
        GamePlayer p2 = new GamePlayer();
    }
    class Player
    {

    }

}

// A common issue is that we can made two Player classes with same in a class so we can shift it into different namespace
namespace Game
{
    class Player
    {

    }
}

