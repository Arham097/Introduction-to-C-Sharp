// See https://aka.ms/new-console-template for more information

// 1. While Loop

int i = 3;

while (i > 0)
{
    Console.WriteLine("Hello " + i);
    i--;
}

int j = 3;
do
{
    Console.WriteLine("Hello " + j);
    j--;
} while (j > 0);

for (int k = 0; k < 3; k++)
{
    Console.WriteLine("Hello " + k);
}


string[] names = ["Arham", "Akhzer", "Bilal", "Zegham"];

foreach (string name in names)
{
    Console.WriteLine(name);
}