/*

| Feature        | `const`                                | `readonly`                                           |
| -------------- | -------------------------------------- | ---------------------------------------------------- |
| Value Set      | At **compile-time**                    | At **run-time** (in constructor)                     |
| Modifier Type  | **Implicitly static**                  | Instance-level (can also be static)                  |
| Change Allowed | ❌ Cannot change after declaration      | ✅ Can be set once in constructor                     |
| Initialization | Must be initialized at **declaration** | Can be initialized in **declaration or constructor** |
| Use Case       | Fixed values like PI, gravity          | Configuration values loaded at runtime  
*/

class Program
{
    // Constant
    public const double PI = 3.124;
    public static void Main(string[] args)
    {
        Player player = new Player(25);
        Console.WriteLine(player.getMaxHealth());
    }
    public class Player
    {
        // Readonly
        public readonly int maxHealth;
        public Player(int maxHealth)
        {
            this.maxHealth = maxHealth;
        }

        public int getMaxHealth()
        {
            return maxHealth;
        }

    }

}