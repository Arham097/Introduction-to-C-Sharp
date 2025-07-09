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

        // For understanding concept
        private class Unit
        {

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

        // List all NestedTypes
        Console.WriteLine("\nNested Types");
        // As Nested Types is private so it does not show normally so we use Binding FLags for it
        foreach (Type types in typeof(Player).GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Static))
        {
            Console.WriteLine(types);
        }

        // We can also check for anything  that we expect to be implemented on appear in future
        // Like Player class may contian my functions in future
        // Like for implementing an Exercise where user have to implement myFunction while learning Functions so it is help there
        object playerObject = Activator.CreateInstance(Player);
        MethodInfo myFunctionInfo = typeof(Player).GetMethod("MyFunction");
        myFunctionInfo.Invoke(playerObject, new object[] { });
    }

}