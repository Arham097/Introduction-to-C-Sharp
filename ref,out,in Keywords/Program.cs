// (ref, out, in) keywords used in function parameters to pass normal variable as a reference
class Program
{
    public enum State
    {
        Idle,
        Attacking,
        Patrolling
    }

    public enum Names
    {
        Arham, Bilal, Shayan
    }


    public static void Main(string[] args)
    {
        // ( out ) keyword used for returning multiple values from function (out => output variable)
        // As is below example Function return state and has output variable of healthamount
        // as we passed (out healthamount) so it means healthamount passed as reference
        // and change in function also change in original health amount 
        Unit unit = new Unit();
        int healthAmount;
        State state = unit.GetUnitState1(out healthAmount);
        Console.WriteLine(state + " " + healthAmount);

        // ref keyword is also work same as out keyword
        /* the main difference is that in (out) you must have to set value of it before ending execution of 
        function otherwise it throws error and no need to initialize it before passing as argument to function,
        while in (ref) you must have to initialize it and then passing it as argument, if this value not set in function
        so it not throw error
         */

        // It throws error because state2 pass as argument before initializing 
        // State state2;
        // unit.GetUnitState2(ref state2, out int healthamount);
        // Console.WriteLine(state2 + " " + healthAmount);


        // Now it works fine
        State state2 = State.Attacking;
        unit.GetUnitState2(ref state2, out int healthamount);
        Console.WriteLine(state2 + " " + healthAmount);

        // (in) Keyword passes by reference but is READ-ONLY
        string name = "Arham";
        Console.WriteLine($"Before SetNames: {name}");
        unit.SetNames(in name); // 'in' - can only read, cannot modify
        Console.WriteLine($"After SetNames: {name}"); // Unchanged because 'in' is read-only

        // Comparing with ref keyword
        Console.WriteLine("\n=== Comparing 'ref' vs 'in' ===");
        string name2 = "Bilal";
        Console.WriteLine($"Before ModifyWithRef: {name2}");
        unit.ModifyWithRef(ref name2); // 'ref' - can modify
        Console.WriteLine($"After ModifyWithRef: {name2}"); // Changed!

        // Demonstrating 'in' performance benefits with large data
        Console.WriteLine("\n=== 'in' Performance Benefits ===");
        Unit.LargeData largeData = new Unit.LargeData(1000);
        unit.ProcessLargeData(in largeData); // No copying of 1000 integers!



    }

    public class Unit
    {

        public State GetUnitState1(out int healthAmount)
        {
            healthAmount = 56;
            return State.Idle;
        }
        public State GetUnitState2(ref State state, out int healthAmount)
        {
            state = State.Patrolling; // Set value of ref but if not set it does not throw error
            healthAmount = 56;
            return State.Idle;
        }

        public void SetNames(in string name)
        {
            // ❌ This will cause a compilation error!
            // name = name + " Hasan"; // Cannot assign to 'in' parameter

            // ✅ You can only READ from 'in' parameters
            Console.WriteLine($"Received name: {name}");
            Console.WriteLine("Note: 'in' parameters are READ-ONLY!");
        }

        // Demonstration of ref vs in
        public void ModifyWithRef(ref string name)
        {
            name = name + " Malik"; // ✅ This works - ref allows modification
        }

        // Demonstration with a large struct to show 'in' performance benefits
        public struct LargeData
        {
            public int[] numbers;
            public LargeData(int size)
            {
                numbers = new int[size];
                for (int i = 0; i < size; i++)
                    numbers[i] = i;
            }
        }

        public void ProcessLargeData(in LargeData data)
        {
            // 'in' prevents copying this large struct
            Console.WriteLine($"Processing {data.numbers.Length} numbers without copying");
            // data.numbers = new int[10]; // ❌ Cannot modify 'in' parameter
        }
    }


}