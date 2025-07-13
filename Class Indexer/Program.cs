// Class Indexer (Access data from youur custom class as if it as array)

class Program
{
    public static void Main(string[] args)
    {
        PlayerStats player = new PlayerStats();
        player[0] = 45;
        Console.WriteLine(player[0]);

    }
    public class PlayerStats
    {
        public int strAmount;
        public int dexAmount;
        public int wisAmount;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return strAmount;
                    case 1: return dexAmount;
                    case 2: return wisAmount;
                    default: throw new IndexOutOfRangeException();
                }
            }

            set
            {
                switch (index)
                {
                    case 0: strAmount = value; break;
                    case 1: dexAmount = value; break;
                    case 2: wisAmount = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
    }
}