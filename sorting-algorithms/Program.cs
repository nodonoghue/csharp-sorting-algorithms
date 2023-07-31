// See https://aka.ms/new-console-template for more information
using sorting_algorithms.BL;
using System.Runtime.ExceptionServices;

Console.WriteLine("Sorting Algorithms");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
Console.Write("Enter length of array: ");
string? aryLengthInput = Console.ReadLine();
while (!Validation.isNumeric(aryLengthInput))
{
    Console.Write("Array length must be numeric: ");
    aryLengthInput = Console.ReadLine();
}

Console.WriteLine($"Array length is {aryLengthInput}");

int[] inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };

Console.Write("Starting array: ");
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Bubble Sort");
sorting_algorithms.BL.Algorithms.Bubble.Sort bubbleSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
bubbleSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine("Descending order:");
bubbleSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString()+", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Selection Sort");
sorting_algorithms.BL.Algorithms.Selection.Sort selectionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
selectionSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine("Descending Order:");
selectionSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Insertion Sort");
sorting_algorithms.BL.Algorithms.Insertion.Sort insertionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
insertionSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine("Descending Order:");
insertionSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Merge Sort");
sorting_algorithms.BL.Algorithms.Merge.Sort mergeSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
mergeSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine("Descending Order:");
mergeSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Quick Sort");
sorting_algorithms.BL.Algorithms.Quick.Sort quickSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
quickSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine("Descending Order:");
quickSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
inAry = new int[10] { 9, 3, 6, 4, 8, 12, 54, 23, 1, 5 };
Console.WriteLine();
Console.WriteLine();