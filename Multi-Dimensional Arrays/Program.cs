// See https://aka.ms/new-console-template for more information

class Program
{

    public static void Main(string[] args)
    {
        // Multi dimentional arrays

        // int[,] arr = new int[5, 6];

        // OR
        // Initialize with some values

        // int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        // for (int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         Console.WriteLine(i + " " + j + " : " + arr[i, j]);
        //     }
        // }


        // Array of Arrays 
        int[][] arr2 = new int[5][];
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = new int[5];
        }

        arr2[0][2] = 2;
        arr2[1][3] = 3;

        // Q. Find out the sum of all elements in Array of Arrays
        int sum = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr2[i].Length; j++)
            {
                Console.WriteLine(i + " " + j + " : " + arr2[i][j]);
                sum += arr2[i][j];
            }
        }
        Console.WriteLine("Sum = " + sum);



        // Jagged Array (Array of Arrays in which in which each array of possibly different sizes)

        // int[][] arr3 = new int[5][];

        // arr3[0] = new int[3];
        // arr3[1] = new int[4];
        // arr3[2] = new int[5];


    }
}