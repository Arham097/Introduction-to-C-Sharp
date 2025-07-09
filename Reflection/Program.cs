// Reflection (Dynamically inspect and execute your code)
// Reflection is used to get information about assemblies, classes, methods, and properties at runtime, and even invoke them dynamically.

using System;
using System.Reflection;
class Program
{
    class Player
    {
        public string Name { get; set; }
        public string Health;

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
    public static void Main(string[] args)
    {
        Player p1 = new Player();
        p1.Name = "Arham";
        p1.SayHello();

        // Get Type Information using reflection
        Type type = p1.GetType();
        Console.WriteLine("Class Type: " + type);

        // List all properties using reflection
        foreach (PropertyInfo prop in typeof(Player).GetProperties())
        {
            Console.WriteLine(prop);
        }

        // List all Methods 
        Console.WriteLine("Methods: \n");
        foreach (MethodInfo metInfo in typeof(Player).GetMethods())
        {
            Console.WriteLine(metInfo);
        }
    }

}