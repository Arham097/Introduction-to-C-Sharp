// Records (Simpler way to group data into type)
// Records are immutable cannot be changed after initialization
class Program
{
    public record Person(string FirstName, string LastName);

    public record Unit(string Speed);

    // Can inherit ther Records
    public record Player(string PlayerFirst, string PlayerLast) : Unit(Speed);

    public static void Main(string[] args)
    {
        Person p1 = new("Arham", "Hasan");
        p1.FirstName = "AKhzer"; // throws error due to reinitialization
        Console.WriteLine(p1);
    }


}