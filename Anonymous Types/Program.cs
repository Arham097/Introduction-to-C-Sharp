
class Program
{
    public static void Main(string[] args)
    {
        var anynomous = new { Name = "Arham", Age = 20 };
        Console.WriteLine(anynomous);
        Console.WriteLine(anynomous.Name);
        Console.WriteLine(anynomous.Age);

        // but we cannot modify it
        // anynomous.Name = "Arham Hasan"; // It throws error

        // But we can done through (non-destructive mutation)
        var player = anynomous with { Name = "Arham Hasan" };
        Console.WriteLine(player);

        // Also make array of anonymous types

        var anArray = new[] {
            new {Name="Arham", Age=20},
            new {Name="Bilal", Age=23},
            new {Name="Shayan",Age=16}
        };

        // But each array value should be fully same with other one(means properties in same order, or in same number)
        // var anArray2 = new[] {
        //     new {Name="Arham", Age=20},
        //     new {Name="Bilal", Age=23},
        //     new {Age=16,Name="Shayan"}, // This throws error not in same order
        //     new {Name="Muneer", Age=15, Education="Matric"} // This also throw error because additional property
        // };


    }
}