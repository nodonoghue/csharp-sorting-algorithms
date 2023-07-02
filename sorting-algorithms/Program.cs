// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, bubble sort algorithm");

int[] inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };

foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();

bool swapped;
int swapValue;
for (int i = 0; i < inAry.Length - 1; i++)
{
    swapped = false;
    //The inner loop iterated over the entire loop, minus the number of tiems the outer loop as run.
    //This is because the highest numbers should bubble to top - i position each time, resulting in
    //The list being ordered smallest to largest.
    for (int j = 0; j < inAry.Length - 1 - i; j++)
    {
        if (inAry[j] > inAry[j+1])
        {
            swapped = true;
            swapValue = inAry[j];
            inAry[j] = inAry[j+1];
            inAry[j+1] = swapValue;
        }
    }
    if (swapped == false) break;

}

foreach (int i in inAry) Console.Write(i.ToString() + ", ");
