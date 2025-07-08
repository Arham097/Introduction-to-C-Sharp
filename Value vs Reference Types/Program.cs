// See https://aka.ms/new-console-template for more information

// 1. Value Types (Contain their data)
// int, float bool, enum , struct 

// 2. Reference Types (Stores Reference to their data)
// Class, objects, array, string
class Program
{
    private class MyClass
    {
        public int a;
    }

    private struct MyStruct
    {
        public int a;
    }
    public static void Main(string[] args)
    {

        MyClass obj1 = new MyClass();
        obj1.a = 5;
        MyClass obj2 = obj1;
        obj2.a = 7;

        // Answer will be 7 because when assign obj1 to obj2 so they point to same reference of a in memory
        // When Change in (a) of obj2 it also change (a) of obj 1
        Console.WriteLine(obj1.a);

        // Whereas for value types
        int a = 5;
        int b = a;
        b = 7;
        // Answer will be 5 because only value of a copied in b not its reference so by change in (b) it does not effect a 
        Console.WriteLine(a);

        MyStruct obj3 = new MyStruct();
        obj3.a = 5;
        MyStruct obj4 = obj3;
        obj4.a = 7;

        // Answer will be 5 because when assign obj3 to obj4 so they did not point to same reference of (a) in memory, only value copy to (obj4's a)
        // When Change in (a) of obj4 it does not change (a) of obj 3
        Console.WriteLine(obj3.a);
    }
}


