// A Delegate is like a pointer to a function. It allows you to store reference to a method and call it later.
// A Delegate only store the function that would have same definition like it.
// if delegeta return void and accepts string as parameter so it only store function/methods of same definiiton

using System;
class Program
{

    public delegate void AttackDelegate(); // 1. Define Delegate
    public static AttackDelegate attackAction; // 2. Make an Object of it

    // Delegate 2
    public delegate int MyDelegate(string str);

    // In the same way C# provides some default delegates that we can used (we can not have to define delegates explicitly)
    public static Action myAction;

    // It can accept parameter as int and return void
    public static Action<int> myAction2;

    // But Action does not have any return type in default so for return of anything we have to used Func

    public static Func<int, string> myFunc;

    public static void Main(string[] args)
    {
        attackAction = MeeleAttack; // 3. Store function
        attackAction();             // 4. Invoke Store Method

        MyDelegate myDelegate = MyTestFunction;
        Console.WriteLine(myDelegate("arham"));

        myAction = MeeleAttack;
        myAction();

        myAction2 = TestFunction;
        myAction2(5);

        myFunc = TestFunction2;
        Console.WriteLine(myFunc(10));

        // a delegate can store more than one function and on call it can call all of methods function
        attackAction += RangeAttack;
        attackAction();
        // In the same way we can remove references
        attackAction -= RangeAttack;
        attackAction();
    }

    public static void MeeleAttack()
    {
        Console.WriteLine("Meele Attack");
    }

    public static void RangeAttack()
    {
        Console.WriteLine("Range Attack");
    }

    public static int MyTestFunction(string str)
    {
        Console.WriteLine($"Processing: {str}");
        return str.Length; // Return the length of the string
    }

    public static void TestFunction(int num)
    {
        Console.WriteLine(num);
    }

    public static string TestFunction2(int num)
    {
        return $"Num:{num} ";
    }
}
