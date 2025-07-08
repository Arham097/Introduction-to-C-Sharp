class Program
{
    public static void Main(string[] args)
    {
        // Without Exception Handling It throws error and program crashed
        // int a = 0;
        // int b = 1 / a;
        // Console.WriteLine(b);

        // Exception Handling

        try
        {
            int a = 0;
            int b = 1 / a;
            Console.WriteLine(b);
        }
        catch (DivideByZeroException) // We can define Multiple Exceptions
        {
            Console.WriteLine("Divide by Zero");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message + " " + exception.StackTrace);
        }
        // This block always wither either try fails or catch does not run
        finally
        {
            Console.WriteLine("Finally");
        }

        // We can make Custom Exceptions

        // SO you can make and throw custom exceptions alse
        Player p1 = new Player();
        p1.myFunc();

    }
    public class Player
    {
        public class InvalidPlayerNameException : Exception
        {

        }
        public void myFunc()
        {
            throw new InvalidPlayerNameException();
        }
    };

}