// Asynchronous Programming
// Async Await Task (Run logic without blocking main thread)

using System.Threading.Tasks;

class Program
{
    public static string serverData;

    public static async Task Main(string[] args)
    {

        // await ContactingWebServer();
        // int dataLength = serverData.Length;
        // Console.WriteLine(dataLength);

        // This is in sequential manner and one task end then another start but normally these things can be done side by side
        // await CookEggs();
        // await CookChicken();
        // await MakeToast();

        // Another bettter approach this is much faster than above it starts all the task at once and waiting for all to complete
        Task eggTask = CookEggs();
        Task chickenTask = CookChicken();
        Task toastTask = MakeToast();

        await Task.WhenAll(eggTask, chickenTask, toastTask);
        Console.WriteLine("Breakfast Done");
    }
    public static async Task ContactingWebServer()
    {
        Console.WriteLine("Contacting Server...");
        await Task.Delay(3000);
        serverData = "Data";
        Console.WriteLine("Got Response");
    }

    public static async Task CookEggs()
    {
        Console.WriteLine("Cooking Eggs");
        await Task.Delay(4000);
        Console.WriteLine("Eggs Done");
    }

    public static async Task CookChicken()
    {
        Console.WriteLine("Cooking Chicken");
        await Task.Delay(5000);
        Console.WriteLine("Chicken Done");
    }

    public static async Task MakeToast()
    {
        Console.WriteLine("Making Toast");
        await Task.Delay(3000);
        Console.WriteLine("Toast Done");
    }

}