// See https://aka.ms/new-console-template for more information
using sorting_algorithms.BL;

Console.WriteLine("Sorting Algorithms");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
Console.Write("Enter length of array: ");
string? aryLengthInput = Console.ReadLine();
while (!Validation.IsNumeric(aryLengthInput))
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

//Bubble Sorts
int[] bubbleAsending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Bubble.Sort.Ascending(bubbleAsending);
Utilities.OutputResults(bubbleAsending, "Bubble", "Ascending");
int[] bubbleDescending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Bubble.Sort.Descending(bubbleDescending);
Utilities.OutputResults(bubbleDescending, "Bubble", "Descending");

//Selection Sorts
int[] selectionAscending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Selection.Sort.Ascending(selectionAscending);
Utilities.OutputResults(selectionAscending, "Selection", "Ascending");
int[] selectionDescending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Selection.Sort.Descending(selectionDescending);
Utilities.OutputResults(selectionDescending, "Selection", "Descending");

//Insertion Sorts
int[] insertionAscending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Insertion.Sort.Ascending(insertionAscending);
Utilities.OutputResults(insertionAscending, "Insertion", "Ascending");
int[] insertionDescending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Insertion.Sort.Descending(insertionDescending);
Utilities.OutputResults(insertionDescending, "Insertion", "Descending");

//Merge Sorts
int[] mergeAscending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Merge.Sort.Ascending(mergeAscending);
Utilities.OutputResults(mergeAscending, "Merge", "Ascending");
int[] mergeDescending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Merge.Sort.Descending(mergeDescending);
Utilities.OutputResults(mergeDescending, "Merge", "Descending");

//Quick Sorts
int[] quickAscending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Quick.Sort.Ascending(quickAscending);
Utilities.OutputResults(quickAscending, "Quick", "Ascending");
int[] quickDescending = Utilities.CloneArray(inAry);
sorting_algorithms.BL.Algorithms.Quick.Sort.Descending(quickDescending);
Utilities.OutputResults(quickDescending, "Quick", "Descending");
