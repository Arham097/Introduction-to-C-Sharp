// See https://aka.ms/new-console-template for more information

// Arrays

int[] numArray = [1, 2, 3];
Console.WriteLine(numArray[0]);
Console.WriteLine(numArray.Length);

// List

List<int> numberList = new List<int> { 1, 2, 3 };
Console.WriteLine(numberList.Count);
numberList.Add(4);
Console.WriteLine(numberList.Count);
numberList.Remove(3);
Console.WriteLine(numberList.Count);
Console.WriteLine(numberList[0] + " " + numberList[1] + " " + numberList[2]);
