// See https://aka.ms/new-console-template for more information

// Properties are mix of a Variable and Functions

class Practice
{
    // This below expression as refer as property as it has a Variable named of PlayerName with function get and set
    // public static string PlayerName { get; set; }

    // At the behind it acts as follows
    public static string playerName;
    public static string PlayerName
    {
        get
        {
            return playerName;
        }
        set
        {
            // We can set conditions if we wanted
            if (value == "Arham")
            {
                throw new Exception("Cannot set Name Arham");
            }
            playerName = value;
        }
    }
    public static void Main(string[] args)
    {
        // So it normally acts as a variable but it is not.
        PlayerName = "Shayan";
        Console.WriteLine(PlayerName);
    }
}