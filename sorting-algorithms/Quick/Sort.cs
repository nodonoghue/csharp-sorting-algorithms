using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.Quick
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
    internal class Sort : Interfaces.ISort
    {
        /// <summary>
        /// Quick sort ascending
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int[] Ascending(int[] inAry)
        {
            QuickSort(inAry);
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
            throw new NotImplementedException();
        }

        //Need functions for to create the pivot point
        //then a function to create get the partitions
        //REMEMBER!!  Arrays are ref values, just need to pass around index values, 
        //modify the original input array, this will manupulate the copy that was used
        //to call into the quick sort class
        private void QuickSort(int[] inAry){
            QuickSort(0, inAry.Length - 1, inAry);
        }

        private void QuickSort(int startIndex, int endIndex, int[] inAry)
        {
            if (startIndex >= endIndex) return;

            //select a pivot point, easy is to pick first or last, better on the average is to take the middle point of the array
            //int pivotIndex = startIndex + ((endIndex - startIndex) / 2);
            int pivot = inAry[endIndex];

            //switch the pivot and the right most item
            //Switch(pivotIndex, endIndex, inAry);

            //Create the partition and place the pivot into the correct spot
            Partition(startIndex, endIndex, pivot, inAry);
        }

        private void Switch(int firstIndex, int secondIndex, int[] inAry)
        {
            (inAry[secondIndex], inAry[firstIndex]) = (inAry[firstIndex], inAry[secondIndex]);
        }

        //TODO:  Fix bug where sometimes the last item isn't being swapped as expected, first pass through with my sample array
        //fails to swap the last item as needed.  Not putting higher items to the right.  This appears to happen a few times in 
        //my sample array, causing the last few items to be out of order.
        private void Partition(int startIndex, int endIndex, int pivot, int[] inAry)
        {
            //perform the partitioning here, loop through the array segment from both ends, putting values higher than the pivot to the right
            //and values lower than the pivot to the left.
            int leftIndex = startIndex;
            int rightIndex = endIndex;

            //look while low index is less than the right index
            while (leftIndex < rightIndex)
            {
                //Swap left and right indexes that are lower (left) or higher(right) of the pivot around until all lower are to the left and all higher are to the right
                while(inAry[leftIndex] <= pivot && leftIndex < rightIndex){
                    leftIndex++;
                }

                while (inAry[rightIndex] >= pivot && leftIndex < rightIndex){
                    rightIndex--;
                }

                Switch(leftIndex, rightIndex, inAry);
            }

            //Send the left and right sections through the Quicksorting flow
            QuickSort(startIndex, leftIndex - 1, inAry);
            QuickSort(leftIndex + 1, endIndex, inAry);
        }
    }
}
