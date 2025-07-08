// See https://aka.ms/new-console-template for more information

// Interfaces are C sharp one of the most powerful features that makes code modular
// Interfaces ensures that any class that use interface must implement its methods/functions
// Interfaces not have fields (data/properties) , but only have methods.
// if in interface we defined some behavior of any method/function so it is not necessary to implement by class that use it
// In interfaces we can defined properties
// One class can implements more than one interfaces
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
        public void Damage()
        {
            Console.WriteLine("Player Damaged");
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
        IAttackable attackable = new Player();
        attackable.Damage();
        IAttackable attackable1 = new Enemy();
        attackable1.Damage();
    }
}