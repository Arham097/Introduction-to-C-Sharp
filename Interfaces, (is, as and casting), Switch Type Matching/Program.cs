// See https://aka.ms/new-console-template for more information

// Interfaces are C sharp one of the most powerful features that makes code modular
// Interfaces ensures that any class that use interface must implement its methods/functions
// Interfaces not have fields (data/properties) , but only have methods.
// if in interface we defined some behavior of any method/function so it is not necessary to implement by class that use it
// In interfaces we can defined properties
// One class can implements more than one interfaces

// Another Topic that we can cover in this is (is, as) Keywords and (Casting)
// It is used to convert between types

class Program
{

    // Interface 1
    public interface IAttackable
    {
        public void Damage();
        // Like as we defined some behaviour of HealthDown so it does not throw error of classes that use shoulb be implemented HealthDown
        public int HealthDown()
        {
            return 200;
        }

        // So we can defined properties  in Interface (like Health)
        // public int Health { get; set; }
    }

    //  Interface 2
    public interface IInvetory
    {

    }

    public class Player : IAttackable, IInvetory
    {
        public int health;
        public void Damage()
        {
            Console.WriteLine("Player Damaged");
        }
        // This function is added to understands (is, as and casting)
        public void PlayerSayHello()
        {
            Console.WriteLine("Player said Hello");
        }
    }
    public class Enemy : IAttackable
    {
        public void Damage()
        {
            Console.WriteLine("Enmey Damaged");
        }
    }
    public static void Main(string[] args)
    {
        // IAttackable attackable = new Player();
        // attackable.Damage();

        IAttackable attackable1 = new Enemy();
        attackable1.Damage();

        /* As (PlayerSayHello) function is added in Player class but it is not accessible through 
         attackable object because it takes IAttackable as reference type for Player and IAttackable 
         Interface does not have this method So how to called this (PlayerSayHello) then, solution is as follows */
        IAttackable attackable = new Player();
        attackable.Damage();
        if (attackable is Player) // (Checks attackable is the instance of Player, In this scenario it returns true)
        {
            Console.WriteLine("Yes Attackable is Player");

            // But we still not able called Player methods, for that we have to convert into Player Type
            // Player player = attackable as Player; // (as convert attackable into Player then we can call Player methods)

            // Or we can done through Casting 
            Player player = (Player)attackable;

            player.PlayerSayHello();
        }

        // Switch Type Matching 
        // When particular Instance matches so it cast (convert) it into its respective type
        // It is much easier version of (is,as casting)
        // we can also use conditions

        IAttackable attackable2 = new Player();
        IAttackable attackable3 = new Enemy();

        switch (attackable2)
        {
            case Player player when player.health > 50:
                player.PlayerSayHello();
                break;
            case Enemy enemy:
                Console.WriteLine("Is Enemy");
                break;
            default:
                break;
        }

    }
}