// See https://aka.ms/new-console-template for more information

// 1. While Loop

int i = 3;

while (i > 0)
{
    Console.WriteLine("Hello " + i);
    i--;
}

// Do while Loop
int j = 3;
do
{
    Console.WriteLine("Hello " + j);
    j--;
} while (j > 0);


// 3. For Loop
for (int k = 0; k < 3; k++)
{
    Console.WriteLine("Hello " + k);
}

// 4. foreach Loop
string[] names = ["Arham", "Akhzer", "Bilal", "Zegham"];

foreach (string name in names)
{
    Console.WriteLine(name);
}

// 5. Nested Loops

for (int l = 0; l < 5; l++)
{
    for (int m = 0; m < 5; m++)
    {
        Console.WriteLine(l + " , " + m);
    }
}