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

//TODO: Implement selection of which algorithm to test, or all of them.
//TODO: Implement selection of ascending, descending, or both
//Above as console inputs

Console.WriteLine();
Console.WriteLine("Bubble Sort");
sorting_algorithms.BL.Algorithms.Bubble.Sort bubbleSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
bubbleSort.Ascending(Utilities.CloneArray(inAry));
Console.WriteLine("Descending order:");
bubbleSort.Descending(Utilities.CloneArray(inAry));

Console.WriteLine();
Console.WriteLine("Selection Sort");
sorting_algorithms.BL.Algorithms.Selection.Sort selectionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
selectionSort.Ascending(Utilities.CloneArray(inAry));
Console.WriteLine("Descending Order:");
selectionSort.Descending(Utilities.CloneArray(inAry));

Console.WriteLine();
Console.WriteLine("Insertion Sort");
sorting_algorithms.BL.Algorithms.Insertion.Sort insertionSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
insertionSort.Ascending(Utilities.CloneArray(inAry));
Console.WriteLine("Descending Order:");
insertionSort.Descending(Utilities.CloneArray(inAry));

Console.WriteLine();
Console.WriteLine("Merge Sort");
sorting_algorithms.BL.Algorithms.Merge.Sort mergeSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
mergeSort.Ascending(Utilities.CloneArray(inAry));
Console.WriteLine("Descending Order:");
mergeSort.Descending(Utilities.CloneArray(inAry));

Console.WriteLine();
Console.WriteLine("Quick Sort");
sorting_algorithms.BL.Algorithms.Quick.Sort quickSort = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine("Asending Order:");
quickSort.Ascending(Utilities.CloneArray(inAry));
Console.WriteLine("Descending Order:");
quickSort.Descending(Utilities.CloneArray(inAry));

Console.WriteLine();