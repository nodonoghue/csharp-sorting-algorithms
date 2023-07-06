// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

int[] inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };

Console.Write("Starting array: ");
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Bubble Sort");
sorting_algorithms.Bubble.Sort bubbleSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
int[] bubbleResultAsc = bubbleSort.Ascending(inAry);
foreach (int i in bubbleResultAsc) Console.Write(i.ToString() + ", ");

Console.WriteLine();
Console.WriteLine("Descending order:");
int[] bubbleResultDesc = bubbleSort.Descending(inAry);
foreach (int i in bubbleResultDesc) Console.Write(i.ToString()+", ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Selection Sort");
sorting_algorithms.Selection.Sort selectionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
int[] selectionResultAsc = selectionSort.Ascending(inAry);
foreach (int i in selectionResultAsc) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine("Descending Order:");
int[] selectionResultDesc = selectionSort.Descending(inAry);
foreach (int i in selectionResultDesc) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine();
