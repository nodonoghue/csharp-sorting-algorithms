using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.BL.Algorithms.Quick
{
    /// <summary>
    /// Quick sort is a recursive sorting algorithm that works by selecting a pivot element.
    /// The array is iterated through putting all elements larger to the right of the pivote and
    /// all elements smaller to the left of the pivot, placing the pivot in the correct spot.
    /// Recursively rinse and repeat until all elements have been put into the correct places.
    /// This is done by splitting the array on the pivot into partitions, each partition is 
    /// sent through the pivot to partition code.  Speed depends on pivot point selection,
    /// the median of the array is the best, but needs to be balanced between adding too much
    /// logic surrounding pivot point selection.  General tutorials tend to lean towards taking
    /// the right most element as the pivot point in each iteration.
    /// </summary>
    internal class Sort
    {
        /// <summary>
        /// Quick sort ascending
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int[] Ascending(int[] inAry)
        {
            QuickSort(inAry, true);
            return inAry;
        }

        /// <summary>
        /// Quick sort descending.
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int[] Descending(int[] inAry)
        {
            QuickSort(inAry, false);
            return inAry;
        }

        //Need functions for to create the pivot point
        //then a function to create get the partitions
        //REMEMBER!!  Arrays are ref values, just need to pass around index values, 
        //modify the original input array, this will manupulate the copy that was used
        //to call into the quick sort class
        private void QuickSort(int[] inAry, bool isAsc)
        {
            QuickSort(0, inAry.Length - 1, inAry, isAsc);
        }

        private void QuickSort(int startIndex, int endIndex, int[] inAry, bool isAsc)
        {
            if (startIndex >= endIndex) return;

            //select a pivot point, easy is to pick first or last, better on the average is to take the middle point of the array
            int pivotIndex = startIndex + (endIndex - startIndex) / 2;
            int pivot = inAry[pivotIndex];
            Switch(pivotIndex, endIndex, inAry);

            //Create the partition and place the pivot into the correct spot
            int leftPointer = Partition(startIndex, endIndex, pivot, inAry, isAsc);

            //Send the left and right sections through the Quicksorting flow
            QuickSort(startIndex, leftPointer - 1, inAry, isAsc);
            QuickSort(leftPointer + 1, endIndex, inAry, isAsc);
        }

        //Switch, code analysis recommended using tuples to swap values instead of using a temp value and two additional lines of code for the
        //array value swap
        private static void Switch(int firstIndex, int secondIndex, int[] inAry)
        {
            (inAry[secondIndex], inAry[firstIndex]) = (inAry[firstIndex], inAry[secondIndex]);
        }

        private static int Partition(int startIndex, int endIndex, int pivot, int[] inAry, bool isAsc)
        {
            //perform the partitioning here, loop through the array segment from both ends, putting values higher than the pivot to the right
            //and values lower than the pivot to the left.
            int leftIndex = startIndex;
            int rightIndex = endIndex;

            //look while low index is less than the right index
            while (leftIndex < rightIndex)
            {
                //Swap left and right indexes that are lower (left) or higher(right) of the pivot around until all lower are to the left and all higher are to the right
                if (isAsc)
                {
                    while (inAry[leftIndex] <= pivot && leftIndex < rightIndex)
                    {
                        leftIndex++;
                    }

                    while (inAry[rightIndex] >= pivot && leftIndex < rightIndex)
                    {
                        rightIndex--;
                    }
                }
                else  //Switch directionality of the value checks to sort in descending order
                {
                    while (inAry[leftIndex] >= pivot && leftIndex < rightIndex)
                    {
                        leftIndex++;
                    }

                    while (inAry[rightIndex] <= pivot && leftIndex < rightIndex)
                    {
                        rightIndex--;
                    }
                }

                //Once the incrimenting and decrimenting have completed, swap the values at the pointers
                Switch(leftIndex, rightIndex, inAry);
            }

            //Added this, someitems weren't being swapped as expected, this addition to the original attempt checks to see if the endIndex is less than the leftIndex point
            //in the array, if so swaps the endIndex value with the leftIndex value to force the missed swap.
            if (isAsc)
            {
                if (inAry[leftIndex] > inAry[endIndex]) Switch(leftIndex, endIndex, inAry);
            }
            else  //Switch directionality of the test for the final clean up swap for a descending order sort.
            {
                if (inAry[leftIndex] < inAry[endIndex]) Switch(leftIndex, endIndex, inAry);
            }

            return leftIndex;
        }
    }
}
