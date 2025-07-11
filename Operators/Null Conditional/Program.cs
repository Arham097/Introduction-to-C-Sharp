// Null Conditional (?) (if Left side not null so it call it right side, if left side null so right side also become null)
class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player();
        player?.SetName("Arham");
        Console.WriteLine(player?.GetName());

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