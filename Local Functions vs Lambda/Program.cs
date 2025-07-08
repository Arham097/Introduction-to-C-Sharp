// Local Functions can used before it is declared whereas Lambdas cannot be used before declared
// Local Functions defined at Compile time whereas lambda defined as Runtime
/* Lambdas are the actual objects exists in memory so every time main function runs (i.e 100 times) so it 
   creates 100 instance of it whereas Local function defined at compile time so 100 time main 
   function runs only one instance is created for local functions*/

class Program
{

    public static void Main(string[] args)
    {

        // Run Correctly without error
        Print("Example");
        /////////////////////////////

        // Throw Error (Cannot use local variables before declared)
        myAction();
        /////////////////////////////////////////////


        ///////// Example 1 (Lambda) ////////////////
        Action<string> myAction = (string message) =>
        {
            Console.WriteLine(message);
        };
        ///////////////////////////////////

        ///////////Example 2 (Local Function) /////////////////////
        void Print(string message)
        {
            Console.WriteLine(message);
        }
        Action<string> myAction2 = Print;
        //////////////////////////////////
        /// These above both example have same behaviour

    }
}