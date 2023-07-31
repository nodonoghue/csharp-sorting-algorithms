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
_ = int.TryParse(aryLengthInput, out int aryLength);
int[] inAry = Utilities.GenerateArray(aryLength);

Console.Write("Starting array: ");
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();

//TODO:  Waste memory to ensure that the input arrays are truly unique clones of the original at each point instead re-using an existing
//array, since arrays are ref types, "ary" and "inAry" are already declared in memory for the application state and remain int he last
//state regardless of what the appearance of being a new clone of the array appears as.

Console.WriteLine();
Console.WriteLine("Bubble Sort");
sorting_algorithms.BL.Algorithms.Bubble.Sort bubbleSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
bubbleSort.Ascending(Utilities.CloneArray(inAry));
Console.WriteLine("Descending order:");
bubbleSort.Descending(inAry);

Console.WriteLine();
Console.WriteLine("Selection Sort");
sorting_algorithms.BL.Algorithms.Selection.Sort selectionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
selectionSort.Ascending(inAry);
Console.WriteLine("Descending Order:");
selectionSort.Descending(inAry);

Console.WriteLine();
Console.WriteLine("Insertion Sort");
sorting_algorithms.BL.Algorithms.Insertion.Sort insertionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
insertionSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine("Descending Order:");
insertionSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Merge Sort");
sorting_algorithms.BL.Algorithms.Merge.Sort mergeSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
mergeSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine("Descending Order:");
mergeSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Quick Sort");
sorting_algorithms.BL.Algorithms.Quick.Sort quickSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
quickSort.Ascending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine("Descending Order:");
quickSort.Descending(inAry);
foreach (int i in inAry) Console.Write(i.ToString() + ", ");
Console.WriteLine();
Console.WriteLine();