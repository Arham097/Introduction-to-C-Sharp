// Generics (Make Your Class to work with Any Type)

class Program
{

    // By Defining class as Generic we can make instance of any type
    class List<T>
    {
        public T field;
        public T MyFunc()
        {
            return default;
        }
    }

    private static void Function<T>(T p)
    {
        Console.WriteLine(p);
    }
    public static void Main(string[] args)
    {

        // Making different instance of different types///////////
        List<int> intList = new List<int>();
        intList.field = 5;
        Console.WriteLine(intList.MyFunc());

        List<bool> boolList = new List<bool>();
        boolList.field = false;
        Console.WriteLine(boolList.MyFunc());

        List<string> stringList = new List<string>();
        stringList.field = "Arham";
        Console.WriteLine(stringList.MyFunc());
        /////////////////////////////////////////////////////////////

        /// In the same a function can accept different Kinds of Parameter

        Function(5); // int
        Function("5"); // string
        Function('c'); // char
        Function(true); // bool


        // we can put some kind of restriction while using Generics

        // It throws error that type  int must be reference type 
        // List2<int> intList2 = new List2<int>();
        // intList2.field = 5;


        // It works as expected
        List2<Player> p1 = new List2<Player>();
        p1.field = new Player();
        Console.WriteLine(p1.MyFunc());


    }
    public class Player
    {

    }
    // It restricr that the T type belongs to class and new() shows that it should have parameter less constructor (default)
    public class List2<T> where T : class, new()
    {
        public T field;

        public T MyFunc()
        {
            new T();
            return null;
        }
    }
}