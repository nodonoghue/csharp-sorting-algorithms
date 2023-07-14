﻿// See https://aka.ms/new-console-template for more information
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
sorting_algorithms.Selection.Sort selectionSort = new();
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
sorting_algorithms.Insertion.Sort insertionSort = new();
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
sorting_algorithms.Merge.Sort mergeSort = new();
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
sorting_algorithms.Quick.Sort quickSort = new();
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