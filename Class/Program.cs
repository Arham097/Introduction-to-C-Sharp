// See https://aka.ms/new-console-template for more information

class Player
{
    public string name = "";

    public Player(string name)
    {
        this.name = name;
        Console.WriteLine($"Creating Player {name}");
    }

    public void sayHello()
    {
        Console.WriteLine($"Hello {name}");
    }
}


// Static Keyword
// Static refers to the property that belongs to class itself not its instance
class Vehicle
{
    public static string company = "Toyota";

    public Vehicle(string name)
    {
        company = name;
        Console.WriteLine($"Creating car of {company}");
    }
    public void SayHello()
    {
        Console.WriteLine($"Hello from {company}");
    }
}

static class Bikes
{
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello from {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Player p1 = new Player("Arham");
        // Player p2 = new Player("Akhzer");
        // p1.sayHello();
        // p2.sayHello();

        /* While static as static property shared across instances so both v1 and v2 has same 
        result as v2 updated static property once then it same shared across all the instances*/

        // Vehicle v1 = new Vehicle("Ford");
        // Vehicle v2 = new Vehicle("Audi");
        // v1.SayHello();
        // v2.SayHello();

        // Accessing static class and its property without instantiating
        // Static class members can be used without making intances

        Bikes.SayHello("Unique");

    }
}