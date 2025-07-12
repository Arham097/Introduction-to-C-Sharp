// Boxing is the process of wrapping a value type inside an object, so it can be treated like a reference type.
class Program
{
    public static void Main(string[] args)
    {
        int i = 45;
        object o = i;
        Console.WriteLine(o);

        // and can recast to original type
        i = (int)o;
        Console.WriteLine(i);

        // but cannot recast to some different type it throws error (Cannot implicitly convert type 'bool' to 'int')
        // i = (bool)o;
        // Console.WriteLine(i);

        // Everything in C# inherits (directly or indirectly) from object
        /* So we can make of list of different types if list datatype is object because all the 
        thing originally object otherwise List of different types is not possible in case of int, bool */

        List<object> objList = new List<object>
        {
            10, // int
            "Arham", // string
            false, // bool 
            'a' // char
        };

        foreach (object obj in objList)
        {
            Console.WriteLine(obj);
        }

    }
}