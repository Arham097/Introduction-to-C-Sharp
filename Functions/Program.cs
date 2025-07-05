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