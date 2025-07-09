// See https://aka.ms/new-console-template for more information

class Player2
{
    public string name = "";

    public Player2(string name)
    {
        this.name = name;
        Console.WriteLine($"Creating Player {name}");
    }

    public void sayHello()
    {
        Console.WriteLine($"Hello {name}");
    }
}


// Static Keyword
// Static refers to the property that belongs to class itself not its instance
class Vehicle
{
    public static string company = "Toyota";

    public Vehicle(string name)
    {
        company = name;
        Console.WriteLine($"Creating car of {company}");
    }
    public void SayHello()
    {
        Console.WriteLine($"Hello from {company}");
    }
}

static class Bikes
{
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello from {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Player2 p1 = new Player("Arham");
        // Player2 p2 = new Player("Akhzer");
        // p1.sayHello();
        // p2.sayHello();

        /* While static as static property shared across instances so both v1 and v2 has same 
        result as v2 updated static property once then it same shared across all the instances*/

        // Vehicle v1 = new Vehicle("Ford");
        // Vehicle v2 = new Vehicle("Audi");
        // v1.SayHello();
        // v2.SayHello();

        // Accessing static class and its property without instantiating
        // Static class members can be used without making intances

        Bikes.SayHello("Unique");



        Player p1 = new Player();
        Unit u1 = new Player();

        p1.Move(); // Move Unit (because it inherits parent move method)
        u1.Move(); // Move Unit


        // instantiating abstract classes cause an error
        // Enemy e1 = new Enemy(); // Cannot create instance of an abstract class

        // Testing Static Constructor

        // Member m1 = new Member();
        Console.WriteLine(Member.i);

    }

    // 2. Inheritance
    // 3. Polymorphism

    public class Player : Unit
    {
        public Player()
        {
            speed = 5;

        }
        public override void Move()
        {
            Console.WriteLine("Move Player");
        }

    }
    public class Unit
    {
        public float speed;

        public virtual void Move()
        {
            Console.WriteLine("Move Unit");
        }
    }

    // 4. Abstract Classes and methods
    // Abstract classes are the classes that cannot instatiated but meant to be inherited by other classes
    // it provides definition how class should be defined
    // in the same way abstract methods only have definition and inherited classes defined its body

    public abstract class Enemy
    {
        public abstract void HealthDown();
    }


    //////////////   Static Constructor ////////////////////
    /// TO RUN SOME INITIALIZATION CODE BEFORE ANYTHING USED IN A CLASS
    /// Whenever object is created or any fields of class is used static constructor runs first

    public class Member
    {
        static Member()
        {
            Console.WriteLine("Static Constructor Called");

            i = 5;
        }
        public static int i;
        public Member()
        {
            Console.WriteLine("Player Constructor");
        }
    }
}


