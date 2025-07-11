// Nullble (Types that can handle/store null values)
class Program
{
    public static void Main(string[] args)
    {
        // Throw error (Cannot convert null to int)
        // int i = null;
        // Console.WriteLine(i);
        // To make it nullable add ? after type
        int? i = null;
        Console.WriteLine(i);
        bool? b = null;
        Console.WriteLine(b);

        // THis does not throw error because class on default value is null;
        Player player = null;

        // or we can make it through Nullable
        Nullable<int> j = null;
        if (!j.HasValue) // Check if it is null or not
        {
            j = 10;
        }
        Console.WriteLine(j);
    }

    class Player
    {

    }
}