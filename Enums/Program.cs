// See https://aka.ms/new-console-template for more information

class Testing
{
    // Example 1
    // In this Particular Example Every integer represent some meaning which you have to memorize what it is all about.
    // To Solve this problem we use Enum to make it more intuitive and understandable
    public int GetNextPlayerAction()
    {
        if (!PlayerHasEnemy())
        {
            return 0; // No Enemy
        }
        if (!HasPathToEnemy())
        {
            return 1; // No Path to Enemy
        }
        if (!PlayerWithinAttackDistance())
        {
            return 2; // Moving Towards Enemy
        }
        else
        {
            return 3; // Attacking Enemy
        }
    }

    // Example 2

    // No Each int value is represented by some PlayerActions which also at backend represented by Integer in which the order it is defined 
    // NoEnemy => 0
    // NoPathToEnemy => 1   

    public enum PlayerActions
    {
        NoEnemy,
        NoPathToEnemy,
        MovingTowardsEnemy,
        AttackingEnemy
    }

    public PlayerActions GetNextPlayerActionV2()
    {
        if (!PlayerHasEnemy())
        {
            return PlayerActions.NoEnemy;
        }
        if (!HasPathToEnemy())
        {
            return PlayerActions.NoPathToEnemy;
        }
        if (!PlayerWithinAttackDistance())
        {
            return PlayerActions.MovingTowardsEnemy;
        }
        else
        {
            return PlayerActions.AttackingEnemy;
        }
    }

    public void CheckNumBehindEnums()
    {
        Console.WriteLine(PlayerActions.NoEnemy + " => " + (int)PlayerActions.NoEnemy);
        Console.WriteLine(PlayerActions.NoPathToEnemy + " => " + (int)PlayerActions.NoPathToEnemy);
        Console.WriteLine(PlayerActions.MovingTowardsEnemy + " => " + (int)PlayerActions.MovingTowardsEnemy);
        Console.WriteLine(PlayerActions.AttackingEnemy + " => " + (int)PlayerActions.AttackingEnemy);
    }


    public bool PlayerHasEnemy()
    {
        return true;
    }
    public bool HasPathToEnemy()
    {
        return true;
    }

    public bool PlayerWithinAttackDistance()
    {
        return true;
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Example 1
        Testing t1 = new Testing();
        Console.WriteLine(t1.GetNextPlayerAction());

        // Example 2
        Testing t2 = new Testing();
        Console.WriteLine(t1.GetNextPlayerActionV2());
        t2.CheckNumBehindEnums();
    }
}

