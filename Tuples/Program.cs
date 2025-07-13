class Program
{
    public static void Main(string[] args)
    {
        var myTuple = ("Arham", 21);
        Console.WriteLine(myTuple);
        Console.WriteLine(myTuple.Item1);
        Console.WriteLine(myTuple.Item2);

        // Also we can define as
        var myTuple2 = (name: "Hasan", age: 22);
        Console.WriteLine(myTuple2);
        Console.WriteLine(myTuple2.name);
        Console.WriteLine(myTuple2.age);
        // Also we can modify like this
        myTuple2.name = "Arham Hasan";
        Console.WriteLine(myTuple2.name);


        // Also we can destruct it
        (string name, int age) = ("Bilal", 20);
        Console.WriteLine(name + " " + age);

        string playerName = "Shayan";
        int health = 70;
        var myTuple3 = (playerName, health);
        myTuple3.health = 75;
        Console.WriteLine(health + " " + myTuple3.health);

        Console.WriteLine(GetPlayerDetails());

    }
    // We can also return mupltiple values from functions/methods through tuple
    public static (string, int) GetPlayerDetails()
    {
        return ("Arham Hasan", 80);
    }
}