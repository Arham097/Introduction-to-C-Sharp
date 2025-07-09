// See https://aka.ms/new-console-template for more information

static void sayHello()
{
    Console.WriteLine("Hello");
}

static int AddNumber(int x, int y)
{
    return x + y;
}

static bool isEven(int x)
{
    return x % 2 == 0;
}

sayHello(); // Function calls
Console.WriteLine(AddNumber(5, 3));
Console.WriteLine(isEven(2));


//////////// Recursion///////////////////

static int giveNumber(int number)
{
    if (number < 5)
    {
        return giveNumber(number + 1);
    }
    else
    {
        return number;
    }
}
Console.WriteLine(giveNumber(0));

//////////// FInd out Factorial //////////////////

static int Factorial(int number)
{
    if (number == 0 || number == 1)
    {
        return 1;
    }
    else
    {
        return number * Factorial(number - 1);
    }
}

Console.WriteLine(Factorial(5));

/////////// params Keyword (allows to receive multiple parameters in a function) /////////////


static void printNames(params string[] names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

printNames("Arham", "Shayan", "Bilal");

///////////////// Optional Parameters //////////////////////////
/// Add Defaults to parameters to make them optional (isELgible=true)
/// if the parameter for this is not passed so it takes default value;

static void eligibleForVote(int age, bool isEligible = true)
{
    if (isEligible)
    {
        Console.WriteLine("You are Eligible to vote");
    }
    else
    {
        Console.WriteLine("You are not Eligible to vote");
    }
}

// eligibleForVote(18); // You are eligible to vote (because default its true)
eligibleForVote(17, false);


// Function Extensions (Extend a type with new functions without modifying it)

bool b = false;
Console.WriteLine(b.IsTrue());
public static class TransformExtensions
{
    public static void IsTrue(this bool b)
    {
        return b;
    }
}