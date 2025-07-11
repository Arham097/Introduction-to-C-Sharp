// Ternary Conditional (?) (if Left side true so it call it right side of ? else right side of : )
class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player();
        player?.SetName("Arham");
        Console.WriteLine(player ? player.SetName("Arham") : "Hasan");

    }

    class Player
    {
        private string Name;

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

    }

}