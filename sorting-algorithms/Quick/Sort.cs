using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
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
    }
}
