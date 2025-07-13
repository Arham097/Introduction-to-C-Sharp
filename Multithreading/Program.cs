// Multithreading (To take advantage of all the cores of the CPU, to make it run fast)
class Program
{

    private static int resourceAmount;
    private static object lockObject = new object(); // to handle race condition
    public static void Main(string[] args)
    {

        // Thread workerThread = new Thread(new ThreadStart(PathFinding));
        // workerThread.Start();
        // Console.WriteLine("Main Thread Working...");
        // workerThread.Join();
        // Console.WriteLine("Main Thread Done...");

        // But There is a problem of race conditions while making thread which causes inconsistencies in result

        Thread[] threadArray = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threadArray[i] = new Thread(AddResources);
        }

        for (int i = 0; i < 10; i++)
        {
            threadArray[i].Start();
        }

        for (int i = 0; i < 10; i++)
        {
            threadArray[i].Join();
        }
        // As all the threads try to access the same resource at same time so there is chance of lost to some of resources
        Console.WriteLine("Resource Amount: " + resourceAmount);


        // Deadlock Example
        DeadlockExample(); //Progam will stuck by running this function because both locks are waiting for each other to release it but none of them does

    }

    public static void PathFinding()
    {
        Console.WriteLine("Calculating Path Finding");
        Thread.Sleep(3000);
        Console.WriteLine("Path Finding Done");
    }

    public static void AddResources()
    {
        lock (lockObject) // As the resource become when time of updating so chance to lost to some resources now settled
        {
            for (int i = 0; i < 10000; i++)
            {
                int tmp = resourceAmount;
                tmp++;
                resourceAmount = tmp;
            }
        }
    }

    // Deadlock Example

    public static void DeadlockExample()
    {
        object lock1 = new object();
        object lock2 = new object();

        Thread thread1 = new Thread(() =>
        {
            lock (lock1)
            {
                Thread.Sleep(100);
                lock (lock2)
                {
                    Console.WriteLine("Thread 1 got both locks");
                }
            }
        });

        Thread thread2 = new Thread(() =>
        {
            lock (lock2)
            {
                Thread.Sleep(100);
                lock (lock1)
                {
                    Console.WriteLine("Thread 2 got both locks");
                }
            }
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}

