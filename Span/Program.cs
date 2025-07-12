// Span (Super Efficient way to deal with collections without memory cost)

class Program
{
    public static void Main(string[] args)
    {
        int[] numArray = new int[] { 1, 4, 3, 2, 7, 5, 6, 8 };
        // It does not create new type or takes memory but it points to same memory location of numArray
        Span<int> numSpan = new Span<int>(numArray, 1, 6);
        foreach (int num in numSpan)
        {
            Console.WriteLine(num);
        }
        // It has various function that can implement but as it point to same memory so change in span, also change original array
        numSpan.Sort();
        foreach (int num in numSpan)
        {
            Console.WriteLine(num);
        }

    }
}