// Preprocessor directive run before compiling
class Program
{
    public static void Main(string[] args)
    {
        // Means only if environment is testing then print it
#if TESTING
    Console.WriteLine("Testing")
#endif
        // This statement check during compilation time but above not include in compilation 
        bool testing = true;
        if (testing)
        {
            Console.WriteLine("Testing");
        }
    }

    // Like if .net 8.0 version requirement is necessary so it checks before compilation
    // #if !NET8_0
    // #error .NET Version should be above 8
    // #endif

}