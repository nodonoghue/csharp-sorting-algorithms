﻿namespace sorting_algorithms.BL.Algorithms.Merge
{
    /// <summary>
    /// The merge sort is fairly confusing until thought of recursively, think divide and conquer, over many iterations.
    /// The goal is the recursively split the array into halves until each half is only a single element, and alread sorted
    /// then the MergeSort() function is called within each recursion of the SplitArray() function that will merge the 
    /// array halves from the smallest size recursivelly back until the main array is completely sorted.  
    /// The recursion stops naturally based on the check to ensure that the arr[] argument has a lenght greater than 1.
    /// </summary>
    internal class Sort
    {
        /// <summary>
        /// Merge sort in ascending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public static void Ascending(int[] maAry)
        {
            SplitArray(maAry, true);
        }

        /// <summary>
        /// Merge sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public static void Descending(int[] mdAry)
        {
            SplitArray(mdAry, false);
        }

        /// <summary>
        /// This method is called recursively to split the array into smaller and smaller chunks, 
        /// recursion stops when arrLength == 1
        /// </summary>
        /// <param name="inAry"></param>
        /// <param name="leftIndex"></param>
        /// <param name="rightIndex"></param>
        private static void SplitArray(int[] arr, bool isAsc)
        {
            int arrLength = arr.Length;
            //This method will be recursive until the array length is 1
            if (arrLength > 1)
            {
                int middleIndex = arrLength / 2;

                //split the array into halves based on the middle index
                int[] arrLeft = new int[middleIndex];
                int[] arrRight = new int[arrLength - middleIndex];

                //populate each half
                for (int i = 0; i < middleIndex; i++)
                {
                    arrLeft[i] = arr[i];
                }
                for (int i = middleIndex; i < arrLength; i++)
                {
                    arrRight[i - middleIndex] = arr[i];
                }

                //Recursively split the array halves until each half is only length 1
                SplitArray(arrLeft, isAsc);
                SplitArray(arrRight, isAsc);

                //Merge the two halves back together and sort
                MergeSort(arr, arrLeft, arrRight, isAsc);
            }
        }

        /// <summary>
        /// Merge the two current halves of the array back into the larger sorted array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="leftArray"></param>
        /// <param name="rightArray"></param>
        /// <param name="isAsc"></param>
        private static void MergeSort(int[] arr, int[] leftArray, int[] rightArray, bool isAsc)
        {
            int li = 0, ri = 0, mi = 0;

            while (li < leftArray.Length && ri < rightArray.Length)
            {
                if (isAsc)
                {
                    if (leftArray[li] < rightArray[ri])
                    {
                        arr[mi] = leftArray[li];
                        li++;
                    }
                    else
                    {
                        arr[mi] = rightArray[ri];
                        ri++;
                    }
                }
                else
                {
                    if (leftArray[li] > rightArray[ri])
                    {
                        arr[mi] = leftArray[li];
                        li++;
                    }
                    else
                    {
                        arr[mi] = rightArray[ri];
                        ri++;
                    }
                }

                mi++;
            }

            //Clean up any remaining elements
            while (li < leftArray.Length)
            {
                arr[mi] = leftArray[li];
                mi++;
                li++;
            }
            while (ri < rightArray.Length)
            {
                arr[mi] = rightArray[ri];
                mi++;
                ri++;
            }
        }
    }
}