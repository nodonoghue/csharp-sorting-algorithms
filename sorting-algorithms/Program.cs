// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, bubble sort algorithm");

int[] inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };

foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();

int[] result = sorting_algorithms.Bubble.Sort.Ascending(inAry);

foreach (int i in result) Console.Write(i.ToString() + ", ");
