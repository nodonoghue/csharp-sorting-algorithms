// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

int[] inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };

Console.Write("Starting array");
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();

Console.WriteLine("Bubble Sort");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
int[] ascInAry = inAry;
int[] resultAsc = sorting_algorithms.Bubble.Sort.Ascending(ascInAry);
foreach (int i in resultAsc) Console.Write(i.ToString() + ", ");

Console.WriteLine("");
Console.WriteLine("Descending order:");
int[] descInAry = inAry;
int[] resultDesc = sorting_algorithms.Bubble.Sort.Descending(descInAry);
foreach (int i in resultDesc) Console.Write(i.ToString()+", ");
