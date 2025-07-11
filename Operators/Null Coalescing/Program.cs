// Null Coalescing (??) (Checks if left side null so take the right side of it)
class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player();
        Console.WriteLine(player.GetName() ?? "Arham");

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