

public class Door
{
    public delegate void DoorOpenHandler();

    public event DoorOpenHandler DoorOpened;

    public void Open()
    {
        Console.WriteLine("Door Open");
        DoorOpened?.Invoke();
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Door myDoor = new Door();
        myDoor.DoorOpened += RingBell;
        myDoor.Open();
    }


    static void RingBell()
    {
        Console.WriteLine("Bell Rang!");
    }

}